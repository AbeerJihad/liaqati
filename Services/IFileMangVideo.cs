namespace liaqati_master.Services
{
    public interface IFormFileMangVideo
    {
        public Task<string> Upload(IFormFile fm, string filename);
        public void DeleteFile(string OldFileName);
    }
    public class RepoFileVideo : IFormFileMangVideo
    {
        readonly IWebHostEnvironment _web;
        public RepoFileVideo(IWebHostEnvironment web)
        {
            _web = web;
        }
        public void DeleteFile(string OldFileName)
        {
            if (File.Exists(OldFileName))
            {
                File.Delete(OldFileName);
            }
        }
        public async Task<string> Upload(IFormFile fm, string Foldername)
        {

            string Folder = _web.WebRootPath + "//Video//" + Foldername;
            if (!File.Exists(Folder))
            {
                Directory.CreateDirectory(Folder);
            }
            string filename = Guid.NewGuid().ToString() + Path.GetExtension(fm.FileName);
            string pathAll = Folder + "//" + filename;

            FileStream fs = new(pathAll, FileMode.Create);
            await fm.CopyToAsync(fs);
            await fs.FlushAsync();
            fs.Close();

            return $"/Video//{Foldername}//{filename}";
        }
    }
}

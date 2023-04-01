namespace liaqati_master.Services
{
    public interface IFormFileMang
    {
        public Task<string> Upload(IFormFile fm, string BaseFolderName, string filename);
        public void DeleteFile(string OldFileName);
    }
    public class RepoFile : IFormFileMang
    {
        private readonly IWebHostEnvironment _web;

        public RepoFile(IWebHostEnvironment web)
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

        public async Task<string> Upload(IFormFile fm, string BaseFolderName, string Foldername)
        {

            string Folder = _web.WebRootPath + "//" + BaseFolderName + "//" + Foldername;
            if (!File.Exists(BaseFolderName))
            {
                Directory.CreateDirectory(BaseFolderName);
            }
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


            return $"/{BaseFolderName}//{Foldername}//{filename}";
        }
    }


}

namespace liaqati_master.Services
{
    public interface IFormFileMang
    {
        public Task<string> Upload(IFormFile fm, string filename);
        public void DeleteFile(string OldFileName);
    }


    public class RepoFile : IFormFileMang
    {
        IWebHostEnvironment _web;

        public RepoFile(IWebHostEnvironment web)
        {
            _web = web;
        }

        public void DeleteFile(string OldFileName)
        {
            if (System.IO.File.Exists(OldFileName))
            {
                System.IO.File.Delete(OldFileName);

            }
        }

        public async Task<string> Upload(IFormFile fm, string Foldername)
        {

            string Folder = _web.WebRootPath + "//Images//" + Foldername;
            if (!System.IO.File.Exists(Folder))
            {
                System.IO.Directory.CreateDirectory(Folder);
            }
            string filename = Guid.NewGuid().ToString() + Path.GetExtension(fm.FileName);
            string pathAll = Folder + "//" + filename;

            FileStream fs = new FileStream(pathAll, FileMode.Create);
            await fm.CopyToAsync(fs);

            await fs.FlushAsync();
            fs.Close();


            return $"/Images//{Foldername}//{filename}";
        }
    }


}

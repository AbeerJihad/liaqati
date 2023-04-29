#nullable disable
namespace liaqati_master.Services
{
    public interface IFormFileMang
    {
        public Task<string> Upload(IFormFile fm, string BaseFolderName, string filename);
        public IFormFile DownLoad(string path);
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
            if (File.Exists(_web.WebRootPath + OldFileName))
            {
                File.Delete(_web.WebRootPath + OldFileName);
            }
        }

        public IFormFile DownLoad(string path)
        {
            path = _web.WebRootPath + path;
            string fileName = Path.GetFileName(path);
            using Stream stream = new FileStream(path, FileMode.Open);
            IFormFile file = new FormFile(stream, 0, stream.Length, null, fileName);
            return file;
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
            string filename = Guid.NewGuid().ToString() + Path.GetFileNameWithoutExtension(fm.FileName) + Path.GetExtension(fm.FileName);
            string pathAll = Folder + "//" + filename;

            FileStream fs = new(pathAll, FileMode.Create);
            await fm.CopyToAsync(fs);
            await fs.FlushAsync();
            fs.Close();
            return $"/{BaseFolderName}//{Foldername}//{filename}";
        }


    }


}

namespace liaqati_master.Models
{
    public interface IFormFileMangVedio
    {
        public Task<string> Upload(IFormFile fm, string filename);
        public void DeleteFile(string OldFileName);
    }


    public class RepoFileVedio : IFormFileMangVedio
    {
        IWebHostEnvironment _web;

        public RepoFileVedio(IWebHostEnvironment web)
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

            string Folder = _web.WebRootPath + "//Vedio//" + Foldername;
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


            return $"/Vedio//{Foldername}//{filename}";
        }
    }


}

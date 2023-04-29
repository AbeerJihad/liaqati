using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Products
{
    public class CreateProductModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;
        private readonly IFormFileMang _IFormFileMang;
        private readonly IRepoFiles _RepoFiles;


        public CreateProductModel(LiaqatiDBContext context, UnitOfWork unitOfWork, IFormFileMang iFormFileMang, IRepoFiles repoFiles)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
            CatogeryName = new SelectList(_UnitOfWork.CategoryRepository.GetAllEntity(), nameof(Category.Id), nameof(Category.Name));
            _IFormFileMang = iFormFileMang;
            _RepoFiles = repoFiles;
        }

        public SelectList CatogeryName { get; set; }

        [BindProperty, Required]
        public IFormFileCollection Images { get; set; }

        [BindProperty]
        public liaqati_master.Models.Product Products { get; set; }

        public IActionResult OnGet() => Page();
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string Id = CommonMethods.Id_Guid();
            Products.Id = Id;
            Products.Services!.Id = Id;
            var id = Products.Services!.Category!.Id;
            if (id != null)
            {
                Products.Services.CategoryId = id;

            }
            Products.Services.Category = null;
            _UnitOfWork.ProductsRepository.Insert(Products);
            _UnitOfWork.ServiceRepository.Insert(Products.Services);
            _UnitOfWork.Save();

            List<Files> ImagesPaths = new();

            foreach (var item in Images)
            {
                ImagesPaths.Add(new Files() { Id = CommonMethods.Id_Guid(), ServiceId = Id, Path = await _IFormFileMang.Upload(item, "images", "products") });
            }
            if (ImagesPaths.Count > 0)
            {
                Products.ImgUrl = ImagesPaths[0].Path;
            }
            await _RepoFiles.AddRangeOfFiles(ImagesPaths);
            await _RepoFiles.SaveAsync();


            return RedirectToPage("./Index");
        }
    }
}

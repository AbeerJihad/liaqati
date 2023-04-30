#nullable disable

namespace liaqati_master.Pages.Products
{
    public class CreateProductModel : PageModel
    {
        private readonly IRepoProducts _repoProducts;
        private readonly IRepoCategory _repoCategory;
        private readonly IRepoService _repoService;
        private readonly IFormFileMang _IFormFileMang;
        private readonly IRepoFiles _RepoFiles;


        public CreateProductModel(IFormFileMang iFormFileMang, IRepoFiles repoFiles, IRepoProducts repoProducts, IRepoCategory repoCategory, IRepoService repoService)
        {
            _IFormFileMang = iFormFileMang;
            _RepoFiles = repoFiles;
            _repoProducts = repoProducts;
            _repoCategory = repoCategory;
            _repoService = repoService;
        }

        public SelectList CatogeryName { get; set; }

        [BindProperty, Required(ErrorMessage = "أضف صورة واحدة على الأقل"), Display(Name = "أصف صور المنتج")]
        public IFormFileCollection Images { get; set; }

        [BindProperty]
        public Product Products { get; set; }
        public async Task OnGet()
        {
            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(
                c => c.Target == Database.GetListOfTargets()[nameof(Product)]),
                nameof(Category.Id), nameof(Category.Name));

        }
        public async Task<IActionResult> OnPostAsync()
        {

            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(
                c => c.Target == Database.GetListOfTargets()[nameof(Product)]),
                nameof(Category.Id), nameof(Category.Name));
            if (!ModelState.IsValid)
            {
                return Page();
            }
            string Id = CommonMethods.Id_Guid();
            Products.Id = Id;
            Products.Services!.Id = Id;
            await _repoService.AddEntityAsync(Products.Services);
            await _repoProducts.AddEntityAsync(Products);
            List<Files> ImagesPaths = new();
            foreach (var item in Images)
            {
                ImagesPaths.Add(new Files() { Id = CommonMethods.Id_Guid(), ServiceId = Id, Path = await _IFormFileMang.Upload(item, "images", "products") });
            }
            if (ImagesPaths.Count > 0)
            {
                Products.ImgUrl = ImagesPaths[0].Path;
            }
            await _repoProducts.UpdateEntityAsync(Products);
            await _RepoFiles.AddRangeOfFiles(ImagesPaths);
            return RedirectToPage("./Index");
        }
    }
}

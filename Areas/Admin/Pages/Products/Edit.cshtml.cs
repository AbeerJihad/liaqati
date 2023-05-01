#nullable disable
namespace liaqati_master.Pages.Products
{
    public class EditProductModel : PageModel
    {

        private readonly IRepoProducts _repoProducts;
        private readonly IRepoCategory _repoCategory;
        private readonly IRepoService _repoService;
        private readonly IFormFileMang _IFormFileMang;
        private readonly IRepoFiles _RepoFiles;
        public EditProductModel(IFormFileMang iFormFileMang, IRepoFiles repoFiles, IRepoProducts repoProducts, IRepoCategory repoCategory, IRepoService repoService)
        {
            _IFormFileMang = iFormFileMang;
            _RepoFiles = repoFiles;
            _repoProducts = repoProducts;
            _repoCategory = repoCategory;
            _repoService = repoService;
        }
        public SelectList CatogeryName { get; set; }


        [BindProperty(SupportsGet = true)]
        public Product ProductItem { get; set; }

        [BindProperty, Required(ErrorMessage = "أضف صورة واحدة على الأقل"), Display(Name = "أصف صور المنتج")]
        public IFormFileCollection Images { get; set; }
        public List<string> paths { get; set; }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Product)]), nameof(Category.Id), nameof(Category.Name));

            if (id == null)
            {
                return NotFound();
            }

            var product = await _repoProducts.GetByIDAsync(id);

            paths = (await _RepoFiles.GetAllAsync()).Where(file => file.ServiceId == product.Id).Select(fil => fil.Path).ToList();
            if (product == null)
            {
                return NotFound();
            }
            ProductItem = product;

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Product)]), nameof(Category.Id), nameof(Category.Name));


            if (!ModelState.IsValid)
            {
                return Page();
            }

            var id = ProductItem.Id;
            var item = await _repoProducts.GetByIDAsync(id);
            item.Services!.Title = ProductItem.Services!.Title;
            item.Services.Price = ProductItem.Services.Price;
            item.Services.Description = ProductItem.Services.Description;
            item.Discount = ProductItem.Discount;
            if (Images?.Count > 0)
            {
                List<Files> ImagesPaths = new();
                foreach (var formFile in Images)
                {
                    ImagesPaths.Add(new Files() { Id = CommonMethods.Id_Guid(), ServiceId = id, Path = await _IFormFileMang.Upload(formFile, "images", "products") });
                }
                List<Files> images = (await _RepoFiles.GetAllAsync()).Where(file => file.ServiceId == ProductItem.Id).ToList();
                foreach (var image in images)
                {
                    await _RepoFiles.DeleteEntityAsync(image);
                    _IFormFileMang.DeleteFile(image.Path);

                }
                await _RepoFiles.AddRangeOfFiles(ImagesPaths);
                await _RepoFiles.SaveAsync();
                if (ImagesPaths.Count > 0)
                {
                    ProductItem.ImgUrl = ImagesPaths[0].Path;
                }


            }

            await _repoProducts.UpdateEntityAsync(item);

            return RedirectToPage();

            //  _context.Attach(MealPlans).State = EntityState.Modified;

        }
    }
}
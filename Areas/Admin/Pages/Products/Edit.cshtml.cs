using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Products
{
    public class EditProductModel : PageModel
    {

        private readonly LiaqatiDBContext _context;

        private readonly UnitOfWork _UnitOfWork;
        private readonly IFormFileMang _IFormFileMang;
        private readonly RepoFiles _RepoFiles;

        public EditProductModel(LiaqatiDBContext context, UnitOfWork unitOfWork, IFormFileMang iFormFileMang, RepoFiles repoFiles)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
            _IFormFileMang = iFormFileMang;
            _RepoFiles = repoFiles;
            CatogeryName = new SelectList(_UnitOfWork.CategoryRepository.GetAllEntity(), nameof(Category.Id), nameof(Category.Name));

        }

        public SelectList CatogeryName { get; set; }


        [BindProperty(SupportsGet = true)]
        public Product Product { get; set; }
        [BindProperty]
        public IFormFileCollection? Images { get; set; }
        public List<string?> paths { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _UnitOfWork.ProductsRepository.GetByID(id);

            paths = (await _RepoFiles.GetAllAsync()).Where(file => file.ServiceId == product.Id).Select(fil => fil.Path).ToList();

            if (product == null)
            {
                return NotFound();
            }
            Product = product;

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPost()
        {

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            var id = Product.Id;
            var item = _UnitOfWork.ProductsRepository.GetByID(id);
            item.Services!.Title = Product.Services!.Title;
            item.Services.Price = Product.Services.Price;
            item.Services.Description = Product.Services.Description;
            item.Discount = Product.Discount;


            var cid = Product.Services!.Category!.Id;
            if (id != null)
            {
                Product.Services.CategoryId = id;

            }

            item.Services.Category = null;

            if (Images?.Count > 0)
            {
                List<Files> ImagesPaths = new();
                foreach (var formFile in Images)
                {
                    ImagesPaths.Add(new Files() { Id = CommonMethods.Id_Guid(), ServiceId = id, Path = await _IFormFileMang.Upload(formFile, "images", "products") });
                }

                List<Files> images = (await _RepoFiles.GetAllAsync()).Where(file => file.ServiceId == Product.Id).ToList();

                foreach (var image in images)
                {
                    await _RepoFiles.DeleteEntityAsync(image);
                    _IFormFileMang.DeleteFile(image.Path);

                }

                await _RepoFiles.AddRangeOfFiles(ImagesPaths);
                await _RepoFiles.SaveAsync();
                if (ImagesPaths.Count > 0)
                {
                    Product.ImgUrl = ImagesPaths[0].Path;
                }


            }

            _UnitOfWork.ProductsRepository.Update(item);

            //  _context.Attach(MealPlans).State = EntityState.Modified;

            try
            {
                _UnitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(Product.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StudentExists(string id)
        {
            return _context.TblMealPlans.Any(e => e.Id == id);
        }
    }
}

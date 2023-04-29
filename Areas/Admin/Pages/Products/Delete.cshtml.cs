using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Products
{
    public class DeleteProductModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;

        public DeleteProductModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
        }

        [BindProperty]
        public liaqati_master.Models.Product Product { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var product = _UnitOfWork.ProductsRepository.GetByID(id);

            if (product == null)
            {
                return NotFound();
            }
            else
            {
                Product = product;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == null || _context.TblMealPlans == null)
            {
                return NotFound();
            }

            var product = _UnitOfWork.ProductsRepository.GetByID(id);

            if (product != null)
            {
                Product = product;

                _UnitOfWork.ProductsRepository.Delete(product);
                _UnitOfWork.Save();


            }

            return RedirectToPage("./Index");
        }
    }
}

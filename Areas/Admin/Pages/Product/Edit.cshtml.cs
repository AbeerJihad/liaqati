using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace liaqati_master.Pages.Product
{
    public class EditProductModel : PageModel
    {

        private readonly LiaqatiDBContext _context;

        private readonly UnitOfWork _UnitOfWork;

        public EditProductModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
        }

        public List<SelectListItem> CatogeryName { get; set; }


        [BindProperty(SupportsGet =true)]
        public Products Product { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var product =  _UnitOfWork.ProductsRepository.GetByID(id);
            if (product == null)
            {
                return NotFound();
            }
            Product = product;

            CatogeryName = _UnitOfWork.CategoryRepository.GetAllEntity().Select(a =>
                                       new SelectListItem
                                       {
                                           Value = a.Id.ToString(),
                                           Text = a.Name
                                       }).ToList();


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

            var id= Product.Id;

        var item= _UnitOfWork.ProductsRepository.GetByID(id);
            item.services!.Title = Product.services!.Title;
            item.services.Price = Product.services.Price;
            item.services.Description = Product.services.Description;
            item.Discount = Product.Discount;


            var cid = Product.services!.Category!.Id;
            if (id != null)
            {
                Product.services.CategoryId = id;

            }

            item.services.Category = null;


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

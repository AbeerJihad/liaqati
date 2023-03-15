using liaqati_master.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Product
{
    public class CreateProductModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;

        public CreateProductModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
        }

        public List<SelectListItem> CatogeryName { get; set; }

        public IActionResult OnGet()
        {
            


            CatogeryName = _UnitOfWork.CategoryRepository.GetAllEntity().Select(a =>
                                         new SelectListItem
                                         {
                                             Value = a.Id.ToString(), Text = a.Name
                                         }).ToList();


            return Page();
        }
       








        [BindProperty]
        public Products Products { get; set; }

       


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAddAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}



            Products.Id = Guid_Id.Id_Guid();

            Products.services!.Id= Products.Id;

            Products.services.ProductsId = Products.Id;

          // MealPlans.servicesId = MealPlans.Id;

            var id = Products.services!.Category!.Id;
            if (id != null)
            {
                Products.services.CategoryId = id;

            }
            Products.services.Category = null;




            _UnitOfWork.ProductsRepository.Insert(Products);
            _UnitOfWork.ServiceRepository.Insert(Products.services);


            _UnitOfWork.Save();
            


            return RedirectToPage("./Index");
        }
    }
}

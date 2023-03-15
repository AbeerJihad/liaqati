using liaqati_master.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.HealthyReicpe
{
    public class CreateHealthyModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;

        public CreateHealthyModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
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
        public HealthyRecipes HealthyRecipes { get; set; }

       


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAddAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}



            HealthyRecipes.Id = Guid_Id.Id_Guid();

            HealthyRecipes.services!.Id= HealthyRecipes.Id;

            HealthyRecipes.services.HealthyRecipesId = HealthyRecipes.Id;

          // MealPlans.servicesId = MealPlans.Id;

            var id = HealthyRecipes.services!.Category!.Id;
            if (id != null)
            {
                HealthyRecipes.services.CategoryId = id;

            }
            HealthyRecipes.services.Category = null;

            HealthyRecipes.Image = "";


            _UnitOfWork.HealthyRecipesRepository.Insert(HealthyRecipes);
            _UnitOfWork.ServiceRepository.Insert(HealthyRecipes.services);


            _UnitOfWork.Save();
            


            return RedirectToPage("./Index");
        }
    }
}

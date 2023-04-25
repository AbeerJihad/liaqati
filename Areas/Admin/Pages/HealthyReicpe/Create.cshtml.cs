using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.HealthyReicpe
{
    public class CreateHealthyModel : PageModel
    {
        private readonly UnitOfWork _UnitOfWork;

        public CreateHealthyModel(UnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
            CatogeryName = new SelectList(
              _UnitOfWork.CategoryRepository.GetAllEntity(),
              nameof(Category.Id),
              nameof(Category.Name)
              );
            DietaryTypeStatusList = Database.GetListOfDietaryType();
            MealTypeTypeStatusList = Database.GetListOfMealType();

        }

        public SelectList CatogeryName { get; set; }
        public List<SelectListItem> DietaryTypeStatusList { get; set; }
        public List<SelectListItem> MealTypeTypeStatusList { get; set; }



        [BindProperty]
        public HealthyRecipe HealthyRecipes { get; set; }

        public IActionResult OnGet()
        {

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var guid = CommonMethods.Id_Guid();
            HealthyRecipes.Id = guid;
            HealthyRecipes!.Id = guid;
            //var id = HealthyRecipes.Category?.Id;

            //if (id != null)
            //{
            //    HealthyRecipes.CategoryId = id;
            //}

            HealthyRecipes.Image = "";
            _UnitOfWork.HealthyRecipesRepository.Insert(HealthyRecipes);
            _UnitOfWork.Save();
            return RedirectToPage("./Index");
        }
    }
}

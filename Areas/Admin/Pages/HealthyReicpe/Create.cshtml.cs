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


        [BindProperty(SupportsGet = true)]
        public List<VmCheckBox> lstCheckBox { get; set; }

        public List<string> MealType { get; set; } = Database.GetListOfMealType().Select(b => b.Value).ToList();






        public IActionResult OnGet()
        {
            foreach (var item in MealType)
            {
                lstCheckBox.Add(new VmCheckBox() { Name = item });

            }

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

            HealthyRecipes.MealType = string.Join(',', lstCheckBox.Where(ch => ch.IsChecked).Select(ch => ch.Name));


            HealthyRecipes.Image = "";
            _UnitOfWork.HealthyRecipesRepository.Insert(HealthyRecipes);
            _UnitOfWork.Save();
            return RedirectToPage("./Index");
        }
    }
}

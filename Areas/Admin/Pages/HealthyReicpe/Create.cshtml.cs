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
        }

        public SelectList CatogeryName { get; set; }



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
            HealthyRecipes.Services!.Id = guid;
            var id = HealthyRecipes.Services!.Category?.Id;

            if (id != null)
            {
                HealthyRecipes.Services.CategoryId = id;
            }
            HealthyRecipes.Services.Category = null;
            HealthyRecipes.Image = "";
            _UnitOfWork.ServiceRepository.Insert(HealthyRecipes.Services);
            _UnitOfWork.HealthyRecipesRepository.Insert(HealthyRecipes);
            _UnitOfWork.Save();
            return RedirectToPage("./Index");
        }
    }
}

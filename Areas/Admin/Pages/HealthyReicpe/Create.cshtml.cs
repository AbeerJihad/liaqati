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

        public SelectList CatogeryName { get; set; }


        [BindProperty]
        public HealthyRecipes HealthyRecipes { get; set; }

        public IActionResult OnGet()
        {

            CatogeryName = new SelectList(
                _UnitOfWork.CategoryRepository.GetAllEntity(),
                nameof(Category.Id),
                nameof(Category.Name)
                );
            return Page();
        }

        public async Task<IActionResult> OnPostAddAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var guid = Guid_Id.Id_Guid();
            HealthyRecipes.Id = guid;
            HealthyRecipes.services!.Id = guid;
            var id = HealthyRecipes.services!.Category!.Id;

            if (id != null)
            {
                HealthyRecipes.services.CategoryId = id;
            }
            HealthyRecipes.services.Category = null;
            HealthyRecipes.Image = "";
            _UnitOfWork.ServiceRepository.Insert(HealthyRecipes.services);
            _UnitOfWork.HealthyRecipesRepository.Insert(HealthyRecipes);
            _UnitOfWork.Save();
            return RedirectToPage("./Index");
        }
    }
}

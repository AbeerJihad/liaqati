using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace liaqati_master.Pages.HealthyReicpe
{
    public class DeleteHealthyModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;

        public DeleteHealthyModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
        }

        [BindProperty]
        public HealthyRecipe HealthyRecipe { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null )
            {
                return NotFound();
            }


            HealthyRecipe healthyRecipe = _UnitOfWork.HealthyRecipesRepository.GetByID(id);

            if (healthyRecipe == null)
            {
                return NotFound();
            }
            else
            {
                HealthyRecipe = healthyRecipe;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            HealthyRecipe healthyRecipe = _UnitOfWork.HealthyRecipesRepository.GetByID(id);

            if (healthyRecipe != null)
            {
                HealthyRecipe = healthyRecipe;

                _UnitOfWork.HealthyRecipesRepository.Delete(HealthyRecipe);
                _UnitOfWork.Save();

            
            }

            return RedirectToPage("./Index");
        }
    }
}

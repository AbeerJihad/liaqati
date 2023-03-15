using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace liaqati_master.Pages.MealPlan
{
    public class DeleteModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;

        public DeleteModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
        }

        [BindProperty]
        public MealPlans MealPlans { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null || _context.TblMealPlans == null)
            {
                return NotFound();
            }

            var meal = await _context.TblMealPlans.FirstOrDefaultAsync(m => m.Id == id);

            if (meal == null)
            {
                return NotFound();
            }
            else
            {
                MealPlans = meal;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == null || _context.TblMealPlans == null)
            {
                return NotFound();
            }

            var meal = await _context.TblMealPlans.FindAsync(id);

            if (meal != null)
            {
                MealPlans = meal;

                _UnitOfWork.MealPlansRepository.Delete(meal);
                _UnitOfWork.Save();

            
            }

            return RedirectToPage("./Index");
        }
    }
}

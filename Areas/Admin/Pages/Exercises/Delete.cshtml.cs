using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace liaqati_master.Pages.Exercises
{
    public class DeleteExerciseModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;

        public DeleteExerciseModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
        }

        [BindProperty]
        public Exercise Exercise { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null )
            {
                return NotFound();
            }


            var exercise = _UnitOfWork.ExerciseRepository.GetByID(id);

            if (exercise == null)
            {
                return NotFound();
            }
            else
            {
                Exercise = exercise;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var exercise = _UnitOfWork.ExerciseRepository.GetByID(id);

            if (exercise != null)
            {
                Exercise = exercise;

                _UnitOfWork.ExerciseRepository.Delete(exercise);
                _UnitOfWork.Save();

            
            }

            return RedirectToPage("./Index");
        }
    }
}

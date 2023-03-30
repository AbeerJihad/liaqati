using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Exercises
{
    public class DeleteExerciseModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;
        private readonly IFormFileMang _repoFile;

        public DeleteExerciseModel(LiaqatiDBContext context, UnitOfWork unitOfWork,
            IFormFileMang repoFile

            )
        {
            _context = context;
            _UnitOfWork = unitOfWork;
            _repoFile = repoFile;
        }

        [BindProperty]
        public Exercise Exercise { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null)
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
            if (id == null)
            {
                return NotFound();
            }

            var exercise = _UnitOfWork.ExerciseRepository.GetByID(id);

            if (exercise != null)
            {
                Exercise = exercise;


                _repoFile.DeleteFile(Exercise.Image);
                _repoFile.DeleteFile(Exercise.Video);


                _UnitOfWork.ExerciseRepository.Delete(Exercise);
                _UnitOfWork.Save();


            }

            return RedirectToPage("./Index");
        }
    }
}

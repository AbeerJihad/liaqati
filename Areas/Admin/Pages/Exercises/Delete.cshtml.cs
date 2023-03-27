using liaqati_master.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace liaqati_master.Pages.Exercises
{
    public class DeleteExerciseModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;
        private readonly IFormFileMang _repoFile;
        private readonly IFormFileMangVedio _repoFileVedio;

        public DeleteExerciseModel(LiaqatiDBContext context, UnitOfWork unitOfWork,
            IFormFileMang repoFile,
         IFormFileMangVedio repoFileVedio
            
            )
        {
            _context = context;
            _UnitOfWork = unitOfWork;
            _repoFile = repoFile;
            _repoFileVedio= repoFileVedio;
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


                _repoFile.DeleteFile(Exercise.Image);
                _repoFileVedio.DeleteFile(Exercise.Video);


                _UnitOfWork.ExerciseRepository.Delete(Exercise);
                _UnitOfWork.Save();

            
            }

            return RedirectToPage("./Index");
        }
    }
}

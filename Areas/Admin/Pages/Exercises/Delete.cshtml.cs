namespace liaqati_master.Areas.Admin.Pages.Exercises
{
    public class DeleteExerciseModel : PageModel
    {
        private readonly IRepoExercise _repoExercise;
        private readonly IFormFileMang _repoFile;

        public DeleteExerciseModel(IRepoExercise repoExercise, IFormFileMang repoFile)
        {
            _repoExercise = repoExercise;
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


            var exercise = await _repoExercise.GetByIDAsync(id);

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

            var exercise = await _repoExercise.GetByIDAsync(id);

            if (exercise != null)
            {
                Exercise = exercise;
                _repoFile.DeleteFile(Exercise.Image);
                _repoFile.DeleteFile(Exercise.Video);
                await _repoExercise.DeleteEntityAsync(Exercise);

            }

            return RedirectToPage("./Index");
        }
    }
}

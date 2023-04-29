namespace liaqati_master.Areas.Admin.Pages.Exercises
{
    public class ExerciesDetailsModel : PageModel
    {
        private readonly IRepoExercise _repoExercise;

        public ExerciesDetailsModel(IRepoExercise repoExercise)
        {
            _repoExercise = repoExercise;
        }

        [BindProperty(SupportsGet = true)]
        public Exercise Exercise { set; get; }


        public async Task<IActionResult> OnGet()
        {
            string id = "5aa7b21d-8112-41fe-8607-80b255b45bce";
            var exercise = await _repoExercise.GetByIDAsync(id);
            if (exercise == null)
            {
                return NotFound();
            }
            Exercise = exercise;

            return Page();
        }
    }
}

namespace liaqati_master.Areas.Admin.Pages.Exercises
{
    public class IndexExerciseModel : PageModel
    {
        private readonly IRepoExercise _repoExercise;

        public IndexExerciseModel(IRepoExercise repoExercise)
        {
            _repoExercise = repoExercise;
        }

        public IList<Exercise> Exercises { get; set; }
        public async Task OnGetAsync()
        {
            if (_repoExercise != null)
            {

                Exercises = (await _repoExercise.GetAllAsync()).ToList();
            }
        }
    }
}

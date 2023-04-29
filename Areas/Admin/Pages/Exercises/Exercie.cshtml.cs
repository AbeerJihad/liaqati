namespace liaqati_master.Areas.Admin.Pages.Exercises
{
    public class ExercieModel : PageModel
    {
        private readonly IRepoExercise _repoExercise;
        private readonly IFormFileMang _repoFile;

        public ExercieModel(IRepoExercise repoExercise, IFormFileMang repoFile)
        {
            _repoExercise = repoExercise;
            _repoFile = repoFile;
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

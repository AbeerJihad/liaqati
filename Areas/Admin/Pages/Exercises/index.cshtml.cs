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
        [BindProperty(SupportsGet = true)]
        public ExerciseQueryParamters ExerciseQueryParamters { get; set; }
        public QueryPageResult<Exercise> QueryPageResult { get; set; }
        public bool IsGrid { get; set; }
        public IEnumerable<SelectListItem> lstPageSize { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem(){Value="5", Text="5"},
            new SelectListItem(){Value="10", Text="10"},
            new SelectListItem(){Value="20", Text="20"}
        };
        public IEnumerable<SelectListItem> Titles { get; set; }
        public IEnumerable<SelectListItem> Categoires { get; set; }
        public IEnumerable<SelectListItem> BodyFocus { get; set; } = Database.GetListOfBodyFocus();
        public IEnumerable<SelectListItem> TraningType { get; set; } = Database.GetListOfTrainingType();
        public IEnumerable<SelectListItem> Difficulty { get; set; } = Database.GetListOfDifficulty();
        public IEnumerable<SelectListItem> Equipment { get; set; } = Database.GetListOfEquipment();
        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value=nameof(Exercise.Title),Text="العنوان"},
            new SelectListItem(){Value=nameof(Exercise.Price),Text="السعر"},
            new SelectListItem(){Value=nameof(Exercise.Difficulty),Text="الصعوبة"},
            new SelectListItem(){Value=nameof(Exercise.Duration),Text="المدة"},
        };

        public async Task OnGetAsync()
        {
            Titles = new SelectList((await _repoExercise.GetAllAsync()).ToList(), nameof(Exercise.Title), nameof(Exercise.Title)); if (_repoExercise != null)
            {
                QueryPageResult = await _repoExercise.SearchExercies(ExerciseQueryParamters);
            }
        }
    }
}

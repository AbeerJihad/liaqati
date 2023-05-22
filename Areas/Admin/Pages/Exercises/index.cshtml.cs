namespace liaqati_master.Areas.Admin.Pages.Exercises
{
    public class IndexExerciseModel : PageModel
    {
        private readonly IRepoExercise _repoExercise;
        private readonly SignInManager<User> _signInManager;

        public IndexExerciseModel(IRepoExercise repoExercise, SignInManager<User> signInManager)
        {
            _repoExercise = repoExercise;
            _signInManager = signInManager;

        }
        public IList<Exercise> Exercises { get; set; }
        [BindProperty(SupportsGet = true)]
        public ExerciseQueryParamters ExerciseQueryParamters { get; set; }
        public QueryPageResult<ExerciseVM> QueryPageResult { get; set; }
        public bool IsGrid { get; set; }
        public IEnumerable<SelectListItem> lstPageSize { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem(){Value="5", Text="5"},
            new SelectListItem(){Value="10", Text="10"},
            new SelectListItem(){Value="20", Text="20"}
        };

        public List<(string, string)>? ListOfSelectedFilters { get; set; }
        public IEnumerable<SelectListItem> Titles { get; set; }
        public IEnumerable<SelectListItem> Categoires { get; set; }
        public IEnumerable<SelectListItem> BodyFocus { get; set; } = Database.GetListOfBodyFocus();
        public IEnumerable<SelectListItem> TraningType { get; set; } = Database.GetListOfTrainingType();
        public IEnumerable<SelectListItem> Difficulty { get; set; } = Database.GetListOfDifficulty();
        public IEnumerable<SelectListItem> Equipment { get; set; } = Database.GetListOfEquipment();


        [BindProperty(SupportsGet = true)]
        public string BodyFocusParams { get; set; }
        [BindProperty(SupportsGet = true)]

        public string TraningTypeParams { get; set; }
        [BindProperty(SupportsGet = true)]

        public string DifficultyParams { get; set; }
        [BindProperty(SupportsGet = true)]

        public string EquipmentParams { get; set; }
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
                if (_signInManager.IsSignedIn(User))
                {
                    if (User.FindFirstValue(Database.Expert) != null)
                    {
                        var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                        ExerciseQueryParamters.UserId = userid;
                    }


                }
                QueryPageResult = await _repoExercise.SearchExercies(ExerciseQueryParamters);
            }
        }
    }
}

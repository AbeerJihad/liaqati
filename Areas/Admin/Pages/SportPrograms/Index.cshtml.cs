namespace liaqati_master.Areas.Admin.Pages.Programs
{
    public class IndexProgramModel : PageModel
    {
        private readonly IRepoProgram _repoProgram;
        private readonly SignInManager<User> _signInManager;

        public IndexProgramModel(IRepoProgram repoProgram, SignInManager<User> signInManager)
        {
            _repoProgram = repoProgram;
            _signInManager = signInManager;
        }
        public IList<Exercise> Exercises { get; set; }
        [BindProperty(SupportsGet = true)]
        public SportProgramQueryParamters SportProgramQueryParamters { get; set; }
        public QueryPageResult<SportProgramVM> QueryPageResult { get; set; }
        public IEnumerable<SelectListItem> lstPageSize { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem(){Value="5", Text="5"},
            new SelectListItem(){Value="10", Text="10"},
            new SelectListItem(){Value="20", Text="20"}
        };
        public IEnumerable<SelectListItem> Titles { get; set; }
        public IEnumerable<SelectListItem> Categoires { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BodyFocusParams { get; set; }
        [BindProperty(SupportsGet = true)]

        public string TraningTypeParams { get; set; }
        [BindProperty(SupportsGet = true)]

        public string DifficultyParams { get; set; }
        [BindProperty(SupportsGet = true)]

        public string EquipmentParams { get; set; }
        public IEnumerable<SelectListItem> BodyFocus { get; set; } = Database.GetListOfBodyFocus();
        public IEnumerable<SelectListItem> TraningType { get; set; } = Database.GetListOfTrainingType();
        public IEnumerable<SelectListItem> Difficulty { get; set; } = Database.GetListOfDifficulty();
        public IEnumerable<SelectListItem> Equipment { get; set; } = Database.GetListOfEquipment();
        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value=nameof(Service.Title),Text="العنوان"},
            new SelectListItem(){Value=nameof(Service.Price),Text="السعر"},
            new SelectListItem(){Value=nameof(SportsProgram.Difficulty),Text="الصعوبة"},
            new SelectListItem(){Value=nameof(SportsProgram.Duration),Text="المدة"},
        };
        public List<AppliedFilters>? ListOfSelectedFilters { get; set; }

        public async Task OnGetAsync(string key, string value)
        {

            //  Titles = new SelectList((await _repoProgram.GetAllProgram()).Select(sp => sp.Services.Title).ToList(), nameof(Service.Title), nameof(Service.Title));
            Titles = (await _repoProgram.GetAllProgram()).Select(sp => new SelectListItem() { Text = sp.Services.Title, Value = sp.Services.Title });
            if (_repoProgram != null)
            {
                if (!string.IsNullOrEmpty(BodyFocusParams))
                {
                    SportProgramQueryParamters.BodyFocus = BodyFocusParams.Split(",").ToList();
                }

                if (!string.IsNullOrEmpty(TraningTypeParams))
                {
                    SportProgramQueryParamters.TraningType = TraningTypeParams.Split(",").ToList();
                }
                if (!string.IsNullOrEmpty(DifficultyParams))
                {
                    SportProgramQueryParamters.Difficulty = DifficultyParams.Split(",").Select(i => Convert.ToInt32(i)).ToList();
                }
                if (!string.IsNullOrEmpty(EquipmentParams))
                {
                    SportProgramQueryParamters.Equipment = EquipmentParams.Split(",").ToList();
                }
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                {
                    //SportProgramQueryParamters.GetType().GetProperty(key).SetValue(SportProgramQueryParamters, value);
                    switch (key)
                    {
                        case nameof(SportProgramQueryParamters.BodyFocus):
                            if (SportProgramQueryParamters.BodyFocus is not null && SportProgramQueryParamters.BodyFocus.Contains(value))
                            {
                                SportProgramQueryParamters.BodyFocus.Remove(value);
                            }
                            break;
                        case nameof(SportProgramQueryParamters.TraningType):
                            if (SportProgramQueryParamters.TraningType is not null && SportProgramQueryParamters.TraningType.Contains(value))
                            {
                                SportProgramQueryParamters.TraningType.Remove(value);

                            }
                            break;
                        case nameof(SportProgramQueryParamters.Difficulty):
                            if (SportProgramQueryParamters.Difficulty is not null && SportProgramQueryParamters.Difficulty.Contains(Convert.ToInt32(value)))
                            {
                                SportProgramQueryParamters.Difficulty.Remove(Convert.ToInt32(value));

                            }
                            break;
                        case nameof(SportProgramQueryParamters.Equipment):
                            if (SportProgramQueryParamters.Equipment is not null && SportProgramQueryParamters.Equipment.Contains(value))
                            {
                                SportProgramQueryParamters.Equipment.Remove(value);
                            }
                            break;
                        case nameof(SportProgramQueryParamters.SearchTearm):
                            SportProgramQueryParamters.SearchTearm = "";
                            break;
                        case nameof(SportProgramQueryParamters.Title):
                            SportProgramQueryParamters.Title = "";
                            break;
                        case nameof(SportProgramQueryParamters.MaxDuration):
                            SportProgramQueryParamters.MaxDuration = null; break;

                        case nameof(SportProgramQueryParamters.MinDuration):
                            SportProgramQueryParamters.MinDuration = null;
                            break;
                        case "Duration":
                            SportProgramQueryParamters.MinDuration = null;
                            SportProgramQueryParamters.MaxDuration = null;
                            break;
                    }

                }


                if (_signInManager.IsSignedIn(User))
                {
                    if (User.FindFirstValue(Database.Expert) != null)
                    {
                        var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                        SportProgramQueryParamters.UserId = userid;
                    }


                }
                QueryPageResult = await _repoProgram.SearchSportsProgram(SportProgramQueryParamters);

                ListOfSelectedFilters = QueryPageResult.ListOfSelectedFilters;
            }
        }
        //public async Task OnGetDeleteAsync(string key, string value)
        //{

        //}
    }
}


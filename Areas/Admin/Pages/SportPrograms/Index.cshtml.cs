namespace liaqati_master.Areas.Admin.Pages.Programs
{
    public class IndexProgramModel : PageModel
    {
        private readonly IRepoProgram _repoProgram;

        public IndexProgramModel(IRepoProgram repoProgram)
        {
            _repoProgram = repoProgram;
        }
        public IList<Exercise> Exercises { get; set; }
        [BindProperty(SupportsGet = true)]
        public SportProgramQueryParamters SportProgramQueryParamters { get; set; }
        public QueryPageResult<SportsProgram> QueryPageResult { get; set; }
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
            new SelectListItem(){Value=nameof(Service.Title),Text="العنوان"},
            new SelectListItem(){Value=nameof(Service.Price),Text="السعر"},
            new SelectListItem(){Value=nameof(SportsProgram.Difficulty),Text="الصعوبة"},
            new SelectListItem(){Value=nameof(SportsProgram.Duration),Text="المدة"},
        };

        public async Task OnGetAsync()
        {
            Titles = new SelectList((await _repoProgram.GetAllProgram()).ToList(), nameof(Service.Title), nameof(Service.Title));
            if (_repoProgram != null)
            {
                QueryPageResult = await _repoProgram.SearchSportsProgram(SportProgramQueryParamters);
            }
        }
    }
}

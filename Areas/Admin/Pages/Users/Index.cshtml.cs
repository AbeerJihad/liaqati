namespace liaqati_master.Areas.Administrator.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly IRepoUser _repoUser;

        public IndexModel(UserManager<User> userManager, IRepoUser repoUser)
        {
            _userManager = userManager;
            _repoUser = repoUser;
        }
        [BindProperty(SupportsGet = true)]
        public UserQueryParamters UserQueryParamters { get; set; }
        public QueryPageResult<User> QueryPageResult { get; set; }
        public IEnumerable<SelectListItem> lstPageSize { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem(){Value="5", Text="5"},
            new SelectListItem(){Value="10", Text="10"},
            new SelectListItem(){Value="20", Text="20"}
        };
        public List<(string, string)>? ListOfSelectedFilters { get; set; }

        public IEnumerable<SelectListItem> Names { get; set; }
        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value=nameof(Models.User.Fname),Text="الإسم الأول"},
            new SelectListItem(){Value=nameof(Models.User.Lname),Text="الإسم الأخير"},
            new SelectListItem(){Value=nameof(Models.User.DateOfBirth),Text="تاريخ الميلاد"},
            new SelectListItem(){Value=nameof(Models.User.Exp_Years),Text="سنوات الخبرة"},
            new SelectListItem(){Value=nameof(Models.User.Email),Text="البريد الإلكتروني"} };
        public async Task OnGetAsync()
        {
            Names = new SelectList((await _repoUser.GetAllAsync()), nameof(Models.User.Fname), nameof(Models.User.Fname));
            if (_repoUser is not null)
            {
                QueryPageResult = (await _repoUser.SearchUser(UserQueryParamters));

            }
        }
    }
}

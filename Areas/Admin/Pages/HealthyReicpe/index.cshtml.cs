namespace liaqati_master.Pages.HealthyReicpe
{
    public class IndexHealthyModel : PageModel
    {
        private readonly IRepoHealthyRecipe _repoHealthyRecipe;
        private readonly SignInManager<User> _signInManager;

        public IndexHealthyModel(IRepoHealthyRecipe repoHealthyRecipe, SignInManager<User> signInManager)
        {
            _repoHealthyRecipe = repoHealthyRecipe;
            _signInManager = signInManager;

        }

        public IList<HealthyRecipe>? HealthyRecipes { get; set; }
        [BindProperty(SupportsGet = true)]
        public HealthyRecipeQueryParamters HealthyRecipeQueryParamters { get; set; }
        public QueryPageResult<HealthyRecipe> QueryPageResult { get; set; }
        public bool IsGrid { get; set; }
        public IEnumerable<SelectListItem> lstPageSize { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem(){Value="5", Text="5"},
            new SelectListItem(){Value="10", Text="10"},
            new SelectListItem(){Value="20", Text="20"}
        };
        public List<AppliedFilters>? ListOfSelectedFilters { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MealTypeParams { get; set; }
        [BindProperty(SupportsGet = true)]

        public string DietaryTypeParams { get; set; }
        public IEnumerable<SelectListItem> Titles { get; set; }
        public IEnumerable<SelectListItem> DietaryType { get; set; } = Database.GetListOfDietaryType();
        public IEnumerable<SelectListItem> MealType { get; set; } = Database.GetListOfMealType();
        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value=nameof(HealthyRecipe.Title),Text="العنوان"},
            new SelectListItem(){Value=nameof(HealthyRecipe.Price),Text="السعر"},
            new SelectListItem(){Value=nameof(HealthyRecipe.ViewsNumber),Text="عدد المشاهدات"},
            new SelectListItem(){Value=nameof(HealthyRecipe.CreatedDate),Text="تاريخ النشر"},
            new SelectListItem(){Value=nameof(HealthyRecipe.Calories),Text="عدد السعرات الحرارية"},
        };

        public async Task OnGetAsync()
        {
            if (_repoHealthyRecipe != null)
            {
                if (_signInManager.IsSignedIn(User))
                {
                    if (User.FindFirstValue(Database.Expert) != null)
                    {
                        var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                        HealthyRecipeQueryParamters.UserId = userid;
                    }


                }
                QueryPageResult = await _repoHealthyRecipe.SearchHealty(HealthyRecipeQueryParamters);
                ListOfSelectedFilters = QueryPageResult.ListOfSelectedFilters;
            }
        }
    }
}

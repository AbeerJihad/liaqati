#nullable disable

namespace liaqati_master.Areas.Admin.Pages.MealPlan
{
    public class IndexModel : PageModel
    {
        private readonly IRepoMealPlans _repoMealPlans;
        private readonly IRepoCategory _repoCategory;
        private readonly SignInManager<User> _signInManager;

        public IndexModel(IRepoMealPlans repoMealPlans, IRepoCategory repoCategory, SignInManager<User> signInManager)
        {
            _repoMealPlans = repoMealPlans;
            _repoCategory = repoCategory;
            _signInManager = signInManager;

        }
        [BindProperty(SupportsGet = true)]
        public MealPlansQueryParamters MealPlansQueryParamters { get; set; }
        public QueryPageResult<MealPlanVM> QueryPageResult { get; set; }
        public bool IsGrid { get; set; }
        public IEnumerable<SelectListItem> lstPageSize { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem(){Value="5", Text="5"},
            new SelectListItem(){Value="10", Text="10"},
            new SelectListItem(){Value="20", Text="20"}
        };
        public List<AppliedFilters> ListOfSelectedFilters { get; set; }

        public IEnumerable<SelectListItem> Titles { get; set; }
        public IEnumerable<SelectListItem> Categoires { get; set; }
        public IEnumerable<SelectListItem> DietaryType { get; set; } = Database.GetListOfDietaryType();
        public IEnumerable<SelectListItem> MealType { get; set; } = Database.GetListOfMealType();
        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value=nameof(MealPlans.Services.Title),Text="العنوان"},
            new SelectListItem(){Value=nameof(MealPlans.Services.Price),Text="السعر"},
            new SelectListItem(){Value=nameof(MealPlans.Services.Category.Name),Text="إسم الصنف"},
            new SelectListItem(){Value=nameof(MealPlans.AvgRecipeTime),Text="منوسط وقت الوجبة"},
            new SelectListItem(){Value=nameof(MealPlans.Numsubscribers),Text="عدد المشتركين"},
            new SelectListItem(){Value=nameof(MealPlans.Length),Text="مدة النظام الغذائي"},
        };

        public async Task OnGetAsync()
        {
            Categoires = (await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(MealPlans)]).Select(x => new SelectListItem() { Text = x.Name, Value = x.Id });
            if (!string.IsNullOrEmpty(MealPlansQueryParamters.CategoryId))
            {
                Titles = (await _repoMealPlans.GetAllAsync()).Where(c => c.Services!.CategoryId == MealPlansQueryParamters.CategoryId).Select(x => new SelectListItem() { Text = x.Services!.Title, Value = x.Services.Title });

            }
            else
            {
                Titles = (await _repoMealPlans.GetAllAsync()).Select(x => new SelectListItem() { Text = x.Services!.Title, Value = x.Services.Title });

            }
            if (_repoMealPlans != null)
            {
                if (_signInManager.IsSignedIn(User))
                {
                    if (User.FindFirstValue(Database.Expert) != null)
                    {
                        var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                        MealPlansQueryParamters.UserId = userid;
                    }


                }
                QueryPageResult = await _repoMealPlans.SearchMealPlan(MealPlansQueryParamters);
            }
        }
    }
}

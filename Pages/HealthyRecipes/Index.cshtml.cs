namespace liaqati_master.Pages.HealthyRecipes
{
    [AllowAnonymous]

    public class IndexModel : PageModel
    {
        readonly IRepoHealthyRecipe _repoHealthyRecipe;


        public IndexModel(IRepoHealthyRecipe _repoHealthyRecipe)
        {
            _repoHealthyRecipe = _repoHealthyRecipe;
            DietaryType = Database.GetListOfDietaryType().Select(b => b.Value).ToList();
            MealType = Database.GetListOfMealType().Select(b => b.Value).ToList();
        }


        public List<string> DietaryType { get; set; }
        public List<string> MealType { get; set; }
        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
    new SelectListItem(){Value="MaxRatePercentage",Text="«·√⁄·Ï  ﬁÌÌ„«"},
            new SelectListItem(){Value="MinRatePercentage",Text="«·√ﬁ·  ﬁÌÌ„«"},
        };

        [BindProperty(SupportsGet = true)]
        public MealPlansQueryParamters queryParameters { get; set; }

        public void OnGet()
        {
        }
    }
}

namespace liaqati_master.Pages.MealPlan
{
    [AllowAnonymous]

    public class IndexModel : PageModel
    {

        readonly IRepoMealPlans _repoMealPlans;

        public IndexModel(IRepoMealPlans repoMealPlans)
        {
            _repoMealPlans = repoMealPlans;

            DietaryType = Database.GetListOfDietaryType().Select(b => b.Value).ToList();
            MealType = Database.GetListOfMealType().Select(b => b.Value).ToList();
            MealPlanLength = Database.GetListOfMealPlanLength().Select(b => b.Value).ToList();
        }



        public List<string> DietaryType { get; set; }
        public List<string> MealType { get; set; }
        public List<string> MealPlanLength { get; set; }
        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value="RateId",Text="ÇáÃÚáì ÊŞíãÇğ"},
            new SelectListItem(){Value="exerciseDate",Text="ÇáÃÍÏË"},
        };

        [BindProperty(SupportsGet = true)]
        public MealPlansQueryParamters queryParameters { get; set; }



        public void OnGet()
        {
        }


    }
}

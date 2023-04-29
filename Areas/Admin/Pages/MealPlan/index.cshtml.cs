namespace liaqati_master.Pages.MealPlan
{
    public class indexModel : PageModel
    {
        private readonly IRepoMealPlans _repoMealPlans;

        public indexModel(IRepoMealPlans repoMealPlans)
        {
            _repoMealPlans = repoMealPlans;
        }

        public IList<MealPlans> MealPlans { get; set; }
        public async Task OnGetAsync()
        {
            if (_repoMealPlans != null)
            {

                MealPlans = (await _repoMealPlans.GetAllAsync()).ToList();
            }
        }
    }
}

namespace liaqati_master.Components
{
    public class LastestMealPlansViewComponent : ViewComponent
    {

        private readonly IRepoMealPlans _IRepoMealPlans;
        public LastestMealPlansViewComponent(IRepoMealPlans repoMealPlans)
        {
            _IRepoMealPlans = repoMealPlans;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var MealPlans = (await _IRepoMealPlans.GetAllAsync()).OrderBy(m => m.Id).Take(4).ToList();
            return View(MealPlans);
        }
    }
}

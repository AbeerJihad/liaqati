namespace liaqati_master.Components
{
    public class MealPlansViewComponent : ViewComponent
    {
        private readonly IRepoMealPlans _IRepoMealPlans;
        public MealPlansViewComponent(IRepoMealPlans repoMealPlans)
        {
            _IRepoMealPlans = repoMealPlans;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<MealPlans>? ListOfMealPlans = (await _IRepoMealPlans.GetAllAsync()).Take(3).ToList();
            return View(ListOfMealPlans);
        }

    }
}

namespace liaqati_master.Components
{
    public class HealthyRecipesViewComponent : ViewComponent
    {
        private readonly IRepoHealthyRecipe _IRepoHealthyRecipe;
        public HealthyRecipesViewComponent(IRepoHealthyRecipe repoHealthyRecipe)
        {
            _IRepoHealthyRecipe = repoHealthyRecipe;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var healthyRecipes = (await _IRepoHealthyRecipe.GetAllAsync()).Take(8).ToList();
            return View(healthyRecipes);
        }

    }
}

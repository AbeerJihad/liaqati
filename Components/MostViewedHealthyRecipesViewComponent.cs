using liaqati_master.Services.Repositories;

namespace liaqati_master.Components
{
    public class MostViewedHealthyRecipesViewComponent : ViewComponent
    {
        private readonly IRepoHealthyRecipe _repoHealthyRecipe;
        public MostViewedHealthyRecipesViewComponent(IRepoHealthyRecipe repoHealthyRecipe)
        {

            _repoHealthyRecipe = repoHealthyRecipe;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<HealthyRecipe>? ListOfHealthyRecipe = (await _repoHealthyRecipe.GetAllAsync()).OrderByDescending(h => h.ViewsNumber).Take(4).ToList();
            return View(ListOfHealthyRecipe);
        }

    }
}

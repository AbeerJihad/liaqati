namespace liaqati_master.Components
{
    public class GenericComponentHealthyRecipesViewComponent : ViewComponent
    {
        private readonly IRepoHealthyRecipe _repoHealthyRecipe;
        public GenericComponentHealthyRecipesViewComponent(IRepoHealthyRecipe repoHealthyRecipe)
        {

            _repoHealthyRecipe = repoHealthyRecipe;
        }


        public async Task<IViewComponentResult> InvokeAsync(int flag)
        {
            List<HealthyRecipe>? ListOfHealthyRecipe = new();
            if (flag == 0)
            {
                ViewData["ComponentTitle"] = "أحدث الوصفات";
                ListOfHealthyRecipe = (await _repoHealthyRecipe.GetAllAsync()).OrderByDescending(article => article.CreatedDate).Take(4).ToList();
            }
            else if (flag == 1)
            {
                ViewData["ComponentTitle"] = "الأكثر تقيماً";
                ListOfHealthyRecipe = (await _repoHealthyRecipe.GetAllAsync()).OrderByDescending(article => article.RatePercentage).Take(4).ToList();
            }
            else if (flag == 2)
            {
                ViewData["ComponentTitle"] = "مميزة";
                ListOfHealthyRecipe = (await _repoHealthyRecipe.GetAllAsync()).Where(article => article.IsFeatured ?? false).Take(4).ToList();
            }
            return View(ListOfHealthyRecipe);
        }

    }
}

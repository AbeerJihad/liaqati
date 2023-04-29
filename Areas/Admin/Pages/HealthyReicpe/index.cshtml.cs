namespace liaqati_master.Pages.HealthyReicpe
{
    public class IndexHealthyModel : PageModel
    {
        private readonly IRepoHealthyRecipe _repoHealthyRecipe;

        public IndexHealthyModel(IRepoHealthyRecipe repoHealthyRecipe)
        {
            _repoHealthyRecipe = repoHealthyRecipe;
        }

        public IList<HealthyRecipe>? HealthyRecipes { get; set; }
        public async Task OnGetAsync()
        {
            if (_repoHealthyRecipe != null)
            {
                HealthyRecipes = (await _repoHealthyRecipe.GetAllAsync()).ToList();
            }
        }
    }
}

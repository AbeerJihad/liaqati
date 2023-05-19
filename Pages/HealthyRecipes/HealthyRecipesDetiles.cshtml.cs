#nullable disable
namespace liaqati_master.Pages.HealthyRecipes
{
    public class HealthyRecipesDetilesModel : PageModel
    {
        private readonly IRepoHealthyRecipe _repoHealthy;
        private readonly IRepoFiles _repoFiles;


        public HealthyRecipe HealthyRecipe { get; set; }

        public HealthyRecipesDetilesModel(IRepoHealthyRecipe repoHealthy, IRepoFiles repoFiles)
        {
            _repoHealthy = repoHealthy;
            _repoFiles = repoFiles;
        }

        public string Message { get; set; }
        public List<Files> Files { get; set; }

        public string[] Ingredent { get; set; }
        public string[] PreparationMethod { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id != null)
            {
                HealthyRecipe = await _repoHealthy.GetByIDAsync(id);
                if (HealthyRecipe is null)
                {
                    return NotFound();
                }
                if (HealthyRecipe.Ingredients is not null)
                {
                    Ingredent = HealthyRecipe.Ingredients.Split('\n');
                }
                if (HealthyRecipe.PreparationMethod is not null)
                {
                    PreparationMethod = HealthyRecipe.PreparationMethod.Split(',');
                }
                //   string [] Ingredent = HealthyRecipe..Split(',');

                Files = (await _repoFiles.GetByHealthyRecipesIDAsync(id));
                if (HealthyRecipe == null)
                {
                    Message = "NotFound";
                }

            }
            return Page();


        }

    }
}

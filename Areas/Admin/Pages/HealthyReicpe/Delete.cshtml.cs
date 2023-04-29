namespace liaqati_master.Pages.HealthyReicpe
{
    public class DeleteHealthyModel : PageModel
    {
        private readonly IRepoHealthyRecipe _repoHealthyRecipe;

        public DeleteHealthyModel(IRepoHealthyRecipe repoHealthyRecipe)
        {
            _repoHealthyRecipe = repoHealthyRecipe;
        }

        [BindProperty]
        public HealthyRecipe HealthyRecipe { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var healthyRecipe = await _repoHealthyRecipe.GetByIDAsync(id);

            if (healthyRecipe == null)
            {
                return NotFound();
            }
            else
            {
                HealthyRecipe = healthyRecipe;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthyRecipe = await _repoHealthyRecipe.GetByIDAsync(id);

            if (healthyRecipe != null)
            {
                HealthyRecipe = healthyRecipe;

                await _repoHealthyRecipe.DeleteEntityAsync(healthyRecipe);


            }

            return RedirectToPage("./Index");
        }
    }
}

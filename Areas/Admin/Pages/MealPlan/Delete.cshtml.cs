namespace liaqati_master.Pages.MealPlan
{
    public class DeleteModel : PageModel
    {
        private readonly IRepoMealPlans _repoMealPlans;

        public DeleteModel(IRepoMealPlans repoMealPlans)
        {
            _repoMealPlans = repoMealPlans;
        }

        [BindProperty]
        public MealPlans MealPlans { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null || _repoMealPlans == null)
            {
                return NotFound();
            }

            var meal = await _repoMealPlans.GetByIDAsync(id);

            if (meal == null)
            {
                return NotFound();
            }
            else
            {
                MealPlans = meal;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == null || _repoMealPlans == null)
            {
                return NotFound();
            }

            var meal = await _repoMealPlans.GetByIDAsync(id);

            if (meal != null)
            {
                MealPlans = meal;

                await _repoMealPlans.DeleteEntityAsync(MealPlans);


            }

            return RedirectToPage("./Index");
        }
    }
}

namespace liaqati_master.Pages.HealthyReicpe
{
    public class EditHealthyModel : PageModel
    {

        private readonly IRepoHealthyRecipe _repoHealthyRecipe;

        public EditHealthyModel(IRepoHealthyRecipe repoHealthyRecipe)
        {
            _repoHealthyRecipe = repoHealthyRecipe;
        }
        public List<SelectListItem> CatogeryName { get; set; }


        [BindProperty(SupportsGet = true)]
        public HealthyRecipe HealthyRecipes { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthyRecipes = await _repoHealthyRecipe.GetByIDAsync(id);
            if (healthyRecipes == null)
            {
                return NotFound();
            }
            HealthyRecipes = healthyRecipes;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPost()
        {

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            var id = HealthyRecipes.Id;
            var item = await _repoHealthyRecipe.GetByIDAsync(id);
            item!.Title = HealthyRecipes.Title;
            item.Price = HealthyRecipes.Price;
            item.Description = HealthyRecipes.Description;
            item.DietaryType = HealthyRecipes.DietaryType;
            item.MealType = HealthyRecipes.MealType;
            item.PrepTime = HealthyRecipes.PrepTime;
            item.Calories = HealthyRecipes.Calories;
            item.Total_Carbohydrate = HealthyRecipes.Total_Carbohydrate;
            item.Protein = HealthyRecipes.Protein;
            item.PreparationMethod = HealthyRecipes.PreparationMethod;
            item.Ingredients = HealthyRecipes.Ingredients;

            //var cid = HealthyRecipes.Category!.Id;
            //if (id != null)
            //{
            //    HealthyRecipes.CategoryId = id;

            //}
            await _repoHealthyRecipe.UpdateEntityAsync(item);
            //  _context.Attach(MealPlans).State = EntityState.Modified;


            return RedirectToPage("./Index");
        }


    }
}

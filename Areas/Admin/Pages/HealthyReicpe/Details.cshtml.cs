namespace liaqati_master.Areas.Admin.Pages.HealthyReicpe
{
    public class DetailsModel : PageModel
    {
        private readonly IRepoHealthyRecipe _repoHealthyRecipe;

        public DetailsModel(IRepoHealthyRecipe repoHealthyRecipe)
        {
            _repoHealthyRecipe = repoHealthyRecipe;
        }

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public string[]? PreparationMethod { get; set; }
        public HealthyRecipe? HealthyRecipe { get; set; }
        public async Task OnGet(string? id)
        {
            if (id != null)
            {
                HealthyRecipe = await _repoHealthyRecipe.GetByIDAsync(id);
                PreparationMethod = HealthyRecipe?.PreparationMethod?.Split(',');
                string[]? IngredientsAsStrings = HealthyRecipe?.Ingredients?.Trim().Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < IngredientsAsStrings?.Length; i++)
                {
                    string[] IngredientItem = IngredientsAsStrings[i].Split(',');
                    Ingredients.Add(new Ingredient() { Name = IngredientItem[0], Quantity = int.Parse(IngredientItem[1]), Unit = IngredientItem[2] });
                }

            }


        }

        public class Ingredient
        {
            public string? Name { get; set; }
            public int Quantity { get; set; }
            public string? Unit { get; set; }


        }
    }
}

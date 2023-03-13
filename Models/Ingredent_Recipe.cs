namespace liaqati_master.Models
{
    public class Ingredent_Recipe
    {
        public int Id { get; set; }
        public int? IngredentId { get; set; }

        public Ingredent? Ingredent { get; set; }
        public int? HealthyRecipesId { get; set; }

        public HealthyRecipes? HealthyRecipes { get; set; }
    }
}

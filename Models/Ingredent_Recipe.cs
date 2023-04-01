namespace liaqati_master.Models
{
    public class Ingredent_Recipe : BaseEntity
    {

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المكونات")]
        public int? IngredentId { get; set; }

        public Ingredent? Ingredent { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الوصفة")]
        public string? HealthyRecipesId { get; set; }

        public HealthyRecipe? HealthyRecipes { get; set; }
    }
}

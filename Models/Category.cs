namespace liaqati_master.Models
{
    public class Category : BaseEntity
    {

        [Display(Name = "اسم الصنف"), StringLength(50, MinimumLength = 2, ErrorMessage = "هذا الحقل مطلوب")]
        public string? Name { get; set; }
        [Display(Name = "تابع إلى")]
        public string Target { get; set; }
        [Display(Name = "صورة")]
        public string? Image { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<Service>? Services { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<Article>? Articles { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<HealthyRecipe>? HealthyRecipes { get; set; }
    }
}

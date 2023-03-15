using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace liaqati_master.Models
{
    public class Ingredent_Recipe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string Id { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المكونات")]
        public int? IngredentId { get; set; }

        public Ingredent? Ingredent { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الوصفة")]
        public string? HealthyRecipesId { get; set; }

        public HealthyRecipes? HealthyRecipes { get; set; }
    }
}

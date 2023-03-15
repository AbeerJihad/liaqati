using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class HealthyRecipes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم الوجبة")]
        public string Id { get; set; }

        // [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string? Image { get; set; } = "";
        [Display(Name = "نوع الوجبة")]
        public MealTypeTypeStatus MealType { get; set; }

        [Display(Name = "النوع الغذائي")]
        public DieteryTypeStatus DieteryType { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "وقت التحضير")]
        [DataType(DataType.DateTime)]
        public DateTime prepTime { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "السعرات الحرارية")]
        public int Calories { get; set; }
        [Display(Name = "مجموع السعرات الحرارية")]
        public int Total_Carbohydrate { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "كمية البروتين")]
        public int Protein { get; set; }
      
        public Service? services { get; set; }

    }
    public enum DieteryTypeStatus { Omnivore, Vegetarian }
    public enum MealTypeTypeStatus { SideDish, Breakfast, Lunch, Dinner, Snack }
}


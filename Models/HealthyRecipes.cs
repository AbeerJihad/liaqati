using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class HealthyRecipes
    {
        public int Id { get; set; }
        public string Image { get; set; }
        //[Display(Name = "نوع الوجبة")]

        [Display(Name = "Meal Type")]
        public MealTypeTypeStatus MealType { get; set; }

        [Display(Name = "Dietery Type")]
        public DieteryTypeStatus DieteryType { get; set; }


        [DataType(DataType.DateTime), Required]
        public DateTime prepTime { get; set; }


        public int Calories { get; set; }
        [Display(Name = "Total Carbohy drates")]
        public int Total_Carbohydrate { get; set; }
        public int Protein { get; set; }

        public int? servicesId { get; set; }

        public Service? services { get; set; }

    }
    public enum DieteryTypeStatus { Omnivore, Vegetarian }
    public enum MealTypeTypeStatus { SideDish, Breakfast, Lunch, Dinner, Snack }
}


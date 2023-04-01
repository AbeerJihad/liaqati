namespace liaqati_master.Models
{
    public class HealthyRecipe : BaseEntity
    {
        // [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string? Image { get; set; } = "";
        [Display(Name = "نوع الوجبة")]
        public MealTypeTypeStatus MealType { get; set; }

        [Display(Name = "النوع الغذائي")]
        public DieteryTypeStatus DieteryType { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "وقت التحضير")]
        public int PrepTime { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "السعرات الحرارية")]
        public int Calories { get; set; }
        [Display(Name = "مجموع الكاربوهيدرات")]
        public int Total_Carbohydrate { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "كمية البروتين")]
        public int Protein { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "المكونات")]
        public string? Ingredients { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "طريقة التحضير؟")]
        public string? PreparationMethod { get; set; }

        [ForeignKey(nameof(Id))]
        public virtual Service? Services { get; set; }

    }
    public enum DieteryTypeStatus { Omnivore, Vegetarian }
    public enum MealTypeTypeStatus { SideDish, Breakfast, Lunch, Dinner, Snack }
}


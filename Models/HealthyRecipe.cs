namespace liaqati_master.Models
{
    public class HealthyRecipe : BaseEntity
    {
        // [Required(ErrorMessage = "هذا الحقل مطلوب")]

        //  [Required(ErrorMessage = "{0} هذا الحقل مطلوب"), Display(Name = "عنوان الخدمة")]
        public string? Title { get; set; }
        //    [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "وصف الخدمة"), Column(TypeName = "NTEXT")]
        public string? Description { get; set; }
        [Display(Name = "وصف قصير")]
        public string? ShortDescription { get; set; }
        //   [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = " سعر الخدمة")]
        public double? Price { get; set; }
        //[Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        //[Display(Name = "رقم الصنف")]
        //public string? CategoryId { get; set; }
        //[ForeignKey(nameof(CategoryId))]
        //public virtual Category? Category { get; set; }
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
        //  [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "المكونات")]
        public string? Ingredients { get; set; }
        // [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "طريقة التحضير؟")]
        public string? PreparationMethod { get; set; }
        public virtual List<Meal_Healthy>? Meal_Healthy { get; set; }


    }
    public enum DieteryTypeStatus { Omnivore, Vegetarian }
    public enum MealTypeTypeStatus { SideDish, Breakfast, Lunch, Dinner, Snack }
}


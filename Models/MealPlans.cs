namespace liaqati_master.Models
{
    public class MealPlans : BaseEntity
    {

        [Display(Name = "عدد المشتركيين")]
        public int? Numsubscribers { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "المدة")]
        public int? Length { get; set; }

        public string? DietaryType { get; set; }
        //[Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "نوع الوجبة")]
        public string? MealType { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "منوسط وقت الوجبة")]
        public double? AvgRecipeTime { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "صورة الوجبة")]
        public string? Image { get; set; }
        [Display(Name = "تقدير الحرق")]
        public string? BurnEstimate { get; set; }
        [ForeignKey(nameof(Id))]
        public virtual Service? Services { get; set; }
        public virtual List<Meal_Healthy>? Meal_Healthy { get; set; }

        public MealPlans()
        {
            Numsubscribers = 0;
            Length = 0;
            DietaryType = string.Empty;
            MealType = string.Empty;
            AvgRecipeTime = 0;
            Image = string.Empty;
        }

    }
}

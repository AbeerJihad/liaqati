namespace liaqati_master.Models
{
    public class Meal_Healthy
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None), Key, HiddenInput]
        public string? Id { get; set; }


        [Required(ErrorMessage = "هذا الحقل مطلوب"), Display(Name = " رقم  النظام الغذائي")]
        public string? MealPlansId { get; set; }

        [ForeignKey(nameof(MealPlansId))]
        public virtual MealPlans? MealPlan { get; set; }




        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم  الوجبة الغذائية")]
        public string? HealthyRecdpeId { get; set; }

        [ForeignKey(nameof(HealthyRecdpeId))]
        public virtual HealthyRecipe? HealthyRecipe { get; set; }


        [Required(ErrorMessage = "هذا الحقل مطلوب"), Display(Name = "رقم اليوم")]
        public int Day { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب"), Display(Name = "رقم الأسبوع")]
        public int Week { get; set; }



    }
}

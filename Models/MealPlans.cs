﻿namespace liaqati_master.Models
{
    public class MealPlans
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم النطام الغذائي")]
        [HiddenInput]
        public string? Id { get; set; }
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



        [ForeignKey(nameof(Id))]
        public Service? Services { get; set; }

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

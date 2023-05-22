namespace liaqati_master.ViewModels
{
    public class VmHealthyRecipe
    {
        public string? Id { get; set; }

        //[Required, Display(Name = "عنوان الخدمة"), StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءاًأدخل حرفين على الاقل")]

        public string? ShortDescription { get; set; }
        public string? Title { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "وصف الخدمة")]
        public string? Description { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = " سعر الخدمة")]
        public double? Price { get; set; }


        [Display(Name = "نوع الوجبة")]
        public string MealType { get; set; }

        [Display(Name = "النوع الغذائي")]
        public string DietaryType { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "وقت التحضير")]

        public int PrepTime { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "السعرات الحرارية")]
        public int Calories { get; set; }
        [Display(Name = "مجموع السعرات الحرارية")]
        public int Total_Carbohydrate { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "كمية البروتين")]
        public int Protein { get; set; }
        public int ViewsNumber { get; set; }

        public virtual List<Rate>? Rate { get; set; }
        [Display(Name = " التقييم"), Range(0, 100)]
        public double? RatePercentage { get; set; }


        public int? IsFavorite { get; set; }

        public string? Image { get; set; } = "";
        public string? ExpertName { get; set; }
        public string? UserId { get; set; }




        public DateTime? CreatedDate { get; set; } = DateTime.Now;





    }
}

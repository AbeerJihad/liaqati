namespace liaqati_master.Models
{
    public class Favorite : BaseEntity
    {


        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الخدمة")]
        public string? ServicesId { get; set; }
        [ForeignKey(nameof(ServicesId))]
        public virtual Service? Services { get; set; }



        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الوصفة")]
        public string? HealthyRecipeId { get; set; }
        [ForeignKey(nameof(HealthyRecipeId))]
        public virtual HealthyRecipe? HealthyRecipe { get; set; }



        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم التمرين")]
        public string? ExerciseId { get; set; }
        [ForeignKey(nameof(ExerciseId))]
        public virtual Exercise? Exercise { get; set; }



        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المقالة")]
        public string? ArticleId { get; set; }
        [ForeignKey(nameof(ArticleId))]
        public virtual Article? Article { get; set; }





        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم  المستخدم")]
        public string? UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User? User { get; set; }


        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "النوع المفضل")]
        public string? Type { get; set; }
    }
}

namespace liaqati_master.Models
{
    public class Rate : BaseEntity
    {
        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "التقييم على")]
        public string type { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "التقييم")]
        [Range(1, 5)]
        public int Review { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "تاريخ التقييم")]
        [DataType(DataType.DateTime)]
        public DateTime review_date { get; set; }


        public string? Order_DetailsId { get; set; }
        public virtual Order_Details? Order_Details { get; set; }

        public string? ExerciseId { get; set; }
        public virtual Exercise? Exercise { get; set; }
        public string? HealthyRecipeId { get; set; }
        public virtual HealthyRecipe? HealthyRecipe { get; set; }
        public virtual SportsProgram? SportsProgram { get; set; }
    }
}

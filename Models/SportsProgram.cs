namespace liaqati_master.Models
{
    public class SportsProgram : BaseEntity
    {

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "المدة")]
        public int Length { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "مستوى الصعوبة")]
        public string? Difficulty { get; set; }

        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "الجزءالذي يركز عليه النظام من الجسم")]
        public string? BodyFocus { get; set; }
        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "المعدات")]
        public string? Equipment { get; set; }
        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "نوع التدريب")]
        public string? TrainingType { get; set; }
        [ForeignKey(nameof(Id))]
        public virtual Service? Services { get; set; }
        public virtual List<Exercies_program>? Exercies_Programs { get; set; }

    }
}

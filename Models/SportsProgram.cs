namespace liaqati_master.Models
{
    public class SportsProgram : BaseEntity
    {

        [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "المدة")]
        public int Length { get; set; }
        [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "مستوى الصعوبة")]
        public int? Difficulty { get; set; }
        [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "مستوى الصعوبة")]
        public int Duration { get; set; }
        [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "الجزءالذي يركز عليه النظام من الجسم")]
        public string? BodyFocus { get; set; }
        [Required]
        [Display(Name = "المعدات")]
        public string? Equipment { get; set; }
        [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "نوع التدريب")]
        public string? TrainingType { get; set; }
        [Display(Name = "صورة")]
        public string? Image { get; set; }

        [Display(Name = " التقييم")]
        public double? RatePercentage { get; set; }
        public virtual List<Rate>? Rate { get; set; }

        [ForeignKey(nameof(Id))]
        public virtual Service? Services { get; set; }
        public virtual List<Exercies_program>? Exercies_Programs { get; set; }

    }
}

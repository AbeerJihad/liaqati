namespace liaqati_master.Models
{
    public class Exercies_program : BaseEntity
    {


        [Required(ErrorMessage = "هذا الحقل مطلوب"), Display(Name = "رقم النمرين")]
        public string? ExerciseId { get; set; }

        [ForeignKey(nameof(ExerciseId))]
        public virtual Exercise? Exercise { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم النظام الرياضي")]
        public string? SportsProgramId { get; set; }


        [Required(ErrorMessage = "هذا الحقل مطلوب"), Display(Name = "رقم اليوم")]
        public int Day { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب"), Display(Name = "رقم الأسبوع")]
        public int Week { get; set; }

        [ForeignKey(nameof(SportsProgramId))]
        public virtual SportsProgram? SportsProgram { get; set; }

    }
}

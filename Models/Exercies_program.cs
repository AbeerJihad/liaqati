namespace liaqati_master.Models
{
    public class Exercies_program
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None), Key, HiddenInput]
        public string? Id { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب"), Display(Name = "رقم النمرين")]
        public string? ExerciseId { get; set; }

        [ForeignKey(nameof(ExerciseId))]
        public Exercise? Exercise { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم النظام الرياضي")]
        public string? SportsProgramId { get; set; }

        [ForeignKey(nameof(SportsProgramId))]
        public SportsProgram? SportsProgram { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب"), Display(Name = "رقم اليوم")]
        public int Day { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب"), Display(Name = "رقم الأسبوع")]
        public int Week { get; set; }

    }
}

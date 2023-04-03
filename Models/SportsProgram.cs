namespace liaqati_master.Models
{
    public class SportsProgram
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None), Key, HiddenInput]
        public string? Id { get; set; }



        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "المدة")]
        public int Length { get; set; }


        public int Duration { get; set; }
        

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "مستوى الصعوبة")]
        public int? Difficulty { get; set; }

      //  [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "الجزءالذي يركز عليه النظام من الجسم")]
        public string? BodyFocus { get; set; }
     //   [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "المعدات")]
        public string? Equipment { get; set; }
      //  [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "نوع التدريب")]
        public string? TrainingType { get; set; }
        [ForeignKey(nameof(Id))]
        public Service? Services { get; set; }
        public List<Exercies_program>? Exercies_Programs { get; set; }

        [DataType(DataType.Date)]

        public DateTime? StartDate { get; set; } 


        [Display(Name = "صورة")]
        public string? Image { get; set; }
        [NotMapped]
        public IFormFile FormFile { get; set; }

    }
}

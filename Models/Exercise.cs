namespace liaqati_master.Models
{
    public class Exercise : BaseEntity
    {


        [Required(ErrorMessage = "requird{0}"), StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل"), Display(Name = "اسم التمرين")]
        public string? Title { get; set; }
        [StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل"), Display(Name = "تركيز الجسم")]
        public string? BodyFocus { get; set; }
        [Display(Name = "وصف مختصر لا يزيد عن سطر")]
        public string? ShortDescription { get; set; }
        [Display(Name = "مدة التمرين")]
        public int? Duration { get; set; }
        [Range(1, 5)]
        public int? Difficulty { get; set; }
        [Display(Name = "وصف التمارين")]
        public string? Detail { get; set; }
        [Display(Name = "نوع التمرين")]
        public string? TraningType { get; set; }
        [Display(Name = "المعدات")]
        public string? Equipments { get; set; }
        [Display(Name = "صورة")]
        public string? Image { get; set; }
        [Display(Name = "فيديو")]
        public string? Video { get; set; }
        [Display(Name = " سعر التمرين")]
        public double? Price { get; set; }
        [Display(Name = "تقدير الحرق")]
        public string? BurnEstimate { get; set; }
        public virtual List<Exercies_program>? Exercies_Programs { get; set; }

    }
}

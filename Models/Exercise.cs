using System.Text.Json.Serialization;

namespace liaqati_master.Models
{
    public class Exercise : BaseEntity
    {
        [Required(ErrorMessage = "requird{0}"), StringLength(500, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل"), Display(Name = "اسم التمرين")]
        public string? Title { get; set; }
        [StringLength(300, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل"), Display(Name = "تركيز الجسم")]
        public string? BodyFocus { get; set; }
        [Display(Name = "وصف مختصر لا يزيد عن سطر")]
        public string? ShortDescription { get; set; }
        [Display(Name = "مدة التمرين")]
        public int? Duration { get; set; }
        [Range(1, 5)]
        public int? Difficulty { get; set; }
        [Display(Name = "وصف التمارين"), Column(TypeName = "NTEXT")]
        public string? Detail { get; set; }
        [Display(Name = "نوع التمرين")]
        public string? TraningType { get; set; }
        [StringLength(500)]
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
        public string? UserId { get; set; }


        [ForeignKey(nameof(UserId))]
        public virtual User? User { get; set; }

        [Display(Name = " التقييم")]
        public double? RatePercentage { get; set; }
        public virtual List<Rate>? Rate { get; set; }
        [JsonIgnore]
        public virtual List<Exercies_program>? Exercies_Programs { get; set; }
        public virtual List<Favorite>? Favorite { get; set; }

    }
}

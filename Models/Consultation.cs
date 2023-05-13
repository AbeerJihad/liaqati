namespace liaqati_master.Models
{
    public class Consultation : BaseEntity
    {
        [Required(ErrorMessage = " حقل مطلوب"), Display(Name = "عنوان الاستشارة")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "  حقل مطلوب")]
        [Display(Name = " وصف الاستشارة")]
        public string? Description { get; set; }
        
       
        [Display(Name = "تاريخ النشر")]
        [DataType(DataType.DateTime)]
        public DateTime PostDate { get; set; } = DateTime.Now;
        [Display(Name = "عدد المشاهدات")]
        public int ViewsNumber { get; set; } = 0;

        [Required(ErrorMessage = " {0} حقل مطلوب")]
        [Display(Name = "رقم الصنف")]
        public string? CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category? Category { get; set; }


        [Display(Name = " رقم المستشير")]
        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User? User { get; set; }

       public virtual List<Replyconsultation>? Replyconsultations { get; set; }

    }
}

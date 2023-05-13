namespace liaqati_master.Models
{
    public class Replyconsultation : BaseEntity
    {
        

        [Required(ErrorMessage = "  حقل مطلوب")]
        [Display(Name = "الرد على الاستشارة ")]
        public string? Reply { get; set; }


        [Display(Name = " رقم الخبير")]
        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User? User { get; set; }


        [Display(Name = " رقم الاستشارة")]
        public string? consId { get; set; }

        [ForeignKey(nameof(consId))]
        public virtual Consultation? Consultations { get; set; }


    }
}

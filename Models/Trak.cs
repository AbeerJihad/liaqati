namespace liaqati_master.Models
{
    public class Trak : BaseEntity
    {
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رفم الخدمة")]
        public string? ServicesId { get; set; }

        public virtual Service? Services { get; set; }
    }
}

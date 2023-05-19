namespace liaqati_master.Models
{
    public class ContactUs : BaseEntity
    {
        [Required, Display(Name = "الإسم الكامل")]
        public string? FullName { get; set; }
        [Required, Display(Name = "الإسم الكامل")]

        public string? Email { get; set; }
        [Required]

        public string? PhoneIntro { get; set; }
        [Required, Display(Name = "الإسم الكامل")]

        public string? Phone { get; set; }
        [Required, Display(Name = "الملاحظات"), StringLength(500, MinimumLength = 10, ErrorMessage = " رجاءً ادخل ملاحظاتك")]

        public string? MessageContent { get; set; }

    }
}

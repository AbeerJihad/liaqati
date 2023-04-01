namespace liaqati_master.Models
{
    public class Message : BaseEntity
    {


        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "تاريخ الرسالة")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "محتوى الرسالة")]
        public string Text { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المرسل")]
        public int SenderId { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الحادثة")]
        public string? ChatId { get; set; }
        public virtual Chat? Chat { get; set; }

    }
}


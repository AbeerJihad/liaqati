namespace liaqati_master.Models
{
    public class Comment_Servies : BaseEntity
    {

        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "التعليق")]
        public string Comment { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "تاريخ التعليق")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "النعليق على")]
        public string commentFor { get; set; }
        [Display(Name = "الرد على"), StringLength(50, MinimumLength = 2, ErrorMessage = "الحد الاقصى 50 حرف")]
        public string repliedFor { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الخدمة")]
        public string? ServicesId { get; set; }

        public virtual Service? Services { get; set; }


    }
}

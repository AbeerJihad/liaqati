namespace liaqati_master.Models
{
    public class Comments
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم التعليق")]
        public string Id { get; set; }
        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "التعليق")]
        public string Comment { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "التاريخ")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "التعليق على")]
        public string commentFor { get; set; }
        [Display(Name = "الرد على"), StringLength(50, MinimumLength = 2, ErrorMessage = "الحد الاقصى 50 حرف")]
        public string repliedFor { get; set; }
        [Display(Name = "رقم المقالة")]
        public string? articlesId { get; set; }
        public Article? articles { get; set; }
    }
}

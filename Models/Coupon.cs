namespace liaqati_master.Models
{
    public class Coupon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم الكوبون")]

        public string Id { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الخصم")]
        public double Discount { get; set; }

        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "كود الكوبون")]
        public string Code { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "تاريخ البدء ")]
        [DataType(DataType.DateTime)]
        public DateTime FromDate { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "تاريح الانتهاء")]
        [DataType(DataType.DateTime)]
        public DateTime ToDate { get; set; }


    }
}


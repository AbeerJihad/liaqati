using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class Coupon_redemption
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الخصم")]
        public double Total_discount { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "تاريخ الاسترداد")]

        [DataType(DataType.DateTime)]
        public DateTime redemption_date { get; set; }

        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "كود الكوبون")]
        public string Code { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رفم تفاصيل الطلبية")]
        public string Order_DetailsId { get; set; }
        public Order_Details? Order_Details { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الكوبون")]
        public string CouponId { get; set; }
        public Coupon? Coupon { get; set; }
        

    }
}

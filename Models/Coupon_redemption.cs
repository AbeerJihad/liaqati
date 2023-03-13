using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class Coupon_redemption
    {

        public int Id { get; set; }
        public double Total_discount { get; set; }



        [DataType(DataType.DateTime), Required]
        public DateTime redemption_date { get; set; }


        public string Code { get; set; }

        public int Order_DetailsId { get; set; }
        public Order_Details? Order_Details { get; set; }


        public int CouponId { get; set; }
        public Coupon? Coupon { get; set; }


    }
}

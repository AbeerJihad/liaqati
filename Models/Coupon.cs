using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class Coupon
    {

        public int Id { get; set; }


        public double Discount { get; set; }


        public string Code { get; set; }


        [DataType(DataType.DateTime), Required]
        public DateTime FromDate { get; set; }


        [DataType(DataType.DateTime), Required]
        public DateTime ToDate { get; set; }


    }
}


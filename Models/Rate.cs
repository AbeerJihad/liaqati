using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class Rate
    {
        public int Id { get; set; }


        public string type { get; set; }

        public int review { get; set; }


        [DataType(DataType.DateTime), Required]
        public DateTime review_date { get; set; }


        public int? Order_DetailsId { get; set; }
        public Order_Details? Order_Details { get; set; }

    }
}

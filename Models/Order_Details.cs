namespace liaqati_master.Models
{
    public class Order_Details
    {

        public int Id { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public int OrderId { get; set; }
        public Order? Order { get; set; }

        public int? RateId { get; set; }
        public Rate? Rate { get; set; }

    }
}

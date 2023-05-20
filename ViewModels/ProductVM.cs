namespace liaqati_master.ViewModels
{
    public class ProductVM
    {

        public List<string?>? Images { get; set; }
        public string? Title { get; set; }
        public double? Price { get; set; }
        public string? Id { get; set; }
        public string? UserId { get; set; }

        public string? Description { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryId { get; set; }
        public double? PercentageRate { get; set; }
        public double Discount { get; set; }

        public int IsFavorite { get; set; }


    }
}

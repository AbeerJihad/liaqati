namespace liaqati_master.ViewModels
{
    public class OrdersDetailsQueryParamters : QueryParameters
    {

        [DataType(DataType.Date)]
        public DateTime? FromDateOrder { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ToDateOrder { get; set; }
        public string? UserId { get; set; }

    }
}

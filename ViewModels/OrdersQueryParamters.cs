namespace liaqati_master.ViewModels
{
    public class OrdersQueryParamters : QueryParameters
    {

        [DataType(DataType.Date)]
        public DateTime? FromDateOrder { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ToDateOrder { get; set; }

    }
}

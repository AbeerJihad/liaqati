namespace liaqati_master.ViewModels
{
    public class ConsultationQueryParamters : QueryParameters
    {
        public string Tilte { get; set; } = string.Empty;
        public string? CategoryId { get; set; }
        public string? SearchTearm { get; set; } = string.Empty;
        public string? Type { get; set; } = string.Empty;
    }
}

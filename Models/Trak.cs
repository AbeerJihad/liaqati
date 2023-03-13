namespace liaqati_master.Models
{
    public class Trak
    {
        public int Id { get; set; }
        public int? servicesId { get; set; }

        public Service? services { get; set; }
    }
}

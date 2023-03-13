namespace liaqati_master.Models
{
    public class Favorite_Servies
    {
        public int Id { get; set; }
        public int? servicesId { get; set; }

        public Service? services { get; set; }

        public int? favoriteId { get; set; }

        public Favorite? favorite { get; set; }
    }
}

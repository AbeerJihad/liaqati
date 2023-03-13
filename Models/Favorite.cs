namespace liaqati_master.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<Favorite_Servies>? Favorite_Servies { get; set; }
    }
}

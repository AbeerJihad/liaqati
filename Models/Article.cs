using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        [DataType(DataType.Date), Required]
        public DateTime PostDate { get; set; }

        public int ViewsNumber { get; set; }
        public int likesNumber { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }


        public List<Comments>? comments { get; set; }
    }
}

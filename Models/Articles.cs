using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class Articles
    {
        public int Id { get; set; }
        public string? Description { get; set; }

        [DataType(DataType.DateTime), Required]
        public DateTime PostDate { get; set; }

        public int ViewsNumber { get; set; }
        public int likesNumber { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }


        public List<Comments>? comments { get; set; }
    }
}

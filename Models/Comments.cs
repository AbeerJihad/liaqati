using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        [DataType(DataType.DateTime), Required]
        public DateTime Date { get; set; }

        public string commentFor { get; set; }
        public string repliedFor { get; set; }

        public int? articlesId { get; set; }
        public Article? articles { get; set; }
    }
}

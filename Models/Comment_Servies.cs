using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class Comment_Servies
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        [DataType(DataType.DateTime), Required]
        public DateTime Date { get; set; }

        public string commentFor { get; set; }
        public string repliedFor { get; set; }
        public int? servicesId { get; set; }

        public Service? services { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class Message
    {

        public int Id { get; set; }


        [DataType(DataType.DateTime), Required]
        public DateTime Date { get; set; }


        public string Text { get; set; }


        public int SenderId { get; set; }

        public int ChatId { get; set; }
        public Chat? Chat { get; set; }

    }
}


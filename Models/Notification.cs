using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class Notification
    {

        public int Id { get; set; }


        [Required, Display(Name = "Title"), StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter at least two characters")]
        public string Title { get; set; }


        [DataType(DataType.DateTime), Required]
        public DateTime DATE { get; set; }


        [DataType(DataType.DateTime), Required]
        public DateTime Time { get; set; }


        public string Text { get; set; }

        //ForignKsy User Model
        public int UserId { get; set; }
        public User? User { get; set; }

    }
}

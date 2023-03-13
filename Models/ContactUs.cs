#nullable disable
using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class ContactUs
    {

        public int Id { get; set; }


        [Required, Display(Name = "Message"), StringLength(200, MinimumLength = 10, ErrorMessage = "Please enter Message")]
        public string Title { get; set; }

        //ForignKsy User Model
        public int UserId { get; set; }
        public User User { get; set; }

    }
}

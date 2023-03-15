using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace liaqati_master.Models
{
    public class Chat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم المحادثة")]
        public string Id { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المرسل")]
        public int SenderId { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name ="رقم المستقبل")]
        public int ReceiverID { get; set; }


        public List<Message>? Message { get; set;}
        public List<ChatUser>? ChatUser { get; set;}

    }
}

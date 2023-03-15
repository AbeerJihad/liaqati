using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace liaqati_master.Models
{
    public class ChatUser
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { set; get; }

        //ForignKsy User Model
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المستخدم")]
        public string UserId { get; set; }
        public User User { get; set; }

        //ForignKsy Chat Model
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المحادثة")]
        public string ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}

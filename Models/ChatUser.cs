namespace liaqati_master.Models
{
    public class ChatUser : BaseEntity
    {



        //ForignKsy User Model
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المستخدم")]
        public string UserId { get; set; }
        public virtual User User { get; set; }

        //ForignKsy Chat Model
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المحادثة")]
        public string ChatId { get; set; }
        public virtual Chat Chat { get; set; }
    }
}

namespace liaqati_master.Models
{
    public class Chat : BaseEntity
    {

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المرسل")]
        public int SenderId { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المستقبل")]
        public int ReceiverID { get; set; }


        public virtual List<Message>? Message { get; set; }
        public virtual List<ChatUser>? ChatUser { get; set; }

    }
}

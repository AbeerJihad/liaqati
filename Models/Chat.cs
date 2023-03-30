namespace liaqati_master.Models
{
    public class Chat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None), Key, HiddenInput]
        public string? Id { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المرسل")]
        public int SenderId { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المستقبل")]
        public int ReceiverID { get; set; }


        public List<Message>? Message { get; set; }
        public List<ChatUser>? ChatUser { get; set; }

    }
}

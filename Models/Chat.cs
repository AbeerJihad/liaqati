namespace liaqati_master.Models
{
    public class Chat
    {
        public int Id { get; set; }

        public int SenderId { get; set; }
        public int ReceiverID { get; set; }


        public List<Message>? Message { get; set; }
        public List<ChatUser>? ChatUser { get; set; }

    }
}

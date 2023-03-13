namespace liaqati_master.Models
{
    public class ChatUser
    {


        public int Id { set; get; }



        //ForignKsy User Model
        public int UserId { get; set; }
        public User User { get; set; }

        //ForignKsy Chat Model
        public int ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}

namespace liaqati_master.Models
{
    public class Event
    {
        
            //int
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Key]
            public string id { get; set; }
            public string title { get; set; }
        //    public string description { get; set; }
            public string start { get; set; }
           public string end { get; set; }

            //to do color and background
            // public int exerciseId { get; set; }
       //     public Exercise? exercise { get; set; }
        
    }
}


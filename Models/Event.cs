namespace liaqati_master.Models
{
    public class Event
    {
        //int
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }

        //to do color and background
       // public int exerciseId { get; set; }
        public Exercise? exercise { get; set; }
    }
}

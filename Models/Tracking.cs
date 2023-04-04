namespace liaqati_master.Models
{
    public class Tracking : BaseEntity
    {
        public bool Iscomplete { get; set; }
        public string? Order_DetailsId { get; set; }

        [ForeignKey(nameof(Order_DetailsId))]
        public virtual Order_Details? Order_Details { get; set; }
        public string? Exercies_programId { get; set; }
        [ForeignKey(nameof(Exercies_programId))]
        public virtual Exercies_program? Exercies_program { get; set; }

    }
}

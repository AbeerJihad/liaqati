namespace liaqati_master.Models
{
    public class Files : BaseEntity
    {
        public string? Path { get; set; }
        public string? ServiceId { get; set; }
        [ForeignKey(nameof(ServiceId))]
        public virtual Service? Service { get; set; }
        public string? HealthyId { get; set; }
        [ForeignKey(nameof(HealthyId))]
        public virtual HealthyRecipe? HealthyRecipe { get; set; }
    }
}

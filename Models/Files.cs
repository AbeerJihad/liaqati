namespace liaqati_master.Models
{
    public class Files : BaseEntity
    {
        public string? Path { get; set; }
        public string? ServiceId { get; set; }
        [ForeignKey(nameof(ServiceId))]
        public virtual Service? Service { get; set; }

        public static implicit operator List<object>(Files? v)
        {
            throw new NotImplementedException();
        }
    }
}

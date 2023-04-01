namespace liaqati_master.Models
{
    public abstract class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None), Key, HiddenInput]
        public string? Id { get; set; }
    }
}

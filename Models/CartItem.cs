namespace liaqati_master.Models
{
    public class CartItem : BaseEntity
    {
        [Required]
        public string? UserId { get; set; }
        [Required]
        public string? ServiceId { get; set; }
        [Required]
        public int Quantity { get; set; } = 1;
        [Required]
        public double UnitPrice { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [ForeignKey(nameof(ServiceId))]
        public virtual Service? Service { get; set; }
        [ForeignKey(nameof(UserId))]

        public virtual User? User { get; set; }
    }
}

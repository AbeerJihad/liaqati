namespace liaqati_master.Models
{
    public class Order_Details : BaseEntity
    {

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "السعر")]
        public double Price { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الكمية")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الطلبية")]
        public string OrderId { get; set; }
        public virtual Order? Order { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم التقييم")]
        public int? RateId { get; set; }
        public virtual Rate? Rate { get; set; }

        public string? ServiceId { get; set; }

        [ForeignKey("ServiceId")]

        public virtual Service? Service { get; set; }



    }
}

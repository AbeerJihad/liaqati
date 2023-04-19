namespace liaqati_master.Models
{
    public class Order_Details : BaseEntity
    {

        [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "السعر")]
        public double Price { get; set; }
        [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "الكمية")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "رقم الطلبية")]
        public string? OrderId { get; set; }
        public virtual Order? Order { get; set; }
        [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "رقم التقييم")]
        public int? RateId { get; set; }
        public virtual Rate? Rate { get; set; }

        public string? ServiceId { get; set; }

        [ForeignKey("ServiceId")]

        public virtual Service? Service { get; set; }

        public virtual List<Tracking>? Tracking { get; set; }
        public virtual List<Tracking_MealPlan>? Tracking_MealPlan { get; set; }



    }
}

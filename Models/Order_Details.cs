using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class Order_Details
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string? Id { get; set; }
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


        public virtual List<Tracking>? Tracking { get; set; }

    }
}

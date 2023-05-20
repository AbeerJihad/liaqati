namespace liaqati_master.Models
{

    public class Order : BaseEntity
    {

        //  [Required, Display(Tilte = "Last Tilte"), StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter at least two characters")]
        //  public string LinkName { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب"), Display(Name = "تاريخ الطلبية"), DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "مجموع الاسعار")]
        public double? TotalPrice { get; set; }
        public string? DiscountCode { get; set; }
        public int? OrderStatus { get; set; }

        [Display(Name = "رقم المستخدم")]
        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User? User { get; set; }
        public virtual List<Order_Details>? Order_Details { get; set; }



    }

}


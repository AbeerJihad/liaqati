namespace liaqati_master.Models
{
    public class Product : BaseEntity
    {

        //[Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        //[Display(Tilte = "اسم المنتج")]اسم الصنف
        //public string Pname { get; set; }
        //[ StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل صورة")]
        [Display(Name = "صورة المنتج")]
        public string? ImgUrl { get; set; } = "";

        [Required]

        [Display(Name = "الخصم")]
        public double Discount { get; set; }

        //public int? CategoryId { get; set; }
        //public TblCategory? TblCategory { get; set; }

        [ForeignKey(nameof(Id))]
        public virtual Service? Services { get; set; }
        //public int UserId { get; set; }
        //public User? User { get; set; }

    }
}

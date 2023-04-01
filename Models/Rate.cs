namespace liaqati_master.Models
{
    public class Rate : BaseEntity
    {

        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "التقييم على")]
        public string type { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "التقييم")]
        [Range(1, 5)]
        public int review { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "تاريخ التقييم")]
        [DataType(DataType.DateTime)]
        public DateTime review_date { get; set; }


        public string? Order_DetailsId { get; set; }
        public virtual Order_Details? Order_Details { get; set; }

    }
}

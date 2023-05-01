namespace liaqati_master.Models
{
    public class Achievement : BaseEntity
    {
        [Required(ErrorMessage = "{0}  الحقل مطلوب")]
        [Display(Name = "الانجاز")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "{0}  الحقل مطلوب")]
        [Display(Name = "تاريخ البدء ")]
        [DataType(DataType.DateTime)]
        public DateTime FromDate { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "{0}  الحقل مطلوب")]
        [Display(Name = "الى تاريخ")]
        public DateTime ToDate { get; set; }

        [Display(Name = "وثائق الانجازات")]
        public string File { get; set; }
        //ForignKsy User Model
        [Required(ErrorMessage = "{0}  الحقل مطلوب")]
        [Display(Name = "رقم المستخدم")]
        public string? UserId { get; set; }
        public virtual User? User { get; set; }

    }
}


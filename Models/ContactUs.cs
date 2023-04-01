namespace liaqati_master.Models
{
    public class ContactUs : BaseEntity
    {


        [Required, Display(Name = "الملاحظات"), StringLength(200, MinimumLength = 10, ErrorMessage = " رجاءً ادخل ملاحظاتك")]
        public string Title { get; set; }

        //ForignKsy User Model
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المستخدم")]
        public string UserId { get; set; }
        public virtual User User { get; set; }

    }
}

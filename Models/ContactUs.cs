using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class ContactUs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }


        [Required, Display(Name = "الملاحظات"), StringLength(200, MinimumLength = 10, ErrorMessage = " رجاءً ادخل ملاحظاتك")]
        public string Title { get; set; }

        //ForignKsy User Model
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المستخدم")]
        public string UserId { get; set; }
        public User User { get; set; }

    }
}

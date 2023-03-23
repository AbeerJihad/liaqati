using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace liaqati_master.ViewModels
{
    public class VmProduct
    {
        public string? Id { get; set; }

        //[Required, Display(Name = "عنوان الخدمة"), StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءاًأدخل حرفين على الاقل")]

        public string? Title { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "وصف الخدمة")]
        public string? Description { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = " سعر الخدمة")]
        public double? Price { get; set; }

        [Display(Name = "صورة المنتج")]
        public string? imgUrl { get; set; } = "";

        [Required]

        [Display(Name = "الخصم")]
        public double Discount { get; set; }







    }
}

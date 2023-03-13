#nullable disable
using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class Achievements
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "حقل مطلوب يرجى منك الإدخال"), Display(Name = "العنوان")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "الرجاء إدخال خمسة حروف على الأقل")]
        public string Title { get; set; }

        [DataType(DataType.Date), Required(ErrorMessage = "حقل مطلوب يرجى منك الإدخال")]
        [Display(Name = "تاريخ البدء")]
        public DateTime FromDate { get; set; }

        [DataType(DataType.Date), Required(ErrorMessage = "حقل مطلوب يرجى منك الإدخال")]
        [Display(Name = "تاريخ الإنتهاء")]
        public DateTime ToDate { get; set; }

        [Display(Name = "أضف مرفقاً")]
        public string File { get; set; }

        //ForignKsy User Model
        public int UserId { get; set; }
        public User User { get; set; }

    }
}


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class Articles
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم المقالة")]
        public string Id { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "وصف المقالة")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "تاريخ النشر")]
        [DataType(DataType.DateTime)]
        public DateTime PostDate { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "عدد المشاهدات")]
        public int ViewsNumber { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "عدد الاعجابات")]
        public int likesNumber { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الصنف")]
        public string CategoryId { get; set; }

        public Category? Category { get; set; }


        public List<Comments>? comments { get; set; }
    }
}

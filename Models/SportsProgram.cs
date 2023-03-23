using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class SportsProgram
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم النظام")]
        public string Id { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "المدة")]
        public int Length { get; set; }

        //public string? Duration { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "مستوى الصعوبة")]
        public string? Difficulty { get; set; }

        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "الجزءالذي يركز عليه النظام من الجسم")]
        public string? BodyFocus { get; set; }

        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "المعدات")]
        public string? Equipment { get; set; }
        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "نوع التدريب")]
        public string? TrainingType { get; set; }

        //[Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        //[Display(Name = "ادخل عنوان النظام الغذائي")]
        //public string? Title { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        //[Display(Name = "وصف النظام الغذائي")]
        //public string? Description { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        //[Display(Name = "سعر النظام الرياضي")]
        //public double Price { get; set; }
       
        public Service? services { get; set; }

        public List<Exercies_program>? exercies_Programs { get; set; }/*=new List<Exercies_program>();*/

     
    }
}

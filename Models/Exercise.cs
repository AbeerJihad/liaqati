using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class Exercise
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم التمرين")]
        public string Id { get; set; }
        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "اسم التمرين")]
        public string? Title { get; set; }
        // [Required(ErrorMessage = "هذا الحقل مطلوب")]
        // [Display(Name = "تاريخ البدء")]
        // [DataType(DataType.DateTime)]
        //public DateTime startDate { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        //[Display(Name = "الوصف")]
        //public string? Description { get; set; }
        //[Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        //[Display(Name = "العنوان فرعي")]
        //public string? SubTitle { get; set; }

        [Display(Name = "مدة التمرين")]
        public int? DEx { get; set; }

        [Range(1, 5)]
        public int? Difficulty { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "وصف التمارين")]
        public string? Detail { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "نوع التمرين")]
        public string? TraningType { get; set; }
        //[Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "المعدات ")]
        public string? Equipments { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "صورة")]
        public string? Image { get; set; }
        //public string? Video { get; set; }

        [Display(Name = " سعر التمرين")]
        public double? Price { get; set; }


        public List<Exercies_program>? exercies_Programs { get; set; }

    }
}

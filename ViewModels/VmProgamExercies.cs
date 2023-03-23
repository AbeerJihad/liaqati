using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace liaqati_master.ViewModels
{
    public class VmProgamExercies
    {
        public string? Id { get; set; }


        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "هل تم انجازه")]
        public bool isComplete { get; set; } = false;


        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم النمرين")]
        public string exerciseId { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم النظام الرياضي")]
        public string? sportsProgramId { get; set; }


        public int Day { get; set; }
        public int Week { get; set; }


   





    }
}

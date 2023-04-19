using liaqati_master.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace liaqati_master.ViewModels
{
    public class vmMeal_Healthy
    {
        public string? Id { get; set; }


        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "هل تم انجازه")]
        public bool isComplete { get; set; } = false;


        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم النمرين")]
        
        public string HealthyRecdpeId { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم النظام الرياضي")]
        public string? MealPlansId { get; set; }

        
        public int Day { get; set; }
        public int Week { get; set; }


   





    }
}

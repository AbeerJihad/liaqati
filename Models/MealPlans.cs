using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class MealPlans
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم النطام الغذائي")]
        [HiddenInput]
        public string? Id { get; set; }
        [Display(Name = "عدد المشتركيين")]
        public int? numsubscribers { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "المدة")]
        public int?  Length { get; set; }

        public string? dietaryType { get; set; }
        //[Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "نوع الوجبة")]
        public string? mealType { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "منوسط وقت الوجبة")]
        public double? avgRecipeTime { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "صورة الوجبة")]
        public string? image { get; set; }

       
       
        public Service? services { get; set; }


        public MealPlans() { 
        
        numsubscribers= 0;
            Length= 0;
        dietaryType= string.Empty;
            mealType= string.Empty;
            avgRecipeTime= 0;
            image= string.Empty;
        
        }

    }
}

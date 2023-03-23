using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace liaqati_master.ViewModels
{
    public class VmMealPlan
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

        //[Display(Name = "عدد المشتركيين")]
        //public int? numsubscribers { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "المدة")]
        public int? Length { get; set; }

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








    }
}

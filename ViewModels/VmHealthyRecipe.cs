using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace liaqati_master.ViewModels
{
    public class VmHealthyRecipe
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


        [Display(Name = "نوع الوجبة")]
        public MealTypeTypeStatus MealType { get; set; }

        [Display(Name = "النوع الغذائي")]
        public DieteryTypeStatus DieteryType { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "وقت التحضير")]
        [DataType(DataType.DateTime)]
        public DateTime prepTime { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "السعرات الحرارية")]
        public int Calories { get; set; }
        [Display(Name = "مجموع السعرات الحرارية")]
        public int Total_Carbohydrate { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "كمية البروتين")]
        public int Protein { get; set; }




        public string? Image { get; set; } = "";









    }
}

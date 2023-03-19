using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class Service
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string? Id { get; set; }

        //[Required, Display(Name = "عنوان الخدمة"), StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءاًأدخل حرفين على الاقل")]

        public string? Title { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "وصف الخدمة")]
        public string? Description { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = " سعر الخدمة")]
        public double? Price { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الصنف")]
        public string? CategoryId { get; set; }

        public Category? Category { get; set; } = null;
        //[Display(Name = "رقم النظام الغذائي")]
        //public string? MealPlansId { get; set; }

        public MealPlans? MealPlans { get; set; }
        //[Display(Name = "رقم الوصفة الصحية")]
        //public string? HealthyRecipesId { get; set; }

        public HealthyRecipes? HealthyRecipes { get; set; }
        //[Display(Name = "رقم المنتج")]
        //public string? ProductsId { get; set; }
        public Products? Products { get; set; }
        //[Display(Name = "رقم البرنامج الرياضي")]
        //public string? sportsProgramId { get; set; }
        public SportsProgram? sportsProgram { get; set; }

        public List<Comment_Servies>? commentServies { get; set; }

        public List<Trak>? traks { get; set; }
        public List<Favorite_Servies>? favorites { get; set; }

        public List<Order_Details>? Order_Details { get; set; }
    }
}

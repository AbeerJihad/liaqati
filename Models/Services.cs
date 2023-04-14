using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class Service
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string? Id { get; set; }

        [Required, Display(Name  = "عنوان الخدمة"), StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءاًأدخل حرفين على الاقل")]
        public string? Title { get; set; }
       
        
        [Required(ErrorMessage = "هذا الحقل مطلوب ")]
        [Display(Name = "وصف الخدمة")]
        public string? Description { get; set; }
        
        
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = " سعر الخدمة")]
        public double? Price { get; set; }
 
        
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الصنف")]
        public string? CategoryId { get; set; }



        public virtual Category? Category { get; set; } = null;
        //[Display(Tilte = "رقم النظام الغذائي")]
        //public string? MealPlansId { get; set; }

        public virtual MealPlans? MealPlans { get; set; }
        //[Display(Tilte = "رقم الوصفة الصحية")]
        //public string? HealthyRecipesId { get; set; }

       
        public virtual Product? Products { get; set; }
        //[Display(Tilte = "رقم البرنامج الرياضي")]
        //public string? sportsProgramId { get; set; }
        public virtual SportsProgram? SportsProgram { get; set; }

        public virtual List<Comment_Servies>? commentServies { get; set; }

        public virtual List<Favorite_Servies>? favorites { get; set; }

        public virtual List<Order_Details>? Order_Details { get; set; }
    }
}

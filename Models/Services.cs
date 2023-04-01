namespace liaqati_master.Models
{
    public class Service : BaseEntity
    {
        //[Required, Display(Tilte = "عنوان الخدمة"), StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءاًأدخل حرفين على الاقل")]
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

        public virtual Category? Category { get; set; } = null;
        //[Display(Tilte = "رقم النظام الغذائي")]
        //public string? MealPlansId { get; set; }

        public virtual MealPlans? MealPlans { get; set; }
        //[Display(Tilte = "رقم الوصفة الصحية")]
        //public string? HealthyRecipesId { get; set; }

        public virtual HealthyRecipe? HealthyRecipes { get; set; }
        //[Display(Tilte = "رقم المنتج")]
        //public string? ProductsId { get; set; }
        public virtual Product? Products { get; set; }
        //[Display(Tilte = "رقم البرنامج الرياضي")]
        //public string? sportsProgramId { get; set; }
        public virtual SportsProgram? SportsProgram { get; set; }

        public virtual List<Comment_Servies>? CommentServies { get; set; }

        public virtual List<Trak>? Traks { get; set; }
        public virtual List<Favorite_Servies>? Favorites { get; set; }

        public virtual List<Order_Details>? Order_Details { get; set; }
    }
}

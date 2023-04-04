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
        [ForeignKey(nameof(CategoryId))]
        public virtual Category? Category { get; set; }
        //[Display(Tilte = "رقم النظام الغذائي")]
        //public string? MealPlansId { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]

        public virtual MealPlans? MealPlans { get; set; }
        //[Display(Tilte = "رقم الوصفة الصحية")]
        //public string? HealthyRecipesId { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual HealthyRecipe? HealthyRecipes { get; set; }
        //[Display(Tilte = "رقم المنتج")]
        //public string? ProductsId { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]

        public virtual Product? Products { get; set; }
        //[Display(Tilte = "رقم البرنامج الرياضي")]
        //public string? sportsProgramId { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual SportsProgram? SportsProgram { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<Comment_Servies>? CommentServies { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]

        public virtual List<Tracking>? Traks { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]

        public virtual List<Favorite_Servies>? Favorites { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]

        public virtual List<Order_Details>? Order_Details { get; set; }
    }
}

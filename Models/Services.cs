namespace liaqati_master.Models
{
    public class Service : BaseEntity
    {
        [Required(ErrorMessage = "{0} هذا الحقل مطلوب"), Display(Name = "عنوان الخدمة")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "وصف الخدمة"), Column(TypeName = "NTEXT")]
        public string? Description { get; set; }
        [Display(Name = "وصف قصير")]
        public string? ShortDescription { get; set; }
        [Display(Name = "صورة")]
        public string? Image { get; set; }
        [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = " سعر الخدمة")]
        public double? Price { get; set; }
        // [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "رقم الصنف")]
        public string? CategoryId { get; set; }

        [Display(Name = " التقييم"), Range(0, 100)]
        public double? RatePercentage { get; set; }
        [Display(Name = "هل هو مميز؟")]
        public bool? IsFeatured { get; set; }
        [Display(Name = "هل هو متاح؟")]
        public bool? IsAvailable { get; set; }


        [ForeignKey(nameof(CategoryId))]
        public virtual Category? Category { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual MealPlans? MealPlans { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public virtual Product? Products { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public virtual SportsProgram? SportsProgram { get; set; }
        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User? User { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<Comment_Servies>? CommentServies { get; set; }
        //[System.Text.Json.Serialization.JsonIgnore]
        //public virtual List<Tracking>? Traks { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<Favorite>? Favorite { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<Order_Details>? Order_Details { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<CartItem>? CartItems { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<Files>? Files { get; set; }
    }
}

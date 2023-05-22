namespace liaqati_master.Models
{

    public class Article : BaseEntity
    {

        [Required(ErrorMessage = " {0} حقل مطلوب")]
        [Display(Name = "وصف المقالة")]
        public string? Description { get; set; }
        [Required(ErrorMessage = " {0} حقل مطلوب")]
        [Display(Name = "مقدمة المقالة")]
        public string? Introduction { get; set; }
        public string? Image { get; set; }
        [Required(ErrorMessage = " {0} حقل مطلوب"), Display(Name = "عنوان المقال")]
        public string? Title { get; set; }
        [Display(Name = "عدد المشاهدات")]
        public int ViewsNumber { get; set; } = 0;
        [Display(Name = "عدد الاعجابات")]
        public int LikesNumber { get; set; } = 0;
        [Display(Name = "متوسط  وقت القراءة ")]
        public int avgReading { get; set; } = 10;
        [Required(ErrorMessage = " {0} حقل مطلوب")]
        [Display(Name = "رقم الصنف")]
        public string? CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category? Category { get; set; }
        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User? User { get; set; }


        public virtual List<Comments>? comments { get; set; }

        public virtual List<Favorite>? Favorite { get; set; }


    }
}

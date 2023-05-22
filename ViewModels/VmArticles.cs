namespace liaqati_master.ViewModels
{
    public class VmArticles
    {

        [Required(ErrorMessage = " {0} حقل مطلوب")]
        [Display(Name = "وصف المقالة")]
        public string? Id { get; set; }

        [Required(ErrorMessage = " {0} حقل مطلوب")]
        [Display(Name = "وصف المقالة")]
        public string? Description { get; set; }
        public string? Image { get; set; }
        [Required(ErrorMessage = " {0} حقل مطلوب"), Display(Name = "عنوان المقال")]
        public string? Title { get; set; }
        [Display(Name = "تاريخ النشر")]
        [DataType(DataType.DateTime)]
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        [Display(Name = "عدد المشاهدات")]
        public int ViewsNumber { get; set; } = 0;
        [Display(Name = "عدد الاعجابات")]
        public int LikesNumber { get; set; } = 0;
        [Display(Name = "متوسط  وقت القراءة ")]
        public int avgReading { get; set; } = 10;
        [Required(ErrorMessage = " {0} حقل مطلوب")]


        public int IsFavorite { get; set; }



        [Display(Name = "رقم الصنف")]
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? UserId { get; set; }


    }
}

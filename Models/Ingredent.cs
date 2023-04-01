namespace liaqati_master.Models
{
    public class Ingredent : BaseEntity
    {

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الكمية")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الوصف")]
        public string? Description { get; set; }
        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "اسم المكون")]
        public string Title { get; set; }


    }
}

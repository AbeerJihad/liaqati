namespace liaqati_master.Models
{
    public class Category : BaseEntity
    {

        [Display(Name = "اسم الصنف"), StringLength(50, MinimumLength = 2, ErrorMessage = "هذا الحقل مطلوب")]
        public string? Name { get; set; }
        [Display(Name = "تابع إلى")]
        public Target Target { get; set; }
        [Display(Name = "صورة")]
        public string? Image { get; set; }
        [JsonIgnore]
        public virtual List<Service>? Services { get; set; }
        [JsonIgnore]
        public virtual List<Article>? Articles { get; set; }
    }
}

namespace liaqati_master.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None), Key, HiddenInput]
        public string? Id { get; set; }
        [Display(Name = "اسم الصنف"), StringLength(50, MinimumLength = 2, ErrorMessage = "هذا الحقل مطلوب")]
        public string? Name { get; set; }
        [Display(Name = "تابع إلى")]
        public Target? Target { get; set; }
        [Display(Name = "صورة")]
        public string? Image { get; set; }
        [JsonIgnore]
        public List<Service>? Services { get; set; }
        [JsonIgnore]
        public List<Article>? Articles { get; set; }
    }
    public enum Target
    {
        prouducts,
    }
}

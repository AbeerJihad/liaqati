namespace liaqati_master.Models
{
    public class Favorite : BaseEntity
    {

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "النوع المفضل")]
        public string? Type { get; set; }
        public virtual List<Favorite_Servies>? Favorite_Servies { get; set; }
    }
}

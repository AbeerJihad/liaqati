namespace liaqati_master.Models
{
    public class Favorite_Servies : BaseEntity
    {

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الخدمة")]
        public string? ServicesId { get; set; }
        [ForeignKey(nameof(ServicesId))]
        public virtual Service? Services { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المفضل")]
        public string? FavoriteId { get; set; }
        [ForeignKey(nameof(FavoriteId))]
        public virtual Favorite? Favorite { get; set; }
    }
}

namespace liaqati_master.Models
{
    public class Favorite_Servies
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None), Key, HiddenInput]
        public string? Id { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الخدمة")]
        public int? ServicesId { get; set; }

        public Service? Services { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المفضل")]
        public string? FavoriteId { get; set; }
        [ForeignKey(nameof(FavoriteId))]
        public Favorite? Favorite { get; set; }
    }
}

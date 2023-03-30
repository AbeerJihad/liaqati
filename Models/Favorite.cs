namespace liaqati_master.Models
{
    public class Favorite
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None), Key, HiddenInput]

        public string? Id { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "النوع المفضل")]
        public string? Type { get; set; }
        public List<Favorite_Servies>? Favorite_Servies { get; set; }
    }
}

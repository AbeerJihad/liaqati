using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم الصنف")]
        public string? Id { get; set; }
        [Display(Name = "اسم الصنف"), StringLength(50, MinimumLength = 2, ErrorMessage = "هذا الحقل مطلوب")]

        public string? Name { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        //[Display(Tilte = "تابع الى")]
        public Target? Target { get; set; }

        //public string categoryFor { get; set; }
        [Display(Name = "صورة")]
        public string? Image { get; set; }
        //public List<Products>? products { get; set; }
        [JsonIgnore]
        public List<Service>? services { get; set; }
        [JsonIgnore]

        public List<Article>? articles { get; set; }
    }

    public enum Target
    {
        prouducts,
    }
}

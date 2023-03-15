using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم المحادثة")]

        public string? Id { get; set; }
        [Required, Display(Name = "اسم الصنف"), StringLength(50, MinimumLength = 2, ErrorMessage = "هذا الحقل مطلوب")]

        public string? Name { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        //[Display(Name = "تابع الى")]
        public Target target { get; set; }

        //public string categoryFor { get; set; }
        [Display(Name = "صورة")]
        public string? Image { get; set; }
        //public List<Products>? products { get; set; }
        public List<Service>? services { get; set; }

        public List<Articles>? articles { get; set; }
    }

    public enum Target
    {
        prouducts,
    }
}

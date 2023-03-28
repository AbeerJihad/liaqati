using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace liaqati_master.Models
{
    public class Trak
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم")]
        public string Id { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [ Display(Name = "رفم الخدمة")]
        public string? ServicesId { get; set; }

        public Service? Services { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace liaqati_master.Models
{
    public class Exercies_program
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم النظام الرياضي")]
        public string Id { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "هل تم انجازه")]
        public bool isComplete { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم النمرين")]
        public string exerciseId { get; set; }
        public Exercise? exercise { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم النظام الرياضي")]
        public string? sportsProgramId { get; set; }
        public SportsProgram? sportsProgram { get; set; }


    }
}

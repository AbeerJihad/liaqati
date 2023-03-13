using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class Exercise
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public string? Title { get; set; }

        [DataType(DataType.DateTime), Required]
        public DateTime startDate { get; set; }
        public string? Description { get; set; }
        public string? SubTitle { get; set; }

        [Display(Name = "مدة التمرين")]
        public int? DEx { get; set; }

        //[MaxLength(5)]
        public int? Difficulty { get; set; }
        public string? Detail { get; set; }

        public string? TraningType { get; set; }

        public string? Equipments { get; set; }

        public string? Image { get; set; }
        //public string? Video { get; set; }

        public List<Exercies_program>? exercies_Programs { get; set; }

    }
}

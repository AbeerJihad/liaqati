using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class AthleticProgram
    {
        [Key]
        public int Id { get; set; }
        public int Length { get; set; }

        //public string? Duration { get; set; }

        public string? Difficulty { get; set; }

        public string? BodyFocus { get; set; }
        public string? Equipment { get; set; }

        public string? TrainingType { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public double Price { get; set; }

        public int? servicesId { get; set; }

        public Service? services { get; set; }

        public List<Exercies_program>? exercies_Programs { get; set; }

    }
}

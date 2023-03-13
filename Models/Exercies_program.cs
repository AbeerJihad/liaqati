namespace liaqati_master.Models
{
    public class Exercies_program
    {
        public int Id { get; set; }
        public bool isComplete { get; set; }

        public int exerciseId { get; set; }
        public Exercise? exercise { get; set; }

        public int? sportsProgramId { get; set; }
        public AthleticProgram? sportsProgram { get; set; }


    }
}

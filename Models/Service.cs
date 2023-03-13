using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class Service
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Id { get; set; }

        [Required, Display(Name = "Title"), StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter at least two characters")]

        public string Title { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        public int? MealPlansId { get; set; }

        public MealPlans? MealPlans { get; set; }

        public int? HealthyRecipesId { get; set; }

        public HealthyRecipes? HealthyRecipes { get; set; }

        public int? ProductsId { get; set; }
        public Products? Products { get; set; }

        public int? sportsProgramId { get; set; }
        public AthleticProgram? sportsProgram { get; set; }

        public List<Comment_Servies>? commentServies { get; set; }

        public List<Trak>? traks { get; set; }
        public List<Favorite_Servies>? favorites { get; set; }
    }
}

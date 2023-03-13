namespace liaqati_master.Models
{
    public class MealPlans
    {
        public int Id { get; set; }
        public int Length { get; set; }
        public string dietaryType { get; set; }
        public string mealType { get; set; }
        public double avgRecipeTime { get; set; }

        public int? servicesId { get; set; }

        public Service? services { get; set; }

    }
}

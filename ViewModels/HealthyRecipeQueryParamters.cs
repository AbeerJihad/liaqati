namespace liaqati_master.ViewModels
{
    public class HealthyRecipeQueryParamters : QueryParameters
    {

        public List<string?>? DietaryType { get; set; }
        public List<string?>? MealType { get; set; }
        public int? MinPrepTime { get; set; }
        public int? MaxPrepTime { get; set; }
        public int? MinCalories { get; set; }
        public int? MaxCalories { get; set; }
        public string SearchTearm { get; set; } = string.Empty;

    }
}

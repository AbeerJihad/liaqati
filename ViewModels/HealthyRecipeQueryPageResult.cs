namespace liaqati_master.ViewModels
{
    public class HealthyRecipeQueryPageResult : QueryPageResult<VmHealthyRecipe>
    {
        public List<int>? MealTypeCounters { get; set; }
        public List<int>? DietaryTypeCounters { get; set; }

    }
}

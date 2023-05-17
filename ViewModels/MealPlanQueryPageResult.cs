namespace liaqati_master.ViewModels
{
    public class MealPlanQueryPageResult : QueryPageResult<MealPlans>
    {
        public List<int> MealTypeCounters { get; set; }
        public List<int> DietaryTypeCounters { get; set; }

    }
}

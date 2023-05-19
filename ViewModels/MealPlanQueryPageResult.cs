namespace liaqati_master.ViewModels
{
    public class MealPlanQueryPageResult : QueryPageResult<MealPlanVM>
    {
        public List<int>? ProgramLengthCounters { get; set; }
        public List<int>? DietaryTypeCounters { get; set; }
        public List<int>? MealTypeCounters { get; set; }


    }
}

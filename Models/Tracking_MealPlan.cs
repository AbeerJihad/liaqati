namespace liaqati_master.Models
{
    public class Tracking_MealPlan
    {

        public string Id { get; set; }







        public bool Iscomplete { get; set; }

        public string? Order_DetailsId { get; set; }

        [ForeignKey(nameof(Order_DetailsId))]
        public virtual Order_Details? Order_Details { get; set; }



         public string? Meal_HealthyId { get; set; }
        [ForeignKey(nameof(Meal_HealthyId))]
        public virtual Meal_Healthy? Meal_Healthy { get; set; }


    }




}

namespace liaqati_master.ViewModels
{
    public class ExerciseQueryParamters: QueryParameters
    {

        public List<string>? BodyFocus { get; set; }
        public List<string>? TraningType { get; set; }
        public List<int>? Difficulty { get; set; }
        public List<string>? Equipment { get; set; }

        public decimal? MinDuration { get; set; }
        public decimal? MaxDuration { get; set; }

        public string SearchTearm { get; set; } = string.Empty;

    }
}

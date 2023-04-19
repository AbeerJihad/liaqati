namespace liaqati_master.ViewModels
{
    public class ExerciseQueryParamters: QueryParameters
    {

        //public string? BodyFocus { get; set; }
        public List<string> BodyFocus { get; set; }
        public List<string> TraningType { get; set; }
        public List<int> Difficulty { get; set; }
        public List<string> Equipment { get; set; }
        public List<int> Duration { get; set; }
    }
}

﻿namespace liaqati_master.ViewModels
{
    public class ExerciseVM
    {

        public string Image { get; set; }
        public string? Title { get; set; }
        public double? Price { get; set; }
        public string? Id { get; set; }
        public string? BodyFocus { get; set; }
        public string? BurnEstimate { get; set; }
        public int? Difficulty { get; set; }
        public int? Duration { get; set; }
        public string? Detail { get; set; }
        public string? ShortDescription { get; set; }
        public string? Video { get; set; }
        public string? Equipments { get; set; }
        public string? TraningType { get; set; }



        public int IsFavorite { get; set; }

        public List<Exercise> exercises { get; set; }







    }
}

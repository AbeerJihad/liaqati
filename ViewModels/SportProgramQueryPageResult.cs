﻿namespace liaqati_master.ViewModels
{
    public class SportProgramQueryPageResult : QueryPageResult<SportProgramVM>
    {
        public List<int>? BodyfocusCounters { get; set; }
        public List<int>? TraningTypeCounters { get; set; }
        public List<int>? DifficultyCounters { get; set; }
        public List<int>? EquipmentCounters { get; set; }
        public List<int>? ProgramLengthCounters { get; set; }
    }
}

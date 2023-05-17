namespace liaqati_master.ViewModels
{
    public class AppliedFilters
    {
        public AppliedFilters(string propartyName, string propartyValue)
        {
            PropartyName = propartyName;
            PropartyValue = propartyValue;
        }

        public string PropartyName { get; set; }
        public string PropartyValue { get; set; }

    }
}

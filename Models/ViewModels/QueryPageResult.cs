namespace liaqati_master.Models.ViewModels
{
    public class QueryPageResult<T> where T : class
    {
        public int TotalCount { get; set; } = 0;
        public int TotalPages { get; set; } = 1;
        public int FirstRowOnPage { get; set; }
        public int LastRowOnPage { get; set; }
        public int? PreviousPage { get; set; }
        public int? NextPage { get; set; }
        public IQueryable<T> ListOfData { get; set; }
    }

}

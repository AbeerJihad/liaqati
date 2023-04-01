
namespace liaqati_master.Services
{
    public static class CommonMethods
    {
        public static string Id_Guid() => Guid.NewGuid().ToString();
        public static QueryPageResult<T> GetPageResult<T>(IQueryable<T> ListOfData, QueryParameters qp) where T : class
        {

            QueryPageResult<T> queryPageResult = new()
            {
                TotalCount = ListOfData.Count()
            };
            queryPageResult.TotalPages = (int)Math.Ceiling(queryPageResult.TotalCount / (double)qp.Size);
            if ((qp.CurPage - 1) > 0)
                queryPageResult.PreviousPage = qp.CurPage - 1;

            if ((qp.CurPage + 1) <= queryPageResult.TotalPages)
                queryPageResult.NextPage = qp.CurPage + 1;

            if (queryPageResult.TotalCount == 0)
                queryPageResult.FirstRowOnPage = queryPageResult.LastRowOnPage = 0;
            else
            {
                queryPageResult.FirstRowOnPage = (qp.CurPage - 1) * qp.Size + 1;
                queryPageResult.LastRowOnPage = Math.Min(qp.CurPage * qp.Size, queryPageResult.TotalCount);
            }
          ;
            queryPageResult.ListOfData = ListOfData.Skip(qp.Size * (qp.CurPage - 1)).Take(qp.Size);
            return queryPageResult;
        }
    }
}

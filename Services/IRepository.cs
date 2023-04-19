namespace liaqati_master.Services
{
    public interface IRepository<T> where T : class
    {
        Task<T> AddEntityAsync(T Entity);
        Task<T> DeleteEntityAsync(T Entity);
        Task<T> DeleteEntityAsync(string Id);
        Task<T> UpdateEntityAsync(T Entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIDAsync(string EntityId);
        Task SaveAsync();


    }
}

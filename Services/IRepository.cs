namespace liaqati_master.Services
{
    public interface IRepository<T> where T : class
    {
        Task<T> AddEntity(T Entity);
        Task<T> DeleteEntity(T Entity);
        Task<T> DeleteEntity(int Id);
        Task<T> UpdateEntity(T Entity);
        IEnumerable<T> GetAll();
        T GetStudentByID(int EntityId);
        Task Save();

    }
}

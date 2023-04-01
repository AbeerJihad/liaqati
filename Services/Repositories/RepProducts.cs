namespace liaqati_master.Services.Repositories
{

    public class RepProducts : IRepository<Product>
    {
        private readonly LiaqatiDBContext _context;
        public RepProducts(LiaqatiDBContext context)
        {
            _context = context;
        }

        public Task<Product> AddEntityAsync(Product Entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> DeleteEntityAsync(Product Entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> DeleteEntityAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetByIDAsync(string EntityId)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateEntityAsync(Product Entity)
        {
            throw new NotImplementedException();
        }
    }
}

namespace liaqati_master.Services.Repositories
{
    public class IRepoService
    {
        private readonly LiaqatiDBContext _context;

        public IRepoService(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Service> AddEntityAsync(Service Entity)
        {
            await _context.TblServices.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Service> DeleteEntityAsync(Service Entity)
        {
            if (Entity != null)
            {
                _context.TblServices.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Service();
            }
        }

        public async Task<Service> DeleteEntityAsync(string Id)
        {
            var service = await _context.TblServices.FindAsync(Id);
            if (service != null)
            {
                _context.TblServices.Remove(service);
                await SaveAsync();
                return service;
            }
            else
            {
                return new Service();
            }
        }

        public async Task<IEnumerable<Service>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblServices.ToListAsync();
        }

        public async Task<Service?> GetByIDAsync(string EntityId)
        {
            return await _context.TblServices.FirstOrDefaultAsync(a => a.Id == EntityId);
        }

        public async Task SaveAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Service> UpdateEntityAsync(Service Entity)
        {
            Service? service = await _context.TblServices.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (service != null)
            {
                _context.TblServices.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Service();
            }
        }
    }
}


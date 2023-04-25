namespace liaqati_master.Services.Repositories
{
    public class IRepoRate
    {
        private readonly LiaqatiDBContext _context;

        public IRepoRate(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Rate> AddEntityAsync(Rate Entity)
        {
            await _context.TblRate.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Rate> DeleteEntityAsync(Rate Entity)
        {
            if (Entity != null)
            {
                _context.TblRate.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Rate();
            }
        }

        public async Task<Rate> DeleteEntityAsync(string Id)
        {
            var rate = await _context.TblRate.FindAsync(Id);
            if (rate != null)
            {
                _context.TblRate.Remove(rate);
                await SaveAsync();
                return rate;
            }
            else
            {
                return new Rate();
            }
        }

        public async Task<IEnumerable<Rate>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblRate.ToListAsync();
        }

        public async Task<Rate?> GetByIDAsync(string EntityId)
        {
            return await _context.TblRate.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Rate> UpdateEntityAsync(Rate Entity)
        {
            Rate? rate = await _context.TblRate.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (rate != null)
            {
                _context.TblRate.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Rate();
            }
        }
    }
}

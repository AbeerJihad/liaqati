namespace liaqati_master.Services.Repositories
{
    public class IRepoTraking
    {
        private readonly LiaqatiDBContext _context;

        public IRepoTraking(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Tracking> AddEntityAsync(Tracking Entity)
        {
            await _context.TblTracking.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Tracking> DeleteEntityAsync(Tracking Entity)
        {
            if (Entity != null)
            {
                _context.TblTracking.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Tracking();
            }
        }

        public async Task<Tracking> DeleteEntityAsync(string Id)
        {
            var rate = await _context.TblTracking.FindAsync(Id);
            if (rate != null)
            {
                _context.TblTracking.Remove(rate);
                await SaveAsync();
                return rate;
            }
            else
            {
                return new Tracking();
            }
        }

        public async Task<IEnumerable<Tracking>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblTracking.ToListAsync();
        }

        public async Task<Tracking?> GetByIDAsync(string EntityId)
        {
            return await _context.TblTracking.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Tracking> UpdateEntityAsync(Tracking Entity)
        {
            Tracking? rate = await _context.TblTracking.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (rate != null)
            {
              _context.TblTracking.Remove(rate);
           

                try
                {
                    await _context.SaveChangesAsync();

                }
                catch (Exception)
                {
                    throw;
                }

                await _context.TblTracking.AddAsync(rate);
                await _context.SaveChangesAsync();



                return Entity;

            }
            else
            {
                return new Tracking();
            }
        }
    }
}

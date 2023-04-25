namespace liaqati_master.Services.Repositories
{
    public class IRepoNotification
    {
        private readonly LiaqatiDBContext _context;

        public IRepoNotification(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Notification> AddEntityAsync(Notification Entity)
        {
            await _context.TblNotification.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Notification> DeleteEntityAsync(Notification Entity)
        {
            if (Entity != null)
            {
                _context.TblNotification.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Notification();
            }
        }

        public async Task<Notification> DeleteEntityAsync(string Id)
        {
            var notification = await _context.TblNotification.FindAsync(Id);
            if (notification != null)
            {
                _context.TblNotification.Remove(notification);
                await SaveAsync();
                return notification;
            }
            else
            {
                return new Notification();
            }
        }

        public async Task<IEnumerable<Notification>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblNotification.ToListAsync();
        }

        public async Task<Notification?> GetByIDAsync(string EntityId)
        {
            return await _context.TblNotification.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Notification> UpdateEntityAsync(Notification Entity)
        {
            Notification? notification = await _context.TblNotification.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (notification != null)
            {
                _context.TblNotification.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Notification();
            }
        }
    }
}

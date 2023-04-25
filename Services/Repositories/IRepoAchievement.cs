namespace liaqati_master.Services.Repositories
{
    public class IRepoAchievement
    {
        private readonly LiaqatiDBContext _context;

        public IRepoAchievement(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Achievement> AddEntityAsync(Achievement Entity)
        {
            await _context.TblAchievements.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Achievement> DeleteEntityAsync(Achievement Entity)
        {
            if (Entity != null)
            {
                _context.TblAchievements.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Achievement();
            }
        }

        public async Task<Achievement> DeleteEntityAsync(string Id)
        {
            var achievement = await _context.TblAchievements.FindAsync(Id);
            if (achievement != null)
            {
                _context.TblAchievements.Remove(achievement);
                await SaveAsync();
                return achievement;
            }
            else
            {
                return new Achievement();
            }
        }

        public async Task<IEnumerable<Achievement>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblAchievements.ToListAsync();
        }

        public async Task<Achievement?> GetByIDAsync(string EntityId)
        {
            return await _context.TblAchievements.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Achievement> UpdateEntityAsync(Achievement Entity)
        {
            Achievement? achievement = await _context.TblAchievements.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (achievement != null)
            {
                _context.TblAchievements.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Achievement();
            }
        }
    }
}


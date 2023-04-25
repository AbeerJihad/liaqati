namespace liaqati_master.Services.Repositories
{
    public class IRepoFavorite
    {
        private readonly LiaqatiDBContext _context;

        public IRepoFavorite(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Favorite> AddEntityAsync(Favorite Entity)
        {
            await _context.TblFavorite.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Favorite> DeleteEntityAsync(Favorite Entity)
        {
            if (Entity != null)
            {
                _context.TblFavorite.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Favorite();
            }
        }

        public async Task<Favorite> DeleteEntityAsync(string Id)
        {
            var favorite = await _context.TblFavorite.FindAsync(Id);
            if (favorite != null)
            {
                _context.TblFavorite.Remove(favorite);
                await SaveAsync();
                return favorite;
            }
            else
            {
                return new Favorite();
            }
        }

        public async Task<IEnumerable<Favorite>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblFavorite.ToListAsync();
        }

        public async Task<Favorite?> GetByIDAsync(string EntityId)
        {
            return await _context.TblFavorite.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Favorite> UpdateEntityAsync(Favorite Entity)
        {
            Favorite? chat = await _context.TblFavorite.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (chat != null)
            {
                _context.TblFavorite.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Favorite();
            }
        }
    }
}

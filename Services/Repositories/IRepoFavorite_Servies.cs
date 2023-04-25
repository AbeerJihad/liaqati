namespace liaqati_master.Services.Repositories
{

    public class IRepoFavorite_Servies
    {
        private readonly LiaqatiDBContext _context;

        public IRepoFavorite_Servies(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Favorite_Servies> AddEntityAsync(Favorite_Servies Entity)
        {
            await _context.TblFavorite_Servies.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Favorite_Servies> DeleteEntityAsync(Favorite_Servies Entity)
        {
            if (Entity != null)
            {
                _context.TblFavorite_Servies.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Favorite_Servies();
            }
        }

        public async Task<Favorite_Servies> DeleteEntityAsync(string Id)
        {
            var favorite_Servies = await _context.TblFavorite_Servies.FindAsync(Id);
            if (favorite_Servies != null)
            {
                _context.TblFavorite_Servies.Remove(favorite_Servies);
                await SaveAsync();
                return favorite_Servies;
            }
            else
            {
                return new Favorite_Servies();
            }
        }

        public async Task<IEnumerable<Favorite_Servies>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblFavorite_Servies.ToListAsync();
        }

        public async Task<Favorite_Servies?> GetByIDAsync(string EntityId)
        {
            return await _context.TblFavorite_Servies.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Favorite_Servies> UpdateEntityAsync(Favorite_Servies Entity)
        {
            Favorite_Servies? favorite_Servies = await _context.TblFavorite_Servies.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (favorite_Servies != null)
            {
                _context.TblFavorite_Servies.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Favorite_Servies();
            }
        }
    }
}

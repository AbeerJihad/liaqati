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

        public async Task<List<Favorite>?> GetByUserIDAsync(string UserId)
        {
            return await _context.TblFavorite.Where(a => a.UserId == UserId).ToListAsync();
        }

        public async Task<Favorite?> GetByServiesIDAsync(string EntityId)
        {
            return await _context.TblFavorite.FirstOrDefaultAsync(a => a.ServicesId == EntityId);
        }



        public async Task<bool> DeleteByExerIdAsync(string EntityId)
        {
            if (EntityId != null)
            {
                Favorite? favorite = await _context.TblFavorite.FirstOrDefaultAsync(a => a.ExerciseId == EntityId);

                if (favorite != null)
                {
                    _context.TblFavorite.Remove(favorite);
                    await SaveAsync();
                    return true;
                }

                return false;
            }
            else
            {
                return false;
            }
        }


        public async Task<bool> DeleteByHealIdAsync(string EntityId)
        {
            if (EntityId != null)
            {
                Favorite? favorite = await _context.TblFavorite.FirstOrDefaultAsync(a => a.HealthyRecipeId == EntityId);

                if (favorite != null)
                {
                    _context.TblFavorite.Remove(favorite);
                    await SaveAsync();
                    return true;
                }

                return false;
            }
            else
            {
                return false;
            }
        }
       // a57f446b-5ffa-4538-afb1-a8ffe040b081
        public async Task<bool> DeleteBySerIdAsync(string EntityId)
        {
            if (EntityId != null)
            {
                Favorite? favorite = await _context.TblFavorite.FirstOrDefaultAsync(a => a.ServicesId == EntityId);

                if (favorite != null)
                {
                    _context.TblFavorite.Remove(favorite);
                    await SaveAsync();
                    return true;
                }

                return false;

            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteByArticalIdAsync(string EntityId)
        {
            if (EntityId != null)
            {
                Favorite? favorite = await _context.TblFavorite.FirstOrDefaultAsync(a => a.ArticleId == EntityId);

                if (favorite != null)
                {
                    _context.TblFavorite.Remove(favorite);
                    await SaveAsync();
                    return true;
                }

                return false;

            }
            else
            {
                return false;
            }
        }




        public async Task<bool> DeleteFavoriteAsync(string id)
        {
          

            await   DeleteBySerIdAsync(id);
            await DeleteByExerIdAsync(id);
            await DeleteByHealIdAsync(id);
            await DeleteByArticalIdAsync(id);


            return true;

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

using System.Linq;

namespace liaqati_master.Services.Repositories
{
    public class IRepoFiles
    {
        private readonly LiaqatiDBContext _context;

        public IRepoFiles(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Files> AddEntityAsync(Files Entity)
        {
            await _context.TblFiles.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }
        public async Task<bool> AddRangeOfFiles(List<Files> Entity)
        {
            await _context.TblFiles.AddRangeAsync(Entity);
            await SaveAsync();
            return true;
        }

        public async Task<Files> DeleteEntityAsync(Files Entity)
        {
            if (Entity != null)
            {
                _context.TblFiles.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Files();
            }
        }

        public async Task<Files> DeleteEntityAsync(string Id)
        {
            var file = await _context.TblFiles.FindAsync(Id);
            if (file != null)
            {
                _context.TblFiles.Remove(file);
                await SaveAsync();
                return file;
            }
            else
            {
                return new Files();
            }
        }

        public async Task<IEnumerable<Files>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblFiles.ToListAsync();
        }

        public async Task<Files?> GetByIDAsync(string EntityId)
        {
            return await _context.TblFiles.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Files> UpdateEntityAsync(Files Entity)
        {
            Files? article = await _context.TblFiles.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (article != null)
            {
                _context.TblFiles.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Files();
            }
        }

        public async Task<List<Files>>? GetByHealthyRecipesIDAsync(string Id)
        {
            return  _context.TblFiles.Where(a => a.HealthyId == Id).ToList();
        }


    }
}

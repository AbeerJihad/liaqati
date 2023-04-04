namespace liaqati_master.Services.Repositories
{
    public class RepoArticles : IRepository<Article>
    {
        private readonly LiaqatiDBContext _context;

        public RepoArticles(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Article> AddEntityAsync(Article Entity)
        {
            await _context.TblArticles.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Article> DeleteEntityAsync(Article Entity)
        {
            if (Entity != null)
            {
                _context.TblArticles.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Article();
            }
        }

        public async Task<Article> DeleteEntityAsync(string Id)
        {
            var article = await _context.TblArticles.FindAsync(Id);
            if (article != null)
            {
                _context.TblArticles.Remove(article);
                await SaveAsync();
                return article;
            }
            else
            {
                return new Article();
            }
        }

        public async Task<IEnumerable<Article>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblArticles.ToListAsync();
        }

        public async Task<Article?> GetByIDAsync(string EntityId)
        {
            return await _context.TblArticles.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Article> UpdateEntityAsync(Article Entity)
        {
            Article? article = await _context.TblArticles.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (article != null)
            {
                _context.TblArticles.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Article();
            }
        }
    }
}

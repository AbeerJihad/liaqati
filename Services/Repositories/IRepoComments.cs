namespace liaqati_master.Services.Repositories
{
    public class IRepoComments
    {
        private readonly LiaqatiDBContext _context;

        public IRepoComments(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Comments> AddEntityAsync(Comments Entity)
        {
            await _context.TblComment.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Comments> DeleteEntityAsync(Comments Entity)
        {
            if (Entity != null)
            {
                _context.TblComment.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Comments();
            }
        }

        public async Task<Comments> DeleteEntityAsync(string Id)
        {
            var comment = await _context.TblComment.FindAsync(Id);
            if (comment != null)
            {
                _context.TblComment.Remove(comment);
                await SaveAsync();
                return comment;
            }
            else
            {
                return new Comments();
            }
        }

        public async Task<IEnumerable<Comments>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblComment.ToListAsync();
        }

        public async Task<Comments?> GetByIDAsync(string EntityId)
        {
            return await _context.TblComment.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Comments> UpdateEntityAsync(Comments Entity)
        {
            Comments? comment = await _context.TblComment.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (comment != null)
            {
                _context.TblComment.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Comments();
            }
        }
    }
}

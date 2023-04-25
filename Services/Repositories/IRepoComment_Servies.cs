namespace liaqati_master.Services.Repositories
{
    public class IRepoComment_Servies
    {
        private readonly LiaqatiDBContext _context;

        public IRepoComment_Servies(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Comment_Servies> AddEntityAsync(Comment_Servies Entity)
        {
            await _context.TblCommentServies.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Comment_Servies> DeleteEntityAsync(Comment_Servies Entity)
        {
            if (Entity != null)
            {
                _context.TblCommentServies.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Comment_Servies();
            }
        }

        public async Task<Comment_Servies> DeleteEntityAsync(string Id)
        {
            var commentServies = await _context.TblCommentServies.FindAsync(Id);
            if (commentServies != null)
            {
                _context.TblCommentServies.Remove(commentServies);
                await SaveAsync();
                return commentServies;
            }
            else
            {
                return new Comment_Servies();
            }
        }

        public async Task<IEnumerable<Comment_Servies>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblCommentServies.ToListAsync();
        }

        public async Task<Comment_Servies?> GetByIDAsync(string EntityId)
        {
            return await _context.TblCommentServies.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Comment_Servies> UpdateEntityAsync(Comment_Servies Entity)
        {
            Comment_Servies? commentServies = await _context.TblCommentServies.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (commentServies != null)
            {
                _context.TblCommentServies.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Comment_Servies();
            }
        }
    }
}

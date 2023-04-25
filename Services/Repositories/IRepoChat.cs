namespace liaqati_master.Services.Repositories
{
    public class IRepoChat
    {
        private readonly LiaqatiDBContext _context;

        public IRepoChat(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Chat> AddEntityAsync(Chat Entity)
        {
            await _context.TblChat.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Chat> DeleteEntityAsync(Chat Entity)
        {
            if (Entity != null)
            {
                _context.TblChat.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Chat();
            }
        }

        public async Task<Chat> DeleteEntityAsync(string Id)
        {
            var chat = await _context.TblChat.FindAsync(Id);
            if (chat != null)
            {
                _context.TblChat.Remove(chat);
                await SaveAsync();
                return chat;
            }
            else
            {
                return new Chat();
            }
        }

        public async Task<IEnumerable<Chat>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblChat.ToListAsync();
        }

        public async Task<Chat?> GetByIDAsync(string EntityId)
        {
            return await _context.TblChat.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Chat> UpdateEntityAsync(Chat Entity)
        {
            Chat? chat = await _context.TblChat.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (chat != null)
            {
                _context.TblChat.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Chat();
            }
        }
    }
}


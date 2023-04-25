namespace liaqati_master.Services.Repositories
{
    public class IRepoChatUser
    {
        private readonly LiaqatiDBContext _context;

        public IRepoChatUser(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<ChatUser> AddEntityAsync(ChatUser Entity)
        {
            await _context.TblChatUser.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<ChatUser> DeleteEntityAsync(ChatUser Entity)
        {
            if (Entity != null)
            {
                _context.TblChatUser.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new ChatUser();
            }
        }

        public async Task<ChatUser> DeleteEntityAsync(string Id)
        {
            var chatUser = await _context.TblChatUser.FindAsync(Id);
            if (chatUser != null)
            {
                _context.TblChatUser.Remove(chatUser);
                await SaveAsync();
                return chatUser;
            }
            else
            {
                return new ChatUser();
            }
        }

        public async Task<IEnumerable<ChatUser>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblChatUser.ToListAsync();
        }

        public async Task<ChatUser?> GetByIDAsync(string EntityId)
        {
            return await _context.TblChatUser.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<ChatUser> UpdateEntityAsync(ChatUser Entity)
        {
            ChatUser? chatUser = await _context.TblChatUser.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (chatUser != null)
            {
                _context.TblChatUser.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new ChatUser();
            }
        }
    }
}


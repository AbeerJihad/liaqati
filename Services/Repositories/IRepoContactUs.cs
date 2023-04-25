namespace liaqati_master.Services.Repositories
{
    public class IRepoContactUs
    {
        private readonly LiaqatiDBContext _context;

        public IRepoContactUs(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<ContactUs> AddEntityAsync(ContactUs Entity)
        {
            await _context.TblContactUs.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<ContactUs> DeleteEntityAsync(ContactUs Entity)
        {
            if (Entity != null)
            {
                _context.TblContactUs.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new ContactUs();
            }
        }

        public async Task<ContactUs> DeleteEntityAsync(string Id)
        {
            var contactUs = await _context.TblContactUs.FindAsync(Id);
            if (contactUs != null)
            {
                _context.TblContactUs.Remove(contactUs);
                await SaveAsync();
                return contactUs;
            }
            else
            {
                return new ContactUs();
            }
        }

        public async Task<IEnumerable<ContactUs>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblContactUs.ToListAsync();
        }

        public async Task<ContactUs?> GetByIDAsync(string EntityId)
        {
            return await _context.TblContactUs.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<ContactUs> UpdateEntityAsync(ContactUs Entity)
        {
            ContactUs? article = await _context.TblContactUs.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (article != null)
            {
                _context.TblContactUs.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new ContactUs();
            }
        }
    }
}

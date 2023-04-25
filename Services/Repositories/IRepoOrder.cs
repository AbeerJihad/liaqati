namespace liaqati_master.Services.Repositories
{
    public class IRepoOrder
    {
        private readonly LiaqatiDBContext _context;

        public IRepoOrder(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Order> AddEntityAsync(Order Entity)
        {
            await _context.TblOrder.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Order> DeleteEntityAsync(Order Entity)
        {
            if (Entity != null)
            {
                _context.TblOrder.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Order();
            }
        }

        public async Task<Order> DeleteEntityAsync(string Id)
        {
            var order = await _context.TblOrder.FindAsync(Id);
            if (order != null)
            {
                _context.TblOrder.Remove(order);
                await SaveAsync();
                return order;
            }
            else
            {
                return new Order();
            }
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblOrder.ToListAsync();
        }

        public async Task<Order?> GetByIDAsync(string EntityId)
        {
            return await _context.TblOrder.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Order> UpdateEntityAsync(Order Entity)
        {
            Order? order = await _context.TblOrder.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (order != null)
            {
                _context.TblOrder.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Order();
            }
        }
    }
}

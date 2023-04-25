namespace liaqati_master.Services.Repositories
{
    public class IRepoCoupon
    {
        private readonly LiaqatiDBContext _context;

        public IRepoCoupon(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Coupon> AddEntityAsync(Coupon Entity)
        {
            await _context.TblCoupon.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Coupon> DeleteEntityAsync(Coupon Entity)
        {
            if (Entity != null)
            {
                _context.TblCoupon.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Coupon();
            }
        }

        public async Task<Coupon> DeleteEntityAsync(string Id)
        {
            var coupon = await _context.TblCoupon.FindAsync(Id);
            if (coupon != null)
            {
                _context.TblCoupon.Remove(coupon);
                await SaveAsync();
                return coupon;
            }
            else
            {
                return new Coupon();
            }
        }

        public async Task<IEnumerable<Coupon>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblCoupon.ToListAsync();
        }

        public async Task<Coupon?> GetByIDAsync(string EntityId)
        {
            return await _context.TblCoupon.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Coupon> UpdateEntityAsync(Coupon Entity)
        {
            Coupon? chat = await _context.TblCoupon.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (chat != null)
            {
                _context.TblCoupon.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Coupon();
            }
        }
    }
}

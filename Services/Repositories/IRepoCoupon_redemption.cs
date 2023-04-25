namespace liaqati_master.Services.Repositories
{
    public class IRepoCoupon_redemption
    {
        private readonly LiaqatiDBContext _context;

        public IRepoCoupon_redemption(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Coupon_redemption> AddEntityAsync(Coupon_redemption Entity)
        {
            await _context.TblCoupon_redemption.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Coupon_redemption> DeleteEntityAsync(Coupon_redemption Entity)
        {
            if (Entity != null)
            {
                _context.TblCoupon_redemption.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Coupon_redemption();
            }
        }

        public async Task<Coupon_redemption> DeleteEntityAsync(string Id)
        {
            var coupon_redemption = await _context.TblCoupon_redemption.FindAsync(Id);
            if (coupon_redemption != null)
            {
                _context.TblCoupon_redemption.Remove(coupon_redemption);
                await SaveAsync();
                return coupon_redemption;
            }
            else
            {
                return new Coupon_redemption();
            }
        }

        public async Task<IEnumerable<Coupon_redemption>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblCoupon_redemption.ToListAsync();
        }

        public async Task<Coupon_redemption?> GetByIDAsync(string EntityId)
        {
            return await _context.TblCoupon_redemption.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Coupon_redemption> UpdateEntityAsync(Coupon_redemption Entity)
        {
            Coupon_redemption? coupon_redemption = await _context.TblCoupon_redemption.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (coupon_redemption != null)
            {
                _context.TblCoupon_redemption.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Coupon_redemption();
            }
        }
    }
}


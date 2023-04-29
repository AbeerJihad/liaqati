namespace liaqati_master.Services.Repositories
{
    public class IRepoMealPlans
    {
        private readonly LiaqatiDBContext _context;

        public IRepoMealPlans(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<MealPlans> AddEntityAsync(MealPlans Entity)
        {
            await _context.TblMealPlans.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<MealPlans> DeleteEntityAsync(MealPlans Entity)
        {
            if (Entity != null)
            {
                _context.TblMealPlans.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new MealPlans();
            }
        }

        public async Task<MealPlans> DeleteEntityAsync(string Id)
        {
            var MealPlans = await _context.TblMealPlans.FindAsync(Id);
            if (MealPlans != null)
            {
                _context.TblMealPlans.Remove(MealPlans);
                await SaveAsync();
                return MealPlans;
            }
            else
            {
                return new MealPlans();
            }
        }

        public async Task<IEnumerable<MealPlans>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblMealPlans.ToListAsync();
        }

        public async Task<MealPlans?> GetByIDAsync(string EntityId)
        {
            return await _context.TblMealPlans.FirstOrDefaultAsync(a => a.Id == EntityId);
        }

        public async Task SaveAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public async Task<MealPlans> UpdateEntityAsync(MealPlans Entity)
        {
            MealPlans? MealPlans = await _context.TblMealPlans.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (MealPlans != null)
            {
                _context.TblMealPlans.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new MealPlans();
            }
        }
    }
}

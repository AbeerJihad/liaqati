namespace liaqati_master.Services.Repositories
{
    public class IRepoMeal_Healthy
    {
        private readonly LiaqatiDBContext _context;

        public IRepoMeal_Healthy(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Meal_Healthy> AddEntityAsync(Meal_Healthy Entity)
        {
            await _context.TblMeal_Healthy.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Meal_Healthy> DeleteEntityAsync(Meal_Healthy Entity)
        {
            if (Entity != null)
            {
                _context.TblMeal_Healthy.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Meal_Healthy();
            }
        }

        public async Task<Meal_Healthy> DeleteEntityAsync(string Id)
        {
            var healthyRecipe = await _context.TblMeal_Healthy.FindAsync(Id);
            if (healthyRecipe != null)
            {
                _context.TblMeal_Healthy.Remove(healthyRecipe);
                await SaveAsync();
                return healthyRecipe;
            }
            else
            {
                return new Meal_Healthy();
            }
        }

        public async Task<IEnumerable<Meal_Healthy>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblMeal_Healthy.ToListAsync();
        }

        public async Task<Meal_Healthy?> GetByIDAsync(string EntityId)
        {
            return await _context.TblMeal_Healthy.FirstOrDefaultAsync(a => a.Id == EntityId);
        }
        public async Task<IEnumerable<Meal_Healthy>?> GetByMealPlansIDAsync(string EntityId)
        {
            return await _context.TblMeal_Healthy.Where(a => a.MealPlansId == EntityId).ToListAsync();
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

        public async Task<Meal_Healthy> UpdateEntityAsync(Meal_Healthy Entity)
        {
            Meal_Healthy? healthyRecipe = await _context.TblMeal_Healthy.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (healthyRecipe != null)
            {
                _context.TblMeal_Healthy.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Meal_Healthy();
            }
        }

    }
}


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

        public async Task<QueryPageResult<MealPlans>> SearchMealPlan(MealPlansQueryParamters Parameters)
        {
            IQueryable<MealPlans> MealPlans = (await GetAllAsync()).AsQueryable();
            if (Parameters.CategoryId != null)
            {
                MealPlans = MealPlans.Where(p => p.Services.CategoryId == Parameters.CategoryId);
            }
            if (Parameters.MinPrice != null)
            {
                MealPlans = MealPlans.Where(p => p.Services.Price >= Parameters.MinPrice);
            }
            if (Parameters.MaxPrice != null)
            {
                MealPlans = MealPlans.Where(p => p.Services.Price <= Parameters.MaxPrice);
            }
            if (!string.IsNullOrEmpty(Parameters.SearchTearm))
            {
                MealPlans = MealPlans.Where(p => p.Services.Title.ToLower().Contains(Parameters.SearchTearm.ToLower()));
            }
            if (!string.IsNullOrEmpty(Parameters.Title))
            {
                MealPlans = MealPlans.Where(p => p.Services.Title.ToLower().Contains(Parameters.Title.ToLower()));
            }
            if (Parameters.DietaryType is not null)

                if (Parameters.DietaryType.Count != 0)
                {
                    List<MealPlans> MealPlan = new();
                    for (int i = 0; i < Parameters.DietaryType.Count; i++)
                    {
                        if (Parameters.DietaryType[i] is not null)
                            MealPlan.AddRange(collection: MealPlans.Where(p => p.DietaryType.ToLower().Contains(Parameters.DietaryType[i])));
                    }

                    MealPlans = MealPlan.AsQueryable();

                }

            if (Parameters.MealType is not null)

                if (Parameters.MealType.Count != 0)
                {
                    List<MealPlans> MealPlan = new();
                    for (int i = 0; i < Parameters.MealType.Count; i++)
                    {
                        if (Parameters.MealType[i] is not null)
                            MealPlan.AddRange(collection: MealPlans.Where(p => p.MealType.ToLower().Contains(Parameters.MealType[i])));
                    }

                    MealPlans = MealPlan.AsQueryable();

                }

            if (!string.IsNullOrEmpty(Parameters.SortBy))
            {
                //if (Parameters.SortOrder.ToLower() == "asc")
                //{
                //  MealPlans = MealPlans.OrderByCustom(Parameters.SortBy, Parameters.SortOrder);
                //}
                //else if (Parameters.SortOrder.ToLower() == "desc")
                //{

                //}
            }
            QueryPageResult<MealPlans> queryPageResult = CommonMethods.GetPageResult(MealPlans, Parameters);
            return queryPageResult;

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

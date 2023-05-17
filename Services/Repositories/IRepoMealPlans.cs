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
            List<AppliedFilters>? ListOfSelectedFilters = new();

            if (Parameters.CategoryId != null)
            {
                MealPlans = MealPlans.Where(p => p.Services != null && p.Services.CategoryId == Parameters.CategoryId);
                ListOfSelectedFilters.Add(new AppliedFilters(nameof(Parameters.CategoryId), Parameters.CategoryId.ToString() ?? ""));

            }
            if (Parameters.MinPrice != null)
            {
                MealPlans = MealPlans.Where(p => p.Services != null && p.Services.Price >= Parameters.MinPrice);
                ListOfSelectedFilters.Add(new AppliedFilters(nameof(Parameters.MinPrice), Parameters.MinPrice.ToString() ?? ""));

            }
            if (Parameters.MaxPrice != null)
            {
                MealPlans = MealPlans.Where(p => p.Services != null && p.Services.Price <= Parameters.MaxPrice);
                ListOfSelectedFilters.Add(new AppliedFilters(nameof(Parameters.MaxPrice), Parameters.MaxPrice.ToString() ?? ""));

            }
            if (!string.IsNullOrEmpty(Parameters.SearchTearm))
            {
                MealPlans = MealPlans.Where(p => p.Services != null && p.Services.Title != null && p.Services.Title.ToLower().Contains(Parameters.SearchTearm.ToLower()));

                ListOfSelectedFilters.Add(new AppliedFilters(nameof(Parameters.SearchTearm), Parameters.SearchTearm.ToString() ?? ""));
            }
            if (!string.IsNullOrEmpty(Parameters.Title))
            {
                MealPlans = MealPlans.Where(p => p.Services != null && p.Services.Title != null && p.Services.Title.ToLower().Contains(Parameters.Title.ToLower()));
                ListOfSelectedFilters.Add(new AppliedFilters(nameof(Parameters.Title), Parameters.Title.ToString() ?? ""));

            }
            if (Parameters.DietaryType is not null)
                if (Parameters.DietaryType.Count != 0)
                {
                    List<MealPlans> MealPlan = new();
                    foreach (var item in Parameters.DietaryType)
                    {
                        if (item is not null)
                        {
                            MealPlan.AddRange(collection: MealPlans.Where(p => p.DietaryType != null && p.DietaryType.ToLower().Contains(item)));
                            ListOfSelectedFilters.Add(new AppliedFilters(nameof(Parameters.DietaryType), item.ToString() ?? ""));
                        }
                    }
                    MealPlans = MealPlan.AsQueryable();
                }

            if (Parameters.MealType is not null)
                if (Parameters.MealType.Count != 0)
                {
                    List<MealPlans> MealPlan = new();
                    foreach (var item in Parameters.MealType)
                    {
                        if (item is not null)
                        {
                            MealPlan.AddRange(collection: MealPlans.Where(p => p.MealType != null && p.MealType.ToLower().Contains(item)));
                            ListOfSelectedFilters.Add(new AppliedFilters(nameof(Parameters.MealType), item.ToString() ?? ""));
                        }
                    }
                    MealPlans = MealPlan.AsQueryable();
                }

            if (!string.IsNullOrEmpty(Parameters.SortBy))
            {
                if (Parameters.SortBy.Equals(nameof(Service.Title), StringComparison.OrdinalIgnoreCase))
                {
                    if (Parameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        MealPlans = MealPlans.OrderBy(p => p.Services!.Title);
                    else if (Parameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        MealPlans = MealPlans.OrderByDescending(p => p.Services!.Title);

                }
                else if (Parameters.SortBy.Equals(nameof(Service.Price), StringComparison.OrdinalIgnoreCase))
                {
                    if (Parameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        MealPlans = MealPlans.OrderBy(p => p.Services!.Price);
                    else if (Parameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        MealPlans = MealPlans.OrderByDescending(p => p.Services!.Price);

                }
                else if (Parameters.SortBy.Equals(nameof(Models.MealPlans.MealType), StringComparison.OrdinalIgnoreCase))
                {
                    if (Parameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        MealPlans = MealPlans.OrderBy(p => p.MealType);
                    else if (Parameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        MealPlans = MealPlans.OrderByDescending(p => p.MealType);
                }
                else if (Parameters.SortBy.Equals(nameof(Models.MealPlans.DietaryType), StringComparison.OrdinalIgnoreCase))
                {

                    if (Parameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        MealPlans = MealPlans.OrderBy(p => p.DietaryType);
                    else if (Parameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        MealPlans = MealPlans.OrderByDescending(p => p.DietaryType);

                }
            }

            List<int> MealTypeCounters = new();
            List<string> MealType = Database.GetListOfMealType().Select(b => b.Value).ToList();
            foreach (var item in MealType)
            {
                if (item is not null)
                {
                    MealTypeCounters.Add(MealPlans.Count(ex => ex.MealType != null && ex.MealType.ToLower().Trim().Contains(item.ToLower().Trim())));
                }

            }
            List<int> DietaryTypeCounters = new();
            List<string> DietaryType = Database.GetListOfDietaryType().Select(b => b.Value).ToList();
            foreach (var item in DietaryType)
            {
                if (item is not null)
                {
                    DietaryTypeCounters.Add(MealPlans.Count(ex => ex.DietaryType != null && ex.DietaryType.ToString()!.ToLower().Trim().Contains(item.ToLower().Trim())));

                }
            }
            QueryPageResult<MealPlans> queryPageResult = CommonMethods.GetPageResult(MealPlans, Parameters);
            MealPlanQueryPageResult mealPlanQueryPageResult = new()
            {
                DietaryTypeCounters = DietaryTypeCounters,
                ListOfData = MealPlans,
                NextPage = queryPageResult.NextPage,
                TotalCount = queryPageResult.TotalCount,
                TotalPages = queryPageResult.TotalPages,
                PreviousPage = queryPageResult.PreviousPage,
                LastRowOnPage = queryPageResult.LastRowOnPage,
                FirstRowOnPage = queryPageResult.FirstRowOnPage,
                ListOfSelectedFilters = ListOfSelectedFilters
            };
            return mealPlanQueryPageResult;

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

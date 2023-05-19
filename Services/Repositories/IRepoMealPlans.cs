using System.Security.Claims;

namespace liaqati_master.Services.Repositories
{
    public class IRepoMealPlans
    {
        private readonly LiaqatiDBContext _context;
        readonly IRepoFavorite _IRepoFavorite;
        readonly IHttpContextAccessor _HttpContextAccessor;
        public IRepoMealPlans(LiaqatiDBContext context, IRepoFavorite iRepoFavorite, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _IRepoFavorite = iRepoFavorite;
            _HttpContextAccessor = httpContextAccessor;
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
        public List<Meal_Healthy> GetMultiMeal_Healthy(string id, int week, int day)
        {

            List<Meal_Healthy> list = _context.TblMeal_Healthy.ToList();
            List<Meal_Healthy> list2 = new List<Meal_Healthy>();


            foreach (Meal_Healthy program in list)
            {

                if (program.MealPlansId == id && program.Day == day && program.Week == week)
                {
                    list2.Add(program);
                }

            }




            return list2;
        }
        public async Task<QueryPageResult<MealPlanVM>> SearchMealPlan(MealPlansQueryParamters Parameters)
        {
            IQueryable<MealPlanVM> MealPlans = (await GetAllAsync()).Select(p =>
               new MealPlanVM()
               {
                   CategoryName = p.Services?.Category?.Name,
                   Id = p.Id,
                   Images = p.Services?.Files?.Select(p => p.Path)?.ToList(),
                   Image = p.Services?.Image,
                   CategoryId = p.Services?.CategoryId,
                   Length = p.Length,
                   DietaryType = p.DietaryType,
                   MealType = p.MealType,
                   Price = p.Services?.Price,
                   Title = p.Services?.Title,
                   IsFavorite = 0,
                   shortDescription = p.Services?.ShortDescription,
               }).AsQueryable();
            List<AppliedFilters>? ListOfSelectedFilters = new();

            List<Favorite>? list = new();
            List<MealPlanVM>? MealPlans2 = new();
            List<string?>? list2 = new();
            if (_HttpContextAccessor.HttpContext is not null)
            {
                var user = _HttpContextAccessor.HttpContext.User;
                MealPlans2 = MealPlans.ToList();

                if (user is null)
                {

                    foreach (var item in MealPlans2)
                    {
                        item.IsFavorite = 0;
                    }
                }
                else
                {
                    list = await _IRepoFavorite.GetByUserIDAsync(user.FindFirstValue(ClaimTypes.NameIdentifier));
                    if (list is not null)
                    {
                        list2 = list.Where(p => p.Type == "نظام غذائي").Select(s => s.ServicesId).ToList();
                    }
                    foreach (var item in MealPlans2)
                    {
                        if (list2.Contains(item.Id))
                            item.IsFavorite = 2;
                        else if (!list2.Contains(item.Id))
                            item.IsFavorite = 1;
                    }
                }
                MealPlans = MealPlans2.AsQueryable();
            }
            if (Parameters.CategoryId != null)
            {
                MealPlans = MealPlans.Where(p => p.CategoryId == Parameters.CategoryId);
                ListOfSelectedFilters.Add(new AppliedFilters(nameof(Parameters.CategoryId), Parameters.CategoryId.ToString() ?? ""));

            }
            if (Parameters.MinPrice != null)
            {
                MealPlans = MealPlans.Where(p => p.Price >= Parameters.MinPrice);
                ListOfSelectedFilters.Add(new AppliedFilters(nameof(Parameters.MinPrice), Parameters.MinPrice.ToString() ?? ""));

            }
            if (Parameters.MaxPrice != null)
            {
                MealPlans = MealPlans.Where(p => p.Price <= Parameters.MaxPrice);
                ListOfSelectedFilters.Add(new AppliedFilters(nameof(Parameters.MaxPrice), Parameters.MaxPrice.ToString() ?? ""));

            }
            if (!string.IsNullOrEmpty(Parameters.SearchTearm))
            {
                MealPlans = MealPlans.Where(p => p.Title != null && p.Title.ToLower().Contains(Parameters.SearchTearm.ToLower()));

                ListOfSelectedFilters.Add(new AppliedFilters(nameof(Parameters.SearchTearm), Parameters.SearchTearm.ToString() ?? ""));
            }
            if (!string.IsNullOrEmpty(Parameters.Title))
            {
                MealPlans = MealPlans.Where(p => p.Title != null && p.Title.ToLower().Contains(Parameters.Title.ToLower()));
                ListOfSelectedFilters.Add(new AppliedFilters(nameof(Parameters.Title), Parameters.Title.ToString() ?? ""));

            }
            if (Parameters.DietaryType is not null)
                if (Parameters.DietaryType.Count != 0)
                {
                    List<MealPlanVM> MealPlan = new();
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
                    List<MealPlanVM> MealPlan = new();
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
                        MealPlans = MealPlans.OrderBy(p => p.Title);
                    else if (Parameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        MealPlans = MealPlans.OrderByDescending(p => p.Title);

                }
                else if (Parameters.SortBy.Equals(nameof(Service.Price), StringComparison.OrdinalIgnoreCase))
                {
                    if (Parameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        MealPlans = MealPlans.OrderBy(p => p.Price);
                    else if (Parameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        MealPlans = MealPlans.OrderByDescending(p => p.Price);

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
            QueryPageResult<MealPlanVM> queryPageResult = CommonMethods.GetPageResult(MealPlans, Parameters);
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

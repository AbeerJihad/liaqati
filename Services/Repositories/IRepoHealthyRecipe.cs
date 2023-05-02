namespace liaqati_master.Services.Repositories
{
    public class IRepoHealthyRecipe
    {
        private readonly LiaqatiDBContext _context;

        public IRepoHealthyRecipe(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<HealthyRecipe> AddEntityAsync(HealthyRecipe Entity)
        {
            await _context.TblHealthyRecipe.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<HealthyRecipe> DeleteEntityAsync(HealthyRecipe Entity)
        {
            if (Entity != null)
            {
                _context.TblHealthyRecipe.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new HealthyRecipe();
            }
        }

        public async Task<HealthyRecipe> DeleteEntityAsync(string Id)
        {
            var healthyRecipe = await _context.TblHealthyRecipe.FindAsync(Id);
            if (healthyRecipe != null)
            {
                _context.TblHealthyRecipe.Remove(healthyRecipe);
                await SaveAsync();
                return healthyRecipe;
            }
            else
            {
                return new HealthyRecipe();
            }
        }

        public async Task<IEnumerable<HealthyRecipe>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblHealthyRecipe.ToListAsync();
        }

        public async Task<HealthyRecipe?> GetByIDAsync(string EntityId)
        {
            return await _context.TblHealthyRecipe.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<HealthyRecipe> UpdateEntityAsync(HealthyRecipe Entity)
        {
            HealthyRecipe? healthyRecipe = await _context.TblHealthyRecipe.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (healthyRecipe != null)
            {
                _context.TblHealthyRecipe.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new HealthyRecipe();
            }
        }
        public async Task<HealthyRecipeQueryPageResult> SearchHealty(HealthyRecipeQueryParamters HealthyRecipeQueryParamters)
        {
            IQueryable<HealthyRecipe> HealthyRecipes = (await GetAllAsync()).AsQueryable();
            if (HealthyRecipeQueryParamters.MinCalories != null)
            {
                HealthyRecipes = HealthyRecipes.Where(p => p.Calories >= HealthyRecipeQueryParamters.MinCalories);
            }
            if (HealthyRecipeQueryParamters.MaxCalories != null)
            {
                HealthyRecipes = HealthyRecipes.Where(p => p.Calories <= HealthyRecipeQueryParamters.MaxCalories);
            }
            if (HealthyRecipeQueryParamters.MinPrepTime != null)
            {
                HealthyRecipes = HealthyRecipes.Where(p => p.PrepTime >= HealthyRecipeQueryParamters.MinPrepTime);
            }
            if (HealthyRecipeQueryParamters.MaxPrepTime != null)
            {
                HealthyRecipes = HealthyRecipes.Where(p => p.PrepTime <= HealthyRecipeQueryParamters.MaxPrepTime);
            }
            if (!string.IsNullOrEmpty(HealthyRecipeQueryParamters.SearchTearm))
            {
                HealthyRecipes = HealthyRecipes.Where(p =>
                    p.Title.ToLower().Contains(HealthyRecipeQueryParamters.SearchTearm.ToLower()) ||
                    p.ShortDescription.ToLower().Contains(HealthyRecipeQueryParamters.SearchTearm.ToLower())
                );
            }
            List<HealthyRecipe> healthyRecipes = new();

            if (HealthyRecipeQueryParamters.MealType != null)
                if (HealthyRecipeQueryParamters.MealType.Count != 0)
                {
                    for (int i = 0; i < HealthyRecipeQueryParamters.MealType.Count; i++)
                    {
                        healthyRecipes.AddRange(HealthyRecipes.Where(p => p.MealType.ToLower().Contains(HealthyRecipeQueryParamters.MealType[i].ToLower())));

                    }
                    HealthyRecipes = healthyRecipes.AsQueryable();

                }

            healthyRecipes.Clear();

            if (HealthyRecipeQueryParamters.DietaryType != null)
                if (HealthyRecipeQueryParamters.DietaryType.Count != 0)
                {
                    for (int i = 0; i < HealthyRecipeQueryParamters.DietaryType.Count; i++)
                    {
                        healthyRecipes.AddRange(HealthyRecipes.Where(p => p.DietaryType.ToLower().Contains(HealthyRecipeQueryParamters.DietaryType[i].ToLower())));
                    }
                    HealthyRecipes = healthyRecipes.AsQueryable();

                }



            if (!string.IsNullOrEmpty(HealthyRecipeQueryParamters.SortBy))
            {
                if (HealthyRecipeQueryParamters.SortBy.Equals("RateId", StringComparison.OrdinalIgnoreCase))
                {
                    // if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                    HealthyRecipes = HealthyRecipes.OrderByDescending(p => p.RatePercentage);
                    //else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                    //    HealthyRecipes = HealthyRecipes.OrderByDescending(p => p.RateId);

                }
                if (HealthyRecipeQueryParamters.SortBy.Equals("exerciseDate", StringComparison.OrdinalIgnoreCase))
                {
                    // if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                    HealthyRecipes = HealthyRecipes.OrderByDescending(p => p.CreatedDate);
                    //else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                    //    HealthyRecipes = HealthyRecipes.OrderByDescending(p => p.RateId);

                }
            }

            List<int> MealTypeCounters = new();
            List<string> MealType = Database.GetListOfMealType().Select(b => b.Value).ToList();
            for (int i = 0; i < MealType.Count; i++)
            {
                MealTypeCounters.Add(HealthyRecipes.Count(ex => ex.MealType.Contains(MealType[i])));

            }
            List<int> DietaryTypeCounters = new();
            List<string> DietaryType = Database.GetListOfDietaryType().Select(b => b.Value).ToList();
            for (int i = 0; i < DietaryType.Count; i++)
            {
                DietaryTypeCounters.Add(HealthyRecipes.Count(ex => ex.DietaryType.Contains(DietaryType[i])));

            }

            QueryPageResult<HealthyRecipe> qpres = CommonMethods.GetPageResult(HealthyRecipes, HealthyRecipeQueryParamters);
            HealthyRecipeQueryPageResult exqpres = new()
            {
                ListOfData = qpres.ListOfData,
                NextPage = qpres.NextPage,
                TotalCount = qpres.TotalCount,
                TotalPages = qpres.TotalPages,
                PreviousPage = qpres.PreviousPage,
                LastRowOnPage = qpres.LastRowOnPage,
                FirstRowOnPage = qpres.FirstRowOnPage,
                DietaryTypeCounters = DietaryTypeCounters,
                MealTypeCounters = MealTypeCounters,


            };




            return exqpres;
        }

    }
}


namespace liaqati_master.Services.Repositories
{
    public class IRepoCategory
    {
        private readonly LiaqatiDBContext _context;

        public IRepoCategory(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Category> AddEntityAsync(Category Entity)
        {
            await _context.TblCategory.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Category> DeleteEntityAsync(Category Entity)
        {
            if (Entity != null)
            {
                _context.TblCategory.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Category();
            }
        }

        public async Task<Category> DeleteEntityAsync(string Id)
        {
            var category = await _context.TblCategory.FindAsync(Id);
            if (category != null)
            {
                _context.TblCategory.Remove(category);
                await SaveAsync();
                return category;
            }
            else
            {
                return new Category();
            }
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblCategory.ToListAsync();
        }

        public async Task<Category?> GetByIDAsync(string EntityId)
        {
            return await _context.TblCategory.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Category> UpdateEntityAsync(Category Entity)
        {
            Category? category = await _context.TblCategory.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (category != null)
            {
                _context.TblCategory.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Category();
            }
        }

        public async Task<QueryPageResult<Category>> SearchCategory(CategoriesQueryParamters Parameters)

        {
            IQueryable<Category> categories = (await GetAllAsync()).AsQueryable();
            if (Parameters.catName != null)
            {
                categories = categories.Where(x => x.Name.Contains(Parameters.catName));
            }
            if (Parameters.catDescription != null)
            {
                categories = categories.Where(x => x.Description.ToLower().Contains(Parameters.catDescription.ToLower()));
            }
            if (Parameters.catTarget != null && Parameters.catTarget != "-1")
            {
                categories = categories.Where(x => x.Target == Parameters.catTarget);
            }

            QueryPageResult<Category> queryPageResult = CommonMethods.GetPageResult(categories, Parameters);
            return queryPageResult;
        }
    }
}


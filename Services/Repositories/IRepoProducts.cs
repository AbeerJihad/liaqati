namespace liaqati_master.Services.Repositories
{

    public class IRepoProducts
    {
        private readonly LiaqatiDBContext _context;

        public IRepoProducts(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Product> AddEntityAsync(Product Entity)
        {
            await _context.TblProducts.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Product> DeleteEntityAsync(Product Entity)
        {
            if (Entity != null)
            {
                _context.TblProducts.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Product();
            }
        }

        public async Task<Product> DeleteEntityAsync(string Id)
        {
            var product = await _context.TblProducts.FindAsync(Id);
            if (product != null)
            {
                _context.TblProducts.Remove(product);
                await SaveAsync();
                return product;
            }
            else
            {
                return new Product();
            }
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblProducts.ToListAsync();
        }

        public async Task<Product?> GetByIDAsync(string EntityId)
        {
            return await _context.TblProducts.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Product> UpdateEntityAsync(Product Entity)
        {
            Product? product = await _context.TblProducts.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (product != null)
            {
                _context.TblProducts.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Product();
            }
        }
        public async Task<QueryPageResult<Product>> SearchProduct(ProductQueryParamters Parameters)
        {
            IQueryable<Product> products = (await GetAllAsync()).AsQueryable();

            if (Parameters.CategoryId != null)
            {
                products = products.Where(p => p.Services.CategoryId == Parameters.CategoryId);
            }

            if (Parameters.MinPrice != null)
            {
                products = products.Where(p => p.Services.Price >= Parameters.MinPrice);
            }

            if (Parameters.MaxPrice != null)
            {
                products = products.Where(p => p.Services.Price <= Parameters.MaxPrice);
            }

            if (!string.IsNullOrEmpty(Parameters.SearchTearm))
            {
                products = products.Where(p =>
                    p.Services.Title.ToLower().Contains(Parameters.SearchTearm.ToLower())
                 );
            }

            if (!string.IsNullOrEmpty(Parameters.Title))
            {
                products = products.Where(p => p.Services.Title.ToLower() == Parameters.Title.ToLower());
            }


            if (!string.IsNullOrEmpty(Parameters.SortBy))
            {
                if (Parameters.SortBy.Equals("MinPrice", StringComparison.OrdinalIgnoreCase))
                {
                    products = products.OrderBy(p => p.Services.Price);

                }
                else if (Parameters.SortBy.Equals("MaxPrice", StringComparison.OrdinalIgnoreCase))
                {
                    products = products.OrderByDescending(p => p.Services.Price);

                }
            }
            QueryPageResult<Product> queryPageResult = CommonMethods.GetPageResult(products, Parameters);
            return queryPageResult;

        }
        public async Task<QueryPageResult<ProductVM>> SearchProductVM(ProductQueryParamters Parameters)
        {
            IQueryable<ProductVM> products = (await GetAllAsync()).Select(p =>
            new ProductVM()
            {
                CategoryName = p.Services?.Category?.Name,
                Id = p.Id,
                Images = p.Services?.Files?.Select(p => p.Path)?.ToList(),
                CategoryId = p.Services?.CategoryId,
                Discount = p.Discount,
                PercentageRate = p.Services?.RatePercentage,
                Price = p.Services?.Price,
                Title = p.Services?.Title

            }

            ).AsQueryable();

            if (!string.IsNullOrEmpty(Parameters.CategoryId))
            {
                products = products.Where(p => p.CategoryId == Parameters.CategoryId);
            }

            if (Parameters.MinPrice != null)
            {
                products = products.Where(p => p.Price >= Parameters.MinPrice);
            }

            if (Parameters.MaxPrice != null)
            {
                products = products.Where(p => p.Price <= Parameters.MaxPrice);
            }

            if (!string.IsNullOrEmpty(Parameters.SearchTearm))
            {
                products = products.Where(p => p.Title != null && p.Title.ToLower().Contains(Parameters.SearchTearm.ToLower()));
            }

            if (!string.IsNullOrEmpty(Parameters.Title))
            {
                products = products.Where(p => p.Title != null && p.Title.ToLower().Contains(Parameters.Title.ToLower()));
            }


            if (!string.IsNullOrEmpty(Parameters.SortBy))
            {
                if (Parameters.SortBy.Equals("Price", StringComparison.OrdinalIgnoreCase))
                {
                    products = products.OrderBy(p => p.Price);

                }
                else if (Parameters.SortBy.Equals("Price", StringComparison.OrdinalIgnoreCase))
                {
                    products = products.OrderByDescending(p => p.Price);

                }
            }
            if (!string.IsNullOrEmpty(Parameters.SortBy))
            {
                if (Parameters.SortBy.Equals(nameof(Service.RatePercentage), StringComparison.OrdinalIgnoreCase))
                {
                    if (Parameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        products = products.OrderBy(p => p!.PercentageRate);
                    else if (Parameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        products = products.OrderByDescending(p => p!.PercentageRate);
                }
                else if (Parameters.SortBy.Equals(nameof(Service.Price), StringComparison.OrdinalIgnoreCase))
                {
                    if (Parameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        products = products.OrderBy(p => p!.Price);
                    else if (Parameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        products = products.OrderByDescending(p => p!.Price);
                }

            }

            QueryPageResult<ProductVM> queryPageResult = CommonMethods.GetPageResult(products, Parameters);
            return queryPageResult;

        }
    }
}

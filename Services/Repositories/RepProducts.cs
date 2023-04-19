namespace liaqati_master.Services.Repositories
{

    public class RepProducts
    {
        private readonly LiaqatiDBContext _context;
        public RepProducts(LiaqatiDBContext context)
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

            if (!string.IsNullOrEmpty(Parameters.Tilte))
            {
                products = products.Where(p => p.Services.Title.ToLower() == Parameters.Tilte.ToLower());
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

    }

}


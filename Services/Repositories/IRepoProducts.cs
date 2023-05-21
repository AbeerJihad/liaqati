namespace liaqati_master.Services.Repositories
{

    public class IRepoProducts
    {

        private readonly LiaqatiDBContext _context;
        readonly IHttpContextAccessor _HttpContextAccessor;
        readonly IRepoFavorite _repoFavorite;
        public IRepoProducts(LiaqatiDBContext context, IHttpContextAccessor httpContextAccessor, IRepoFavorite repoFavorite)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            _repoFavorite = repoFavorite;
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
            if (!string.IsNullOrEmpty(Parameters.CategoryId))
            {
                Parameters.CurPage = 1;
                products = products.Where(p => p.Services != null && p.Services.CategoryId == Parameters.CategoryId);
            }

            if (Parameters.MinPrice != null)
            {
                Parameters.CurPage = 1;

                products = products.Where(p => p.Services != null && p.Services.Price >= Parameters.MinPrice);
            }

            if (Parameters.MaxPrice != null)
            {
                Parameters.CurPage = 1;

                products = products.Where(p => p.Services != null && p.Services.Price <= Parameters.MaxPrice);
            }

            if (!string.IsNullOrEmpty(Parameters.SearchTearm))
            {
                Parameters.CurPage = 1;

                products = products.Where(p =>
                      p.Services != null && p.Services.Title != null && p.Services.Title.ToLower().Contains(Parameters.SearchTearm.ToLower())
                 );
            }

            if (!string.IsNullOrEmpty(Parameters.Title))
            {
                Parameters.CurPage = 1;
                products = products.Where(p => p.Services != null && p.Services.Title != null && p.Services.Title.ToLower() == Parameters.Title.ToLower());
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
            List<ProductVM> products2 = new();
            List<AppliedFilters>? ListOfSelectedFilters = new();


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
            Title = p.Services?.Title,
            IsFavorite = 0,
            UserId = p.Services?.UserId,


        }

        ).AsQueryable();

            if (_HttpContextAccessor.HttpContext is not null)
            {


                List<Favorite>? list = new List<Favorite>();
                List<string?>? list2 = new();
                var user = _HttpContextAccessor.HttpContext.User;
                if (user is null)
                {
                    products2 = products.ToList();

                    foreach (var item in products2)
                    {
                        item.IsFavorite = 0;


                    }
                }
                else
                {
                    list = await _repoFavorite.GetByUserIDAsync(user.FindFirstValue(ClaimTypes.NameIdentifier));
                    list2 = list?.Where(p => p.Type == "منتجات").Select(s => s.ServicesId).ToList();

                    products2 = products.ToList();
                    if (list2 is not null)
                    {
                        foreach (var item in products2)
                        {
                            if (list2.Contains(item.Id))
                                item.IsFavorite = 2;
                            else if (!list2.Contains(item.Id))
                                item.IsFavorite = 1;


                        }
                    }


                }

                products = products2.AsQueryable();

            }


            if (!string.IsNullOrEmpty(Parameters.CategoryId))
            {
                Parameters.CurPage = 1;
                products = products.Where(p => p.CategoryId == Parameters.CategoryId);
                ListOfSelectedFilters.Add(new AppliedFilters(propartyName: nameof(Parameters.CategoryId), Parameters.CategoryId.ToString() ?? ""));

            }
            if (!string.IsNullOrEmpty(Parameters.UserId))
            {
                Parameters.CurPage = 1;

                products = products.Where(p => p.UserId == Parameters.UserId);

            }

            if (Parameters.MinPrice != null)
            {
                Parameters.CurPage = 1;

                products = products.Where(p => p.Price >= Parameters.MinPrice);
                ListOfSelectedFilters.Add(new AppliedFilters(propartyName: nameof(Parameters.CategoryId), Parameters.CategoryId.ToString() ?? ""));

            }

            if (Parameters.MaxPrice != null)
            {
                Parameters.CurPage = 1;

                products = products.Where(p => p.Price <= Parameters.MaxPrice);
                ListOfSelectedFilters.Add(new AppliedFilters(propartyName: nameof(Parameters.CategoryId), Parameters.CategoryId.ToString() ?? ""));

            }

            if (!string.IsNullOrEmpty(Parameters.SearchTearm))
            {
                Parameters.CurPage = 1;

                products = products.Where(p => p.Title != null && p.Title.ToLower().Contains(Parameters.SearchTearm.ToLower()));
                ListOfSelectedFilters.Add(new AppliedFilters(propartyName: nameof(Parameters.CategoryId), Parameters.CategoryId.ToString() ?? ""));

            }

            if (!string.IsNullOrEmpty(Parameters.Title))
            {
                Parameters.CurPage = 1;

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

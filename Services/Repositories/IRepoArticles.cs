namespace liaqati_master.Services.Repositories
{
    public class IRepoArticles
    {
        private readonly LiaqatiDBContext _context;

        public IRepoArticles(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Article> AddEntityAsync(Article Entity)
        {
            await _context.TblArticles.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Article> DeleteEntityAsync(Article Entity)
        {
            if (Entity != null)
            {
                _context.TblArticles.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Article();
            }
        }

        public async Task<Article> DeleteEntityAsync(string Id)
        {
            var article = await _context.TblArticles.FindAsync(Id);
            if (article != null)
            {
                _context.TblArticles.Remove(article);
                await SaveAsync();
                return article;
            }
            else
            {
                return new Article();
            }
        }

        public async Task<IEnumerable<Article>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblArticles.ToListAsync();
        }

        public async Task<Article?> GetByIDAsync(string EntityId)
        {
            return await _context.TblArticles.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Article> UpdateEntityAsync(Article Entity)
        {
            Article? article = await _context.TblArticles.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (article != null)
            {
                _context.TblArticles.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Article();
            }
        }

        public async Task<QueryPageResult<Article>> SearchArticles(ArticlesQueryParamters artParameters)
        {
            IQueryable<Article> articles = (await GetAllAsync()).AsQueryable();
            List<AppliedFilters> ListOfSelectedFilters = new();

            if (!string.IsNullOrEmpty(artParameters.UserId))
            {
                artParameters.CurPage = 1;

                articles = articles.Where(p => p.UserId == artParameters.UserId);
            }
            if (!string.IsNullOrEmpty(artParameters.SearchTearm))
            {
                artParameters.CurPage = 1;

                articles = articles.Where(art => art.Title != null && art.Title.ToLower().Trim().Contains(artParameters.SearchTearm.Trim().ToLower())); ;
                ListOfSelectedFilters.Add(new AppliedFilters(nameof(artParameters.SearchTearm), propartyValue: artParameters.SearchTearm));

            }
            if (!string.IsNullOrEmpty(artParameters.Title))
            {
                artParameters.CurPage = 1;
                articles = articles.Where(art => art.Title != null && art.Title.ToLower().Trim().Contains(artParameters.Title.Trim().ToLower()));
                ListOfSelectedFilters.Add(new AppliedFilters(nameof(artParameters.Title), propartyValue: artParameters.Title));
            }
            //if (!string.IsNullOrEmpty(artParameters.SortBy))
            //{
            //    articles = articles.OrderByCustom(artParameters.SortBy, artParameters.SortOrder);
            //}

            if (!string.IsNullOrEmpty(artParameters.SortBy))
            {
                if (artParameters.SortBy.Equals(nameof(Article.Title), StringComparison.OrdinalIgnoreCase))
                {
                    if (artParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        articles = articles.OrderBy(p => p.Title);
                    else if (artParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        articles = articles.OrderByDescending(p => p.Title);

                }
                else if (artParameters.SortBy.Equals(nameof(Article.LikesNumber), StringComparison.OrdinalIgnoreCase))
                {
                    if (artParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        articles = articles.OrderBy(p => p.LikesNumber);
                    else if (artParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        articles = articles.OrderByDescending(p => p.LikesNumber);

                }
                else if (artParameters.SortBy.Equals(nameof(Article.CreatedDate), StringComparison.OrdinalIgnoreCase))
                {
                    if (artParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        articles = articles.OrderBy(p => p.CreatedDate);
                    else if (artParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        articles = articles.OrderByDescending(p => p.CreatedDate);

                }
                else if (artParameters.SortBy.Equals(nameof(Article.avgReading), StringComparison.OrdinalIgnoreCase))
                {
                    if (artParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        articles = articles.OrderBy(p => p.avgReading);
                    else if (artParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        articles = articles.OrderByDescending(p => p.avgReading);

                }
                else if (artParameters.SortBy.Equals(nameof(Article.ViewsNumber), StringComparison.OrdinalIgnoreCase))
                {
                    if (artParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        articles = articles.OrderBy(p => p.ViewsNumber);
                    else if (artParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        articles = articles.OrderByDescending(p => p.ViewsNumber);

                }

            }
            QueryPageResult<Article> qpResult = CommonMethods.GetPageResult(articles, artParameters);
            return qpResult;
        }
    }
}

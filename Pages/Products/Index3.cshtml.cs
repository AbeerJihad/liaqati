namespace liaqati_master.Pages.ProductsPages
{

    [AllowAnonymous]

    public class Index3Model : PageModel
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IRepoProducts _IRepoProducts;

        public Index3Model(UnitOfWork unitOfWork, IRepoProducts IRepoProducts)
        {

            _unitOfWork = unitOfWork;
            _IRepoProducts = IRepoProducts;
        }

        [BindProperty(SupportsGet = true)]
        public ProductQueryParamters Parameters { get; set; }

        public QueryPageResult<Product> queryPageResult { get; set; }


        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value="MinPrice",Text="الأقل سعرا"},
            new SelectListItem(){Value="MaxPrice",Text="الأعلى سعرا"},
            new SelectListItem(){Value="MaxRate",Text="الأغلى تقييما"},
        };

        public async Task OnGetAsync()
        {

            queryPageResult = await _IRepoProducts.SearchProduct(Parameters);

            //return RedirectToPage("./index");
        }
        public async Task OnPostAsync()
        {
            queryPageResult = await _IRepoProducts.SearchProduct(Parameters);

            //return RedirectToPage("./index");
        }
    }
}

/* IQueryable<Product> products = _unitOfWork.ProductsRepository.Get().AsQueryable();

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
                    p.Services.LinkName.ToLower().Contains(Parameters.SearchTearm.ToLower())
                 );
            }

            if (!string.IsNullOrEmpty(Parameters.Tilte))
            {
                products = products.Where(p => p.Services.LinkName.ToLower() == Parameters.Tilte.ToLower());
            }

            //  products = products.OrderByCustom(Parameters.SortBy, Parameters.SortOrder);
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
            queryPageResult = new()
            {
                TotalCount = products.Count()
            };
            queryPageResult.TotalPages = (int)Math.Ceiling(queryPageResult.TotalCount / (double)Parameters.Size);
            if ((Parameters.CurPage - 1) > 0)
                queryPageResult.PreviousPage = Parameters.CurPage - 1;

            if ((Parameters.CurPage + 1) <= queryPageResult.TotalPages)
                queryPageResult.NextPage = Parameters.CurPage + 1;

            if (queryPageResult.TotalCount == 0)
                queryPageResult.FirstRowOnPage = queryPageResult.LastRowOnPage = 0;
            else
            {
                queryPageResult.FirstRowOnPage = (Parameters.CurPage - 1) * Parameters.Size + 1;
                queryPageResult.LastRowOnPage = Math.Min(Parameters.CurPage * Parameters.Size, queryPageResult.TotalCount);
            }

            products = products.Skip(Parameters.Size * (Parameters.CurPage - 1))
                .Take(Parameters.Size);
            queryPageResult.ListOfData = products;
*/
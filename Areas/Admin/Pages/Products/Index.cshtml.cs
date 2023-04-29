namespace liaqati_master.Areas.Admin.Pages.Products
{
    public class IndexProductModel : PageModel
    {
        private readonly IRepoProducts _repoProducts;

        public IndexProductModel(IRepoProducts repoProducts)
        {
            _repoProducts = repoProducts;
        }
        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value="MinPrice",Text="الأقل سعرا"},
            new SelectListItem(){Value="MaxPrice",Text="الأعلى سعرا"},
            new SelectListItem(){Value="MaxRate",Text="الأغلى تقييما"},
        };

        public IList<Product> Products { get; set; }
        [BindProperty(SupportsGet = true)]
        public ProductQueryParamters ProductQueryParamters { get; set; }
        public QueryPageResult<Product> QueryPageResult { get; set; }
        public bool IsGrid { get; set; }
        public async Task OnGetAsync()
        {
            //int grid = 0
            //if (grid == 1)
            //{
            //    IsGrid = true;
            //}
            //else
            //{
            //    IsGrid = false;
            //}

            if (_repoProducts != null)
            {
                ProductQueryParamters.Size = 7;
                QueryPageResult = await _repoProducts.SearchProduct(ProductQueryParamters);
            }
        }
        public async Task OnPost()
        {
            if (_repoProducts != null)
            {
                ProductQueryParamters.Size = 7;
                QueryPageResult = await _repoProducts.SearchProduct(ProductQueryParamters);
            }

            //return RedirectToPage("./index");
        }
    }
}

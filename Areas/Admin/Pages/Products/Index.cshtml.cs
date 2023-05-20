﻿#nullable disable

namespace liaqati_master.Areas.Admin.Pages.Products
{
    public class IndexProductModel : PageModel
    {
        private readonly IRepoProducts _repoProducts;
        private readonly IRepoCategory _repoCategory;
        private readonly SignInManager<User> _signInManager;

        public IndexProductModel(IRepoProducts repoProducts, IRepoCategory repoCategory, SignInManager<User> signInManager)
        {
            _repoProducts = repoProducts;
            _repoCategory = repoCategory;
            _signInManager = signInManager;
        }

        public List<(string, string)> ListOfSelectedFilters { get; set; }

        public IList<Product> Products { get; set; }
        [BindProperty(SupportsGet = true)]
        public ProductQueryParamters ProductQueryParamters { get; set; }
        public QueryPageResult<ProductVM> QueryPageResult { get; set; }
        public bool IsGrid { get; set; }
        public IEnumerable<SelectListItem> lstPageSize { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem(){Value="5", Text="5"},
            new SelectListItem(){Value="10", Text="10"},
            new SelectListItem(){Value="20", Text="20"}
        };
        public IEnumerable<SelectListItem> Titles { get; set; }
        public IEnumerable<SelectListItem> Categoires { get; set; }
        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value=nameof(Product.Services.Title),Text="العنوان"},
            new SelectListItem(){Value=nameof(Product.Services.Price),Text="السعر"},
            new SelectListItem(){Value=nameof(Product.Services.Category.Name),Text="إسم الصنف"},
        };


        public async Task OnGetAsync()
        {
            Categoires = (await _repoCategory.GetAllAsync()).Where(c =>
            c.Target == Database.GetListOfTargets()[nameof(Product)])
                .Select(x => new SelectListItem() { Text = x.Name, Value = x.Id });

            if (!string.IsNullOrEmpty(ProductQueryParamters.CategoryId))
            {
                Titles = (await _repoProducts.GetAllAsync()).Where(c => c.Services != null
                && c.Services.CategoryId == ProductQueryParamters.CategoryId)
                    .Select(x => new SelectListItem() { Text = x.Services?.Title, Value = x.Services?.Title });

            }
            else
            {
                Titles = (await _repoProducts.GetAllAsync()).Select(x => new SelectListItem() { Text = x.Services?.Title, Value = x.Services?.Title });

            }
            if (_repoProducts != null)
            {

                if (_signInManager.IsSignedIn(User))
                {
                    if (User.FindFirstValue(Database.Expert) != null)
                    {
                        var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                        ProductQueryParamters.UserId = userid;
                    }


                }
                QueryPageResult = await _repoProducts.SearchProductVM(ProductQueryParamters);


            }
        }

    }
}

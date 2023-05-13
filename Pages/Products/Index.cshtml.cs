namespace liaqati_master.Pages.Products
{

    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        private readonly IRepoProducts _IRepoProducts;
        private readonly IRepoCategory _IRepoCategory;

        public IndexModel(IRepoProducts IRepoProducts, IRepoCategory iRepoCategory)
        {
            _IRepoProducts = IRepoProducts;
            _IRepoCategory = iRepoCategory;
        }

        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value="MinPrice",Text="الأقل سعرا"},
            new SelectListItem(){Value="MaxPrice",Text="الأعلى سعرا"},
            new SelectListItem(){Value="MaxRatePercentage",Text="الأغلى تقييما"},
            new SelectListItem(){Value="MinRatePercentage",Text="الأقل تقييما"},
        };
        public IEnumerable<SelectListItem>? Categories { get; set; }
        public async Task OnGetAsync()
        {
            Categories = (await _IRepoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Product)]).Select(p => new SelectListItem() { Text = p.Name, Value = p.Id }).Distinct();

        }


    }
}


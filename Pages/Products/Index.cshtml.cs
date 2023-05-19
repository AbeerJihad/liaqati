#nullable disable
using System.Security.Claims;

namespace liaqati_master.Pages.Products
{

    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        private readonly IRepoProducts _IRepoProducts;
        private readonly IRepoFavorite _IRepoFavorite;
        private readonly IRepoCategory _IRepoCategory;

        public IndexModel(IRepoProducts IRepoProducts, IRepoFavorite iRepoFavorite, IRepoCategory iRepoCategory)
        {

            _IRepoProducts = IRepoProducts;
            _IRepoFavorite = iRepoFavorite;
            _IRepoCategory = iRepoCategory;
        }
        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value="MinPrice",Text="الأقل سعرا"},
            new SelectListItem(){Value="MaxPrice",Text="الأعلى سعرا"},
            new SelectListItem(){Value="MaxRatePercentage",Text="الأغلى تقييما"},
            new SelectListItem(){Value="MinRatePercentage",Text="الأقل تقييما"},
        };
        public IEnumerable<SelectListItem> Categories { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<Favorite> Favorites { get; set; }


        public async Task OnGetAsync()
        {
            Categories = (await _IRepoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Product)]).Select(p => new SelectListItem() { Text = p.Name, Value = p.Id }).Distinct();
            var userid = User.FindFirstValue(claimType: ClaimTypes.NameIdentifier);
            if (userid is not null)
            {
                Favorites = ((await _IRepoFavorite.GetByUserIDAsync(userid)).Where(p => p.Type == "منتجات").ToList());
            }
            else Favorites = null;
        }


    }
}


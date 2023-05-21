#nullable disable
using System.Security.Claims;

namespace liaqati_master.Pages.Products
{
    public class ProductDetailsModel : PageModel
    {
        private readonly IRepoProducts _repoProducts;
        private readonly IRepoFavorite _IRepoFavorite;
        private readonly SignInManager<User> _signInManager;

        public ProductDetailsModel(IRepoProducts repoProducts, IRepoFavorite iRepoFavorite, SignInManager<User> signInManager)
        {
            _repoProducts = repoProducts;
            _IRepoFavorite = iRepoFavorite;
            _signInManager = signInManager;
        }
        public ProductVM products { get; set; }
        public async Task<IActionResult> OnGet(string id)
        {
            products = new();
            if (id is null)
            {
                return NotFound();
            }
            var product = (await _repoProducts.GetByIDAsync(id));
            if (product is null)
            {
                return NotFound();
            }
            if (_signInManager.IsSignedIn(User))
            {
                List<Favorite> favorites = await _IRepoFavorite.GetByUserIDAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
                if (favorites is not null && favorites.Count > 0)
                {
                    Favorite favorite = favorites.Where(p => p.ServicesId != null && p.ServicesId == id).FirstOrDefault();
                    if (favorites is null)
                    {

                        products.IsFavorite = 1;
                    }
                    else
                    {
                        products.IsFavorite = 2;

                    }
                }
                else
                {
                    products.IsFavorite = 1;
                }
            }
            else if (!_signInManager.IsSignedIn(User))
            {
                products.IsFavorite = 0;
            }
            products.Id = product.Id;
            products.Discount = product.Discount;
            products.Title = product.Services?.Title;
            products.CategoryId = product.Services?.CategoryId;
            products.CategoryName = product.Services?.Category?.Name;
            products.Description = product.Services?.Description;
            products.Images = product.Services?.Files?.Select(file => file.Path).ToList();
            products.Price = product.Services?.Price;
            products.PercentageRate = product.Services?.RatePercentage;


            return Page();
        }
    }
}

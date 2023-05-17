using liaqati_master.Services.Repositories;
using System.Security.Claims;

namespace liaqati_master.Pages.HealthyRecipes
{
    [AllowAnonymous]

    public class IndexModel : PageModel
    {
      readonly  IRepoFavorite _repoFavorite;
      readonly  IRepoHealthyRecipe _repoHealthyRecipe;

        public IndexModel(IRepoHealthyRecipe repoHealthyRecipe, IRepoFavorite repoFavorite)
        {
            _repoHealthyRecipe = repoHealthyRecipe;
            _repoFavorite= repoFavorite;
        }


        [BindProperty(SupportsGet = true)]
        public List<Favorite> Favorites { get; set; }


        public async Task OnGet()
        {

                var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null)
            {

                Favorites = ((await _repoFavorite.GetByUserIDAsync(userid)).Where(p => p.Type == "وصفات").ToList());

            }
            else Favorites = null;

            ViewData["listFavoritesHealthy"] = Favorites;



        }
    }
}

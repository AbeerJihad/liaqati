using liaqati_master.Services.Repositories;
using System.Security.Claims;

namespace liaqati_master.Pages.Articles
{
    [AllowAnonymous]

    public class IndexModel : PageModel
    {
        readonly IRepoArticles _repoArticles;
        readonly IRepoFavorite _IRepoFavorite;

        public IndexModel(IRepoArticles repoArticles, IRepoFavorite iRepoFavorite)
        {
            _repoArticles = repoArticles;
            _IRepoFavorite = iRepoFavorite;
        }

        [BindProperty(SupportsGet = true)]
        public List<Article> Articles { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<Article> AllArticles { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<Favorite> Favorites { get; set; }




        public async Task OnGet()
        {


            Articles = ((await _repoArticles.GetAllAsync()).OrderByDescending(p => p.Id).Skip(0).Take(6)).ToList();

            AllArticles = ((await _repoArticles.GetAllAsync()).Skip(0).Take(4)).ToList();



            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null)
            {

                Favorites = ((await _IRepoFavorite.GetByUserIDAsync(userid)).Where(p => p.Type == "مقالات").ToList());

            }
            else Favorites = null;

            ViewData["listFavorites"] = Favorites;

        }
    }
}

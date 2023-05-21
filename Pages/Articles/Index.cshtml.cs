namespace liaqati_master.Pages.Articles
{
    [AllowAnonymous]

    public class IndexModel : PageModel
    {
        readonly IRepoArticles _repoArticles;
        readonly IRepoFavorite _IRepoFavorite;
        private readonly SignInManager<User> _signInManager;


        public IndexModel(IRepoArticles repoArticles, IRepoFavorite iRepoFavorite, SignInManager<User> signInManager)
        {
            _repoArticles = repoArticles;
            _IRepoFavorite = iRepoFavorite;
            _signInManager = signInManager;
        }

        [BindProperty(SupportsGet = true)]
        public List<Article> Articles { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<Article> AllArticles { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<Favorite> Favorites { get; set; }

        public List<VmArticles> articlesList { get; set; } = new List<VmArticles>();


        public async Task OnGet()
        {


            Articles = ((await _repoArticles.GetAllAsync()).OrderByDescending(p => p.Id).Skip(0).Take(6)).ToList();

            AllArticles = ((await _repoArticles.GetAllAsync()).Skip(0).Take(4)).ToList();






            foreach (Article article in Articles)
            {
                VmArticles articles = new VmArticles();
                if (_signInManager.IsSignedIn(User))
                {
                    List<Favorite> favorites = await _IRepoFavorite.GetByUserIDAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
                    if (favorites is not null && favorites.Count > 0)
                    {


                        Favorite favorite = favorites.Where(p => p.ArticleId != null && p.ArticleId == article.Id).FirstOrDefault();
                        if (favorite is null)
                        {

                            articles.IsFavorite = 1;
                        }
                        else
                        {
                            articles.IsFavorite = 2;

                        }




                    }

                }


                else if (!_signInManager.IsSignedIn(User))
                {
                    articles.IsFavorite = 0;
                }



                articles.Image = article.Image;
                articles.Title = article.Title;
                articles.PostDate = article.PostDate;
                articles.ViewsNumber = article.ViewsNumber;
                articles.LikesNumber = article.LikesNumber;
                articles.avgReading = article.avgReading;
                articles.Description = article.Description;
                articles.Id = article.Id;
                articles.CategoryId = article.CategoryId;




                articlesList.Add(articles);














            }




        }

    }
}
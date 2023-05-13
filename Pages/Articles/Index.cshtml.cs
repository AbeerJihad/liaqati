namespace liaqati_master.Pages.Articles
{
    [AllowAnonymous]

    public class IndexModel : PageModel
    {
        readonly IRepoArticles _repoArticles;

        public IndexModel(IRepoArticles repoArticles)
        {
            _repoArticles = repoArticles;
        }

        [BindProperty(SupportsGet = true)]
        public List<Article> Articles { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<Article> AllArticles { get; set; }




        public async Task OnGet()
        {


            Articles = ((await _repoArticles.GetAllAsync()).OrderByDescending(p => p.Id).Skip(0).Take(6)).ToList();

            AllArticles = ((await _repoArticles.GetAllAsync()).Skip(0).Take(4)).ToList();
        }
    }
}

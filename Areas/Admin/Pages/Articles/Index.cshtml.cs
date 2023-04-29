namespace liaqati_master.Areas.Admin.Articles
{
    public class IndexModel : PageModel
    {
        private readonly IRepoArticles _repoArticles;

        public IndexModel(IRepoArticles repoArticles)
        {
            _repoArticles = repoArticles;
        }

        public IList<Article> Articles { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_repoArticles != null)
            {
                Articles = (await _repoArticles.GetAllAsync()).ToList();
            }
        }
        public async Task<IActionResult> OnPostAsync(string? id)

        {
            if (id == null || _repoArticles == null)
            {
                return NotFound();
            }
            Article? articles = await _repoArticles.GetByIDAsync(id);

            if (articles != null)
            {
                await _repoArticles.DeleteEntityAsync(articles);
            }

            return RedirectToPage("./Index");
        }



    }
}

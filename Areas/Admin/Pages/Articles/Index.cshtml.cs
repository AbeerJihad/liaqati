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
        [BindProperty(SupportsGet = true)]
        public ArticlesQueryParamters ArticlesQueryParamters { get; set; }
        public QueryPageResult<Article> QueryPageResult { get; set; }
        public IEnumerable<SelectListItem> lstPageSize { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem(){Value="5", Text="5"},
            new SelectListItem(){Value="10", Text="10"},
            new SelectListItem(){Value="20", Text="20"}
        };
        public SelectList Titles { get; set; }
        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value=nameof(Article.Title),Text="العنوان"},
            new SelectListItem(){Value=nameof(Article.PostDate),Text="تاريخ النشر"},
            new SelectListItem(){Value=nameof(Article.ViewsNumber),Text="عدد المشاهدات"},
            new SelectListItem(){Value=nameof(Article.LikesNumber),Text="عدد الإعجابات"},
        };


        public async Task OnGetAsync()
        {
            Titles = new SelectList(await _repoArticles.GetAllAsync(), nameof(Article.Title), nameof(Article.Title));
            if (_repoArticles != null)
            {
                QueryPageResult = (await _repoArticles.SearchArticles(ArticlesQueryParamters));
            }
        }
        public async Task<IActionResult> OnPostAsync(string? id)

        {
            Titles = new SelectList(await _repoArticles.GetAllAsync(), nameof(Article.Title), nameof(Article.Title));
            //Titles = (await _repoArticles.GetAllAsync()).Select(x =>new SelectListItem() { Text= x.Title,Value= x.Title }).ToList()

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

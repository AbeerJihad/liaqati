using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Articles
{
    public class AllArticlesModel : PageModel
    {

        readonly IRepoArticles _repoArticles;

        public AllArticlesModel(IRepoArticles repoArticles)
        {
            _repoArticles = repoArticles;
        }

        [BindProperty(SupportsGet = true)]
        public List<Article> Articles { get; set; }



        public async Task OnGet()
        {
            Articles = (List<Article>)await _repoArticles.GetAllAsync();
        }
    }
}

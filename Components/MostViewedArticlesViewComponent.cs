using liaqati_master.Services.Repositories;

namespace liaqati_master.Components
{
    public class MostViewedArticlesViewComponent : ViewComponent
    {
        private readonly IRepoArticles _articleRepo;
        public MostViewedArticlesViewComponent(IRepoArticles articleRepo)
        {
            _articleRepo = articleRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Article>? ListOfArticle = (await _articleRepo.GetAllAsync()).OrderByDescending(article => article.ViewsNumber).Take(4).ToList();
            return View(ListOfArticle);
        }

    }
}

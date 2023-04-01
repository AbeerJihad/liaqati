namespace liaqati_master.Components
{
    public class MostViewedArticlesViewComponent : ViewComponent
    {
        private readonly IRepository<Article> _articleRepo;
        public MostViewedArticlesViewComponent(IRepository<Article> articleRepo)
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

namespace liaqati_master.Components
{
    public class LastestArticlesViewComponent : ViewComponent
    {
        private readonly IRepoArticles _repoArticles;
        public LastestArticlesViewComponent(IRepoArticles repoArticles)
        {
            _repoArticles = repoArticles;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var AthleticPrograms = (await _repoArticles.GetAllAsync()).OrderByDescending(a => a.CreatedDate).Take(6).ToList();
            return View(AthleticPrograms);
        }
    }
}

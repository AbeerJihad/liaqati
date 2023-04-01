namespace liaqati_master.Components
{
    public class LastestArticlesViewComponent : ViewComponent
    {


        private readonly UnitOfWork _unitOfWork;


        public LastestArticlesViewComponent(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var AthleticPrograms = _unitOfWork.ArticleRepository.Get().OrderByDescending(a => a.PostDate).Take(3).ToList();
            return View(AthleticPrograms);
        }
    }
}

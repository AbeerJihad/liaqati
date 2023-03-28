using Microsoft.AspNetCore.Mvc;

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
            var AthleticPrograms = _unitOfWork.ArticleRepository.Get().ToList();
            return View(AthleticPrograms);
        }
    }
}

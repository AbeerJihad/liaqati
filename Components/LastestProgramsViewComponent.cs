using Microsoft.AspNetCore.Mvc;

namespace liaqati_master.Components
{
    public class LastestProgramsViewComponent : ViewComponent
    {


        private readonly UnitOfWork _unitOfWork;


        public LastestProgramsViewComponent(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var AthleticPrograms = _unitOfWork.SportsProgramRepository.Get().ToList();
            return View(AthleticPrograms);
        }
    }
}

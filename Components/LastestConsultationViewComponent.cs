namespace liaqati_master.Components
{
    public class LastestConsultationViewComponent : ViewComponent
    {
        private readonly UnitOfWork _unitOfWork;

        public LastestConsultationViewComponent(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var AthleticPrograms = _unitOfWork.ConsultationRepository.Get().OrderByDescending(a => a.PostDate).Take(3).ToList();
            return View(AthleticPrograms);
        }
    }
}

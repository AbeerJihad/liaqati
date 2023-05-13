namespace liaqati_master.Components
{
    public class SportsProgramsViewComponent : ViewComponent
    {
        private readonly UnitOfWork _unitOfWork;
        public SportsProgramsViewComponent(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<SportsProgram>? ListOfSportsProgram = _unitOfWork.SportsProgramRepository.Get().Take(3).ToList();
            return View(ListOfSportsProgram);
        }

    }
}

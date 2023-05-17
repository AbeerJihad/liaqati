namespace liaqati_master.Pages.Home
{
    public class IndexModel : PageModel
    {
        public List<SportsProgram> SportProgram = new List<SportsProgram>();
        private readonly UnitOfWork _unitOfWork;

        public IndexModel(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
            SportProgram = _unitOfWork.SportsProgramRepository.Get().ToList();

        }
    }
}

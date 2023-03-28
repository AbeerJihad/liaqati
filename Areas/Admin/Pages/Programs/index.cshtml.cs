using Microsoft.AspNetCore.Mvc.RazorPages;


namespace liaqati_master.Areas.Admin.Pages.Programs
{
    public class IndexProgramModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;

        public IndexProgramModel(UnitOfWork UnitOfWork)
        {
            _unitOfWork = UnitOfWork;
        }

        public IList<SportsProgram> Programs { get; set; }
        public async Task OnGetAsync()
        {
            if (_unitOfWork != null)
            {

                Programs = _unitOfWork.SportsProgramRepository.GetAllEntity();
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace liaqati_master.Pages.Programs
{
    public class cardModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;
        
        public cardModel(UnitOfWork UnitOfWork)
        {
            _unitOfWork = UnitOfWork;
        }

        public IList<SportsProgram> Programs { get; set; }
        public async Task OnGetAsync()
        {
            if (_unitOfWork != null)
            {

                Programs =  _unitOfWork.SportsProgramRepository.GetAllEntity();
            }
        }
  
    
    public async Task<IActionResult> OnPostAsync(string id)
        {




           return Page();
        }
    
    
    
    
    
    }
}

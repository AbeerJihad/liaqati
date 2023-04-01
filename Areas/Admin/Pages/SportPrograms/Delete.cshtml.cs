using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace liaqati_master.Pages.Programs
{
    public class DeleteProgramModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;

        public DeleteProgramModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
        }

        [BindProperty]
        public SportsProgram SportsProgram { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var program = _UnitOfWork.SportsProgramRepository.GetByID(id);

            if (program == null)
            {
                return NotFound();
            }
            else
            {
                SportsProgram = program;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == null )
            {
                return NotFound();
            }
          var program=  _UnitOfWork.SportsProgramRepository.GetByID(id);



            if (program != null)
            {
                SportsProgram = program;

                _UnitOfWork.SportsProgramRepository.Delete(program);
                _UnitOfWork.Save();

            
            }

            return RedirectToPage("./Index");
        }
    }
}

using liaqati_master.Services.RepoCrud;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.ProgramPages
{
    public class IndexModel : PageModel
    {
        readonly RepoProgram _context;

        public IndexModel(RepoProgram context)
        {
            _context = context;
        }


        [BindProperty(SupportsGet =true)]
        public List<SportsProgram> Sports { get; set; }


        public async Task OnGet()
        {

            Sports = await _context.GetAllProgram();

        }

    }
}

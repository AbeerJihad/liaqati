using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.ProgramPages
{
    public class clenderModel : PageModel
    {

        readonly LiaqatiDBContext _context;

        public clenderModel(LiaqatiDBContext context)
        {
            _context = context;
        }


        [BindProperty]
        public List<Event> Events { get; set; }
        public void OnGet()
        {
          //  Events=_context.TblEvents.g
            
        }
    }
}




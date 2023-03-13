using liaqati_master.Data;
using liaqati_master.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace liaqati_master.Pages.Programs
{
    public class IndexModel : PageModel
    {
        private readonly LiaqatiDBContext _context;

        public IndexModel(LiaqatiDBContext context)
        {
            _context = context;
        }

        public IList<AthleticProgram> programs { get; set; }
        public async Task OnGetAsync()
        {
            if (_context != null)
            {
                programs = await _context.TblSportsProgram.ToListAsync();
            }
        }
    }
}

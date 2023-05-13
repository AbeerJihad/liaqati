using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Pages.Consultations
{
    public class DetailsModel : PageModel
    {
        private readonly LiaqatiDBContext _context;

        public DetailsModel(liaqati_master.Data.LiaqatiDBContext context)
        {
            _context = context;
        }

        public Consultation Consultations { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null || _context.TblConsultation == null)
            {
                return NotFound();
            }

            var articles = await _context.TblConsultation.FirstOrDefaultAsync(m => m.Id == id);
            if (articles == null)
            {
                return NotFound();
            }
            else
            {
                Consultations = articles;
            }
            return Page();
        }
    }
}


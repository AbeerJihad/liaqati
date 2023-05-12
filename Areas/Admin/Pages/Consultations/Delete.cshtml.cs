using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Pages.Consultations
{
    public class DeleteModel : PageModel
    {
        private readonly liaqati_master.Data.LiaqatiDBContext _context;

        public DeleteModel(liaqati_master.Data.LiaqatiDBContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == null || _context.TblConsultation == null)
            {
                return NotFound();
            }
            var articles = await _context.TblConsultation.FindAsync(id);

            if (articles != null)
            {
                Consultations = articles;
                _context.TblConsultation.Remove(Consultations);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Pages.Replyconsultations
{
    public class DeleteModel : PageModel
    {
        private readonly liaqati_master.Data.LiaqatiDBContext _context;

        public DeleteModel(liaqati_master.Data.LiaqatiDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Replyconsultation Replyconsultations { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null || _context.TblReplyconsultation == null)
            {
                return NotFound();
            }

            var reply = await _context.TblReplyconsultation.FirstOrDefaultAsync(m => m.Id == id);

            if (reply == null)
            {
                return NotFound();
            }
            else
            {
                Replyconsultations = reply;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == null || _context.TblReplyconsultation == null)
            {
                return NotFound();
            }
            var reply = await _context.TblReplyconsultation.FindAsync(id);

            if (reply != null)
            {
                Replyconsultations = reply;
                _context.TblReplyconsultation.Remove(Replyconsultations);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

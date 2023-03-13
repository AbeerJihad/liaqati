using liaqati_master.Data;
using liaqati_master.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace project.Pages.Programs
{
    public class DeleteModel : PageModel
    {
        private readonly LiaqatiDBContext _context;

        public DeleteModel(LiaqatiDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AthleticProgram program { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblSportsProgram == null)
            {
                return NotFound();
            }

            var student = await _context.TblSportsProgram.FirstOrDefaultAsync(m => m.Id == id);

            if (student == null)
            {
                return NotFound();
            }
            else
            {
                program = student;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblSportsProgram == null)
            {
                return NotFound();
            }

            var student = await _context.TblSportsProgram.FindAsync(id);

            if (student != null)
            {
                program = student;
                _context.TblSportsProgram.Remove(program);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

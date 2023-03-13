using liaqati_master.Data;
using liaqati_master.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Programs
{
    public class CreateModel : PageModel
    {
        private readonly LiaqatiDBContext _context;

        public CreateModel(LiaqatiDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AthleticProgram program { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblSportsProgram.Add(program);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

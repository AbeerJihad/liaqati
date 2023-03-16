using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Articles
{
    public class DeleteModel : PageModel
    {
        private readonly liaqati_master.Data.LiaqatiDBContext _context;

        public DeleteModel(liaqati_master.Data.LiaqatiDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Article Articles { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null || _context.TblArticles == null)
            {
                return NotFound();
            }

            var articles = await _context.TblArticles.FirstOrDefaultAsync(m => m.Id == id);

            if (articles == null)
            {
                return NotFound();
            }
            else
            {
                Articles = articles;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == null || _context.TblArticles == null)
            {
                return NotFound();
            }
            var articles = await _context.TblArticles.FindAsync(id);

            if (articles != null)
            {
                Articles = articles;
                _context.TblArticles.Remove(Articles);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

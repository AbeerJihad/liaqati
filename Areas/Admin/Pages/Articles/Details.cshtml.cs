using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Articles
{
    public class DetailsModel : PageModel
    {
        private readonly LiaqatiDBContext _context;

        public DetailsModel(liaqati_master.Data.LiaqatiDBContext context)
        {
            _context = context;
        }

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
    }
}

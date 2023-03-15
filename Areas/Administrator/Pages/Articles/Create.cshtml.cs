using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Articles
{
    public class CreateModel : PageModel
    {
        private readonly liaqati_master.Data.LiaqatiDBContext _context;

        public CreateModel(liaqati_master.Data.LiaqatiDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Article Articles { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblArticles.Add(Articles);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

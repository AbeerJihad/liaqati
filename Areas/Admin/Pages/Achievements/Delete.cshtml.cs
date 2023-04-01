using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Achievements
{
    public class DeleteModel : PageModel
    {
        private readonly liaqati_master.Data.LiaqatiDBContext _context;

        public DeleteModel(liaqati_master.Data.LiaqatiDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Achievement Achievements { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.TblAchievements == null)
            {
                return NotFound();
            }

            var achievements = await _context.TblAchievements.FirstOrDefaultAsync(m => m.Id == id);

            if (achievements == null)
            {
                return NotFound();
            }
            else
            {
                Achievements = achievements;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.TblAchievements == null)
            {
                return NotFound();
            }
            var achievements = await _context.TblAchievements.FindAsync(id);

            if (achievements != null)
            {
                Achievements = achievements;
                _context.TblAchievements.Remove(Achievements);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

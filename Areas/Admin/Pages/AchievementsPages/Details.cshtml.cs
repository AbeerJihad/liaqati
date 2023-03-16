using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Administrator.Pages.AchievementsPages
{
    public class DetailsModel : PageModel
    {
        private readonly liaqati_master.Data.LiaqatiDBContext _context;

        public DetailsModel(liaqati_master.Data.LiaqatiDBContext context)
        {
            _context = context;
        }

        public Achievements Achievements { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context == null)
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
    }
}

using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Pages.Achievements
{
    public class DeleteModel : PageModel
    {
        private readonly IRepoAchievement _repoAchievement;

        public DeleteModel(IRepoAchievement repoAchievement)
        {
            _repoAchievement = repoAchievement;
        }

        [BindProperty]
        public Achievement Achievements { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var achievements = await _repoAchievement.GetByIDAsync(id);
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
            if (id == null)
            {
                return NotFound();
            }
            var achievements = await _repoAchievement.GetByIDAsync(id);

            if (achievements != null)
            {
                Achievements = achievements;
                await _repoAchievement.DeleteEntityAsync(Achievements);
            }

            return RedirectToPage("./Index");
        }
    }
}

using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Pages.Achievements
{
    public class CreateModel : PageModel
    {
        private readonly IRepoAchievement _repoAchievement;

        public CreateModel(IRepoAchievement repoAchievement)
        {
            _repoAchievement = repoAchievement;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public Achievement Achievements { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _repoAchievement == null)
            {
                return Page();
            }
            Achievements.Id = CommonMethods.Id_Guid();
            Achievements.UserId = "1";
            await _repoAchievement.AddEntityAsync(Achievements);
            return RedirectToPage("./Index");
        }
    }
}

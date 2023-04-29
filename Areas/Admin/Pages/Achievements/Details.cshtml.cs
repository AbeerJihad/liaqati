
namespace liaqati_master.Areas.Admin.Pages.Achievements
{
    public class DetailsModel : PageModel
    {
        private readonly IRepoAchievement _repoAchievement;

        public DetailsModel(IRepoAchievement repoAchievement)
        {
            _repoAchievement = repoAchievement;
        }

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
    }
}

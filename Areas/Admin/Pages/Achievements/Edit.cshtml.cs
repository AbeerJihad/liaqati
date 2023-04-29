namespace liaqati_master.Areas.Admin.Pages.Achievements
{
    public class EditModel : PageModel
    {
        private readonly IRepoAchievement _repoAchievement;

        public EditModel(IRepoAchievement repoAchievement)
        {
            _repoAchievement = repoAchievement;
        }

        [BindProperty]
        public Achievement Achievements { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _repoAchievement == null)
            {
                return NotFound();
            }

            var achievements = await _repoAchievement.GetByIDAsync(id);
            if (achievements == null)
            {
                return NotFound();
            }
            Achievements = achievements;
            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Achievements.UserId = "1";
            await _repoAchievement.UpdateEntityAsync(Achievements);



            return RedirectToPage("./Index");
        }


    }
}

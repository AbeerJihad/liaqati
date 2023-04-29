namespace liaqati_master.Areas.Admin.Pages.Achievements
{
    public class IndexModel : PageModel
    {
        private readonly IRepoAchievement _repoAchievement;

        public IndexModel(IRepoAchievement repoAchievement)
        {
            _repoAchievement = repoAchievement;
        }
        public IList<Achievement> Achievements { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_repoAchievement != null)
            {
                Achievements = (await _repoAchievement.GetAllAsync()).ToList();
            }
        }
        public async Task<IActionResult> OnPostAsync(string? Id)
        {
            if (Id == null || _repoAchievement == null)
            {
                return NotFound();
            }
            var articles = await _repoAchievement.GetByIDAsync(Id);

            if (articles != null)
            {
                await _repoAchievement.DeleteEntityAsync(articles);
            }

            return RedirectToPage("./Index");
        }


    }
}

#nullable disable
namespace liaqati_master.Pages.Home
{
    public class IndexModel : PageModel
    {
        public List<SportsProgram> SportProgram { get; set; }
        private readonly IRepoProgram _IRepoProgram;

        public IndexModel(IRepoProgram IRepoProgram)
        {
            _IRepoProgram = IRepoProgram;
        }
        public async Task OnGet()
        {
            SportProgram = (await _IRepoProgram.GetAllProgram()).ToList();
        }
    }
}

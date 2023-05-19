namespace liaqati_master.Components
{
    public class SportsProgramsViewComponent : ViewComponent
    {
        private readonly IRepoProgram _IRepoProgram;
        public SportsProgramsViewComponent(IRepoProgram repoProgram)
        {
            _IRepoProgram = repoProgram;

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<SportsProgram>? ListOfSportsProgram = (await _IRepoProgram.GetAllProgram()).Take(3).ToList();
            return View(ListOfSportsProgram);
        }

    }
}

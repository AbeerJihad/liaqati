namespace liaqati_master.Components
{
    public class LastestProgramsViewComponent : ViewComponent
    {
        private readonly IRepoProgram _IRepoProgram;
        public LastestProgramsViewComponent(IRepoProgram repoProgram)
        {
            _IRepoProgram = repoProgram;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var AthleticPrograms = (await _IRepoProgram.GetAllProgram()).ToList();
            return View(AthleticPrograms);
        }
    }
}

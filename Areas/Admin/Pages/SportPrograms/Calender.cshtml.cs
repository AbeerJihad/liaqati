namespace liaqati_master.Areas.Admin.Pages.Programs
{
    public class CalenderModel : PageModel
    {
        private readonly IRepoProgram _repoProgram;
        private readonly IRepoExercise _repoExercise;

        public CalenderModel(IRepoProgram repoProgram, IRepoExercise repoExercise)
        {
            _repoProgram = repoProgram;
            _repoExercise = repoExercise;
        }

        [BindProperty(SupportsGet = true)]
        public string id { get; set; }

        public List<object> data { get; set; }

        public async Task OnGet()
        {
            var program = await _repoProgram.GetProgram(id);
            for (int i = 0; i < program?.Exercies_Programs?.Count; i++)
            {
                Exercise? exercise = await _repoExercise.GetByIDAsync(program.Exercies_Programs[i].Id);
                data.Add(new { Id = CommonMethods.Id_Guid(), name = exercise?.Title });

            }
        }
    }
}

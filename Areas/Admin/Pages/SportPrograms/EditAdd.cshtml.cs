namespace liaqati_master.Areas.Admin.Pages.Programs
{
    public class EditAddModel : PageModel
    {
        private readonly LiaqatiDBContext _context;

        private readonly IRepoExercise _IRepoExercise;
        private readonly IRepoProgram _IRepoProgram;

        public EditAddModel(LiaqatiDBContext context, IRepoExercise IRepoExercise, IRepoProgram iRepoProgram)
        {
            _context = context;
            _IRepoExercise = IRepoExercise;
            _IRepoProgram = iRepoProgram;

        }


        [BindProperty(SupportsGet = true)]
        public SportsProgram SportsPrograms { get; set; }



        [BindProperty(SupportsGet = true)]
        public Exercies_program Exercies_program { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<string> list { get; set; }


        public void OnGet()
        {



        }

        public async Task<IActionResult> OnPostAddSystemAsync()
        {

            SportsProgram? old = await _IRepoProgram.GetProgram(SportsPrograms.Id);
            if (old is null)
            {
                return Page();

            }
            for (int y = 0; y < list.Count; y++)
            {
                var Eid = (await _IRepoExercise.GetAllAsync()).Where(p => p.Title == list[y]).ToList();

                old.Exercies_Programs!.Add(new Exercies_program()
                {
                    Id = CommonMethods.Id_Guid(),
                    SportsProgramId = SportsPrograms.Id,
                    Day = int.Parse(Exercies_program.Day.ToString()),
                    Week = int.Parse(Exercies_program.Week.ToString()),
                    ExerciseId = Eid[0].Id
                });
            }
            old.Services!.Title = SportsPrograms.Services!.Title;
            old.Services.Price = SportsPrograms.Services.Price;
            old.Services.Description = SportsPrograms.Services.Description;
            old.Length = SportsPrograms.Length;
            old.BodyFocus = SportsPrograms.BodyFocus;
            old.Difficulty = SportsPrograms.Difficulty;
            old.Equipment = SportsPrograms.Equipment;
            old.TrainingType = SportsPrograms.TrainingType;
            await _IRepoProgram.UpdateProgram(old);
            return Page();
        }



    }
}

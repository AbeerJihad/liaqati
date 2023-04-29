namespace liaqati_master.Pages.Programs
{
    public class EditProgramModel : PageModel
    {


        private readonly IRepoProgram _repoProgram;
        private readonly IRepoExercise _repoExercise;
        private readonly IRepoCategory _repoCategory;
        private readonly IRepoService _repoService;
        private readonly IRepoProgramExercies _repoProgramExercies;
        private readonly IFormFileMang _repoFile;
        private readonly UnitOfWork _UnitOfWork;
        private readonly LiaqatiDBContext _context;




        public EditProgramModel(IRepoProgram repoProgram, IRepoExercise repoExercise, IRepoCategory repoCategory, IRepoService repoService, IFormFileMang repoFile, IRepoProgramExercies repoProgramExercies, UnitOfWork unitOfWork, LiaqatiDBContext context)
        {
            _repoProgram = repoProgram;
            _repoExercise = repoExercise;
            _repoCategory = repoCategory;
            _repoService = repoService;
            _repoFile = repoFile;
            _repoProgramExercies = repoProgramExercies;
            _UnitOfWork = unitOfWork;
            _context = context;
        }

        public async Task<Exercise?> getExercise(string id)
        {
            var exercise = await _repoExercise.GetByIDAsync(id);

            return exercise;
        }


        public SelectList CatogeryName { get; set; }
        public List<SelectListItem> ExerciesName { get; set; }


        [BindProperty(SupportsGet = true)]
        public SportsProgram SportsProgram { get; set; }


        [BindProperty(SupportsGet = true)]
        public Exercies_program Exercies_program { get; set; }


        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SportsProgram sportsProgram = await _repoProgram.GetProgram(id);


            //  SportsProgram sportsProgram =_UnitOfWork.SportsProgramRepository.GetByID(id);


            //foreach(Exercies_program x in  sportsProgram.Exercies_Programs!)
            //{
            //    x.sportsProgram = null;
            //}








            if (sportsProgram == null)
            {
                return NotFound();
            }
            SportsProgram = sportsProgram;

            SportsProgram.Exercies_Programs = SportsProgram.Exercies_Programs!.OrderBy(x => x.Week).ThenBy(y => y.Day).ToList();






            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(SportProgram)]), nameof(Category.Id), nameof(Category.Name));




            ExerciesName = (await _repoExercise.GetAllAsync()).Select(a =>
                                       new SelectListItem
                                       {
                                           Value = a.Id.ToString(),
                                           Text = a.Title
                                       }).ToList();

            //
            return Page();
        }


        public async Task<IActionResult> OnPostEditProgramAsync()
        {

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            var id = SportsProgram.Id;
            SportsProgram item = await _repoProgram.GetProgram(id);
            if (item is null)
            {
                return NotFound();
            }

            item.Services!.Title = SportsProgram.Services!.Title;
            item.Services.Price = SportsProgram.Services.Price;
            item.Services.Description = SportsProgram.Services.Description;
            item.Length = SportsProgram.Length;
            item.BodyFocus = SportsProgram.BodyFocus;
            item.Difficulty = SportsProgram.Difficulty;
            item.Equipment = "";
            item.TrainingType = SportsProgram.TrainingType;
            item.Services.CategoryId = SportsProgram.Services.CategoryId;
            for (int x = 0; x < SportsProgram.Exercies_Programs!.Count; x++)
            {
                item.Exercies_Programs![x] = SportsProgram.Exercies_Programs[x];
            }
            await _repoProgram.UpdateProgram(item);
            return RedirectToPage("./Index");
        }


        public async Task<IActionResult> OnPostDeleteProgExer(string id)
        {


            if (id == null)
            {
                return NotFound();
            }

            Exercies_program x = _UnitOfWork.ProgramexerciseRepository.GetByID(id);


            SportsProgram sport = _UnitOfWork.SportsProgramRepository.GetByID(x.SportsProgramId);



            _UnitOfWork.ProgramexerciseRepository.Delete(id);
            _UnitOfWork.Save();


            return RedirectToPage("Edit", new { id = sport.Id });
        }



        public async Task<IActionResult> OnPostEditProgExer()
        {
            Exercies_program exercies = _UnitOfWork.ProgramexerciseRepository.GetByID(Exercies_program.Id);

            exercies.Day = Exercies_program.Day;
            exercies.Week = Exercies_program.Week;
            exercies.ExerciseId = Exercies_program.ExerciseId;

            _UnitOfWork.ProgramexerciseRepository.Update(exercies);
            _UnitOfWork.Save();

            return RedirectToPage("Edit", new { id = Exercies_program.SportsProgramId });
        }


        public async Task<IActionResult> OnPostAddSystemAsync(string? id)
        {


            SportsProgram sports = _UnitOfWork.SportsProgramRepository.GetByID(id);

            List<Exercies_program> list = new List<Exercies_program>();

            foreach (Exercies_program x in _context.TblExercies_program.ToList())
            {
                if (x.SportsProgramId == id)
                {
                    list.Add(x);
                }

            }
            SportsProgram = sports;
            SportsProgram.Exercies_Programs = list;



            return Page();
        }








    }
}

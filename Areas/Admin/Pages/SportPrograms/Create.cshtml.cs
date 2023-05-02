namespace liaqati_master.Pages.Programs
{
    public class CreatProgrameModel : PageModel
    {
        private readonly IRepoProgram _repoProgram;
        private readonly IRepoExercise _repoExercise;
        private readonly IRepoProgramExercies _repoProgramExercies;
        private readonly IRepoCategory _repoCategory;
        private readonly IRepoService _repoService;
        private readonly IFormFileMang _repoFile;


        public CreatProgrameModel(IFormFileMang repoFile, IRepoProgram repoProgram, IRepoCategory repoCategory, IRepoExercise repoExercise, IRepoService repoService, IRepoProgramExercies repoProgramExercies)
        {
            _repoFile = repoFile;
            _repoProgram = repoProgram;
            _repoCategory = repoCategory;
            _repoExercise = repoExercise;
            _repoService = repoService;
            _repoProgramExercies = repoProgramExercies;
        }

        public SelectList CatogeryName { get; set; }

        public List<SelectListItem> LstExercies { get; set; }
        [BindProperty]
        public string text { get; set; }


        public int index { get; set; } = -1;
        [BindProperty]
        public List<Exercies_program> Exercies_program { get; set; }

        [BindProperty(SupportsGet = true)]
        public SportsProgram SportsProgram { get; set; }


        [BindProperty]
        public Exercise Exercises { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<string> list { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }
        public string Display { get; set; } = "d-none";
        public string ReadOnly { get; set; } = "";

        public int btnSave { get; set; }


        public async Task<IActionResult> OnGet([FromRoute] string? Id)
        {

            //CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(SportsProgram)]), nameof(Category.Id), nameof(Category.Name));

            Display = "d-none";
            btnSave = 0;


            SportsProgram sports = await _repoProgram.GetProgram(Id);
            if (sports != null)
            {
                SportsProgram = sports;
                SportsProgram.Exercies_Programs = SportsProgram.Exercies_Programs!.OrderBy(x => x.Week).ThenBy(y => y.Day).ToList();
            }








            LstExercies = (await _repoExercise.GetAllAsync()).Select(a =>
                                        new SelectListItem
                                        {
                                            Value = a.Id.ToString(),
                                            Text = a.Title
                                        }).ToList();


            return Page();
        }


        public async Task<Exercise?> getExercise(string id)
        {
            var exercise = await _repoExercise.GetByIDAsync(id);

            return exercise;
        }





        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAddAsync()
        {
            btnSave = 1;
            ReadOnly = "readonly";
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            //      SportsProgram.Exercises = _UnitOfWork.ExerciseRepository.GetByMultiID(list);



            SportsProgram.Id = CommonMethods.Id_Guid();

            SportsProgram.Services!.Id = SportsProgram.Id;





            SportsProgram.Equipment = "";

            SportsProgram.Services.CategoryId = SportsProgram.Services.CategoryId;



            string? oldurl = SportsProgram.Image;

            if (Image != null)
            {
                SportsProgram.Image = await _repoFile.Upload(Image, "Images", "Program");

            }
            else
            {
                SportsProgram.Image = oldurl;
            }







            await _repoService.AddEntityAsync(SportsProgram.Services);
            await _repoProgram.AddProgram(SportsProgram);

            Display = "d-block";


            return Page();
        }



        public async Task<IActionResult> OnPostAddSystemAsync(string? id)
        {
            btnSave = 1;
            SportsProgram sports = await _repoProgram.GetProgram(id);
            SportsProgram = sports;
            SportsProgram.Exercies_Programs = (await _repoProgramExercies.GetAllExercies_program()).Where(exp => exp.SportsProgramId == id).ToList();
            Display = "d-block";
            return Page();
        }



    }
}

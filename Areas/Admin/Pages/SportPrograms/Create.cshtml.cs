using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Programs
{
    public class CreatProgrameModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;
        private readonly IFormFileMang _repoFile;


        public CreatProgrameModel(LiaqatiDBContext context, UnitOfWork unitOfWork, IFormFileMang repoFile)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
            _repoFile = repoFile;
        }

        public List<SelectListItem> CatogeryName
        {
            get
            {
                return _UnitOfWork.CategoryRepository.GetAllEntity().Select
                    (a => new SelectListItem
                    {
                        Value = a.Id.ToString(),
                        Text = a.Name
                    }).ToList();
            }
            set
            {
            }
        }





        public List<SelectListItem> LstExercies { get; set; }
        [BindProperty]
        public string text { get; set; }


        public int index { get; set; } = -1;
        [BindProperty]
        public List<Exercies_program> Exercies_program { get; set; } = null;





        [BindProperty(SupportsGet = true)]
        public SportsProgram SportsProgram { get; set; }


        [BindProperty]
        public Exercise Exercises { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<string> list { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }
        public string Display { get; set; } = "d-none";

        public int btnSave { get; set; }


        public async Task<IActionResult> OnGet([FromRoute] string? Id)
        {

            Display = "d-none";
            btnSave = 0;


            SportsProgram sports = _UnitOfWork.SportsProgramRepository.GetByID(Id);
            if (sports != null)
            {
                SportsProgram = sports;
            }








            LstExercies = _UnitOfWork.ExerciseRepository.GetAllEntity().Select(a =>
                                        new SelectListItem
                                        {
                                            Value = a.Id.ToString(),
                                            Text = a.Title
                                        }).ToList();


            return Page();
        }


        public Exercise getExercise(string id)
        {
            Exercise exercise = _UnitOfWork.ExerciseRepository.GetByID(id);

            return exercise;
        }





        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAddAsync()
        {
            btnSave = 1;

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            //      SportsProgram.Exercises = _UnitOfWork.ExerciseRepository.GetByMultiID(list);



            SportsProgram.Id = CommonMethods.Id_Guid();

            SportsProgram.Services!.Id = SportsProgram.Id;





            SportsProgram.Equipment = "";

            SportsProgram.Services.CategoryId = SportsProgram.Services.CategoryId;



            string oldurl = SportsProgram.Image;

            if (Image != null)
            {
                SportsProgram.Image = await _repoFile.Upload(Image, "Images", "Program");

            }
            else
            {
                SportsProgram.Image = oldurl;
            }







            _UnitOfWork.SportsProgramRepository.Insert(SportsProgram);
            _UnitOfWork.ServiceRepository.Insert(SportsProgram.Services);
            _UnitOfWork.Save();


            Display = "d-block";


            return Page();
        }



        public async Task<IActionResult> OnPostAddSystemAsync(string? id)
        {
            btnSave = 1;


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

            Display = "d-block";

            return Page();
        }



    }
}

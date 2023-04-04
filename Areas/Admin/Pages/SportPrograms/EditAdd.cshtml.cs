using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Pages.Programs
{
    public class EditAddModel : PageModel
    {
        private readonly LiaqatiDBContext _context;

        private readonly UnitOfWork _UnitOfWork;

        public EditAddModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
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

            SportsProgram old = _UnitOfWork.SportsProgramRepository.GetByID(SportsPrograms.Id);

            for (int y = 0; y < list.Count; y++)
            {
                var Eid = _UnitOfWork.ExerciseRepository.GetAllEntity().Where(p => p.Title == list[y]).ToList();

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


            //var cid = SportsPrograms.Services!.Category!.Id;
            //if (cid != null)
            //{
            //    SportsPrograms.Services.CategoryId = cid;

            //}

            old.Services.Category = null;


            _UnitOfWork.SportsProgramRepository.Update(old);




            return Page();
        }



    }
}

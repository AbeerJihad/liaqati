using Microsoft.AspNetCore.Mvc;
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

                old.exercies_Programs!.Add(new Exercies_program()
                {
                    Id = Guid_Id.Id_Guid(),
                    sportsProgramId = SportsPrograms.Id,
                    Day = int.Parse(Exercies_program.Day.ToString()),
                    Week = int.Parse(Exercies_program.Week.ToString()),
                    exerciseId = Eid[0].Id
                });


           
            }


            old.services!.Title = SportsPrograms.services!.Title;
            old.services.Price = SportsPrograms.services.Price;
            old.services.Description = SportsPrograms.services.Description;
            old.Length = SportsPrograms.Length;
            old.BodyFocus = SportsPrograms.BodyFocus;
            old.Difficulty = SportsPrograms.Difficulty;
            old.Equipment = SportsPrograms.Equipment;
            old.TrainingType = SportsPrograms.TrainingType;


            //var cid = SportsPrograms.services!.Category!.Id;
            //if (cid != null)
            //{
            //    SportsPrograms.services.CategoryId = cid;

            //}

            old.services.Category = null;


            _UnitOfWork.SportsProgramRepository.Update(old);




            return Page();
        }



    }
}

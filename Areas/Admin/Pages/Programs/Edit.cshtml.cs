using liaqati_master.Services.RepoCrud;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Programs
{
    public class EditProgramModel : PageModel
    {

        private readonly LiaqatiDBContext _context;

        private readonly UnitOfWork _UnitOfWork;
        public readonly RepoProgram _repo;


        public EditProgramModel(LiaqatiDBContext context, UnitOfWork unitOfWork, RepoProgram repo)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
            _repo = repo;
        }

        public Exercise getExercise(string id)
        {
            Exercise exercise = _UnitOfWork.ExerciseRepository.GetByID(id);

            return exercise;
        }


        public List<SelectListItem> CatogeryName { get; set; }
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

            SportsProgram sportsProgram = await _repo.GetProgram(id);


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

            CatogeryName = _UnitOfWork.CategoryRepository.GetAllEntity().Select(a =>
                                       new SelectListItem
                                       {
                                           Value = a.Id.ToString(),
                                           Text = a.Name
                                       }).ToList();



            ExerciesName = _UnitOfWork.ExerciseRepository.GetAllEntity().Select(a =>
                                       new SelectListItem
                                       {
                                           Value = a.Id.ToString(),
                                           Text = a.Title
                                       }).ToList();

            //
            return Page();
        }

     
        public async Task<IActionResult> OnPostEditProgramAsync ()
        {

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            var id = SportsProgram.Id;

            var item = _UnitOfWork.SportsProgramRepository.GetByID(id);
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


         
            

            



            _UnitOfWork.SportsProgramRepository.Update(item);



            try
            {
                _UnitOfWork.Save();
            }




            catch (DbUpdateConcurrencyException)
            {

            }

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


            return RedirectToPage("Edit",new  { id= sport.Id});
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

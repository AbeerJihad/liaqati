using liaqati_master.Services.RepoCrud;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Programs
{
    public class EditProgramModel : PageModel
    {

        private readonly LiaqatiDBContext _context;

        private readonly UnitOfWork _UnitOfWork;
        public readonly IRepoProgram _repo;


        public EditProgramModel(LiaqatiDBContext context, UnitOfWork unitOfWork, IRepoProgram repo)
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

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPost()
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

            for (int x = 0; x < SportsProgram.Exercies_Programs!.Count; x++)
            {
                item.Exercies_Programs![x] = SportsProgram.Exercies_Programs[x];


            }


            var cid = SportsProgram.Services!.Category!.Id;
            if (id != null)
            {
                SportsProgram.Services.CategoryId = id;

            }

            item.Services.Category = null;


            _UnitOfWork.SportsProgramRepository.Update(item);


            //  _context.Attach(MealPlans).State = EntityState.Modified;

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

            var x = _UnitOfWork.ProgramexerciseRepository.GetByID(id);

            _UnitOfWork.ProgramexerciseRepository.Delete(id);


            return Page();
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











    }
}

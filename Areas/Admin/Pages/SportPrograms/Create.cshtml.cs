using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Programs
{
    public class CreatProgrameModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;

        public CreatProgrameModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
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



            //List<string> xxx = text.Split('\n').ToList();

            //for(int x=0;x<xxx.Count-1;x++)
            //{
            //    string s = xxx[x];
            //    var item= s.Split(new char[] {',','\r'});

            //    if(item.Length -2 > 1)
            //    {

            //        for (int y = 2;y < item.Length -1  ; y++)
            //        {
            //            var Eid = _UnitOfWork.ExerciseRepository.GetAllEntity().Where(p => p.Title == item[y]).ToList();

            //            Exercies_program.Add(new Exercies_program()
            //            {
            //                Id = Guid_Id.Id_Guid(),
            //                sportsProgramId = SportsProgram.Id,
            //                Day = int.Parse(item[0]),
            //                Week = int.Parse(item[1]),
            //                exerciseId = Eid[0].Id
            //            }


            //   ); 
            //        }
            //        }
            //    else if (item.Length - 1 == 1)
            //    {
            //        var Eid = _UnitOfWork.ExerciseRepository.GetAllEntity().Where(p => p.Title == item[2]).ToList();

            //        Exercies_program.Add(new Exercies_program()
            //        {

            //            Id = Guid_Id.Id_Guid(),
            //            sportsProgramId = SportsProgram.Id,
            //            Day = int.Parse(item[0]),
            //            Week = int.Parse(item[1]),
            //            exerciseId = Eid[0].Id
            //        });
            //    }









            // //   var z = xxx.Split(',');

            //}

            //Exercies_program.RemoveAt(0);

            //SportsProgram.Exercies_Programs = Exercies_program;

            SportsProgram.Equipment = "";
            var id = SportsProgram.Services!.Category!.Id;
            if (id != null)
            {
                SportsProgram.Services.CategoryId = id;

            }
            SportsProgram.Services.Category = null;
            _UnitOfWork.SportsProgramRepository.Insert(SportsProgram);
            _UnitOfWork.ServiceRepository.Insert(SportsProgram.Services);
            _UnitOfWork.Save();
            var Id = SportsProgram.Id;
            //  return RedirectToPage("create",new {Id= SportsProgram.Id});

            // b39d4232-f946-41a9-8acb-3803ceebc79b

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

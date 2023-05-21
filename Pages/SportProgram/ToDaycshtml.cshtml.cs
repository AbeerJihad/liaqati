using MessagePack;

namespace liaqati_master.Pages.ProgramPages
{
    [AllowAnonymous]

    public class ToDaycshtmlModel : PageModel
    {
        readonly IRepoProgram _context;
        readonly IRepoProgramExercies _repocontext;
        readonly IRepoExercise _repocontextExer;
        readonly IRepoTraking _repoTraking;


        public ToDaycshtmlModel(IRepoProgram context, IRepoProgramExercies repocontext, IRepoExercise repocontextExer , IRepoTraking repoTraking)
        {
            _context = context;
            _repocontext = repocontext;
            _repocontextExer = repocontextExer;
            _repoTraking= repoTraking;
        }



        [BindProperty(SupportsGet = true)]
        public List<Exercise> Exercises { get; set; }




        [BindProperty(SupportsGet = true)]
        public List<Tracking> Tracking { get; set; }



        [BindProperty(SupportsGet = true)]
        public List<Exercies_program> Exercies_programs { get; set; }



        public async Task<IActionResult> OnGet(string id , DateTime DateDay, DateTime startProgram)
        {


            int m= (DateDay - startProgram).Days +1;
            
            int day = 0;
            int week = 1;




            for (int i = 0; i < 4; i++)
            {
                if (m > 6)
                {
                    m -= 7;
                    week += 1;

                }
                else
                {
                    day = m;
                }





            }

            if (day == 0)
            {
                day= 7;
                week -= 1;

            }
           






            Exercies_programs = (await _repocontext.GetAllExercies_program()).Where(p=>p.SportsProgramId == id).ToList();

            Exercies_programs = Exercies_programs.Where(s => s.Day == day && s.Week == week).ToList();


            if(Exercies_programs is not null)
            {
                foreach (Exercies_program ex in Exercies_programs)
                {



                    var tracking = (await _repoTraking.GetAllAsync()).ToList();
                    Tracking track = tracking.FirstOrDefault(p=>p.Exercies_programId==ex.Id);

                    if (track is not null)
                    {
                        Tracking.Add(track);

                    }


                }





            }













            //List<string> list2 = list.Split(',').ToList();

            //foreach (var x in list2)
            //{
            //    Exercise item = await _repocontextExer.GetByIDAsync(x);
            //    Exercises.Add(item);

            //}

            return Page();

            //  List<string>


        }





        public async Task<IActionResult> OnPostUpdateTraking(string id , bool Iscomplete)
        {

           Tracking tracking=await _repoTraking.GetByIDAsync(id);


            _repoTraking.UpdateEntityAsync(tracking);



            return Page();
        }





    }
}

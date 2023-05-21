#nullable disable
namespace liaqati_master.Pages.SportProgram
{
    public class IndexModel : PageModel
    {
        readonly IRepoProgram _context;
        readonly IRepoProgramExercies _repocontext;
        readonly IRepoExercise _repocontextExer;

        public IndexModel(IRepoProgram context, IRepoProgramExercies repocontext, IRepoExercise repocontextExer)
        {
            _context = context;
            _repocontext = repocontext;
            _repocontextExer = repocontextExer;
            BodyFoucs = Database.GetListOfBodyFocus().Select(b => b.Value).ToList();
            TraningType = Database.GetListOfTrainingType().Select(b => b.Value).ToList();
            Equipment = Database.GetListOfEquipment().Select(b => b.Value).ToList();
            Difficulty = Database.GetListOfDifficulty().Select(b => b.Value).ToList();
            Length = Database.GetListOfProgramLength().Select(b => b.Value).ToList();
        }



        [BindProperty(SupportsGet = true)]
        public List<SportsProgram> Sports { get; set; }

        public List<string> BodyFoucs { get; set; }
        public List<string> TraningType { get; set; }
        public List<string> Difficulty { get; set; }
        public List<string> Equipment { get; set; }
        public List<string> Length { get; set; }


        public List<SelectListItem> Duration { get; set; } = new List<SelectListItem>() {
            new SelectListItem("43","43"),
            new SelectListItem("26","26"),
            new SelectListItem("45","45"),
            new SelectListItem("37","37")

        };
        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value="RateId",Text="«·√⁄·Ï  ﬁÌ„«"},
            new SelectListItem(){Value="exerciseDate",Text="«·√ÕœÀ"},
        };


        [BindProperty(SupportsGet = true)]
        public ExerciseQueryParamters queryParameters { get; set; }

        public async Task OnGet()
        {

            //Sports = await _context.GetAllProgram();


            //foreach (var s in Sports)
            //{

            //    s.Services!.Category = null;
            //    s.Services!.SportsProgram = null;
            //    if (s.Exercies_Programs is not null)
            //    {
            //        foreach (var ss in s.Exercies_Programs)
            //        {

            //            ss.SportsProgram = null;

            //        }
            //    }


            //}

        }

    }
}

using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.SportProgram
{
    public class ProgramDetailsModel : PageModel
    {

        readonly IRepoProgram _repoProgram;
        readonly IRepoProgramExercies _repocontext;
        readonly IRepoArticles _repoArticles;
        readonly IRepoExercise _repocontextExer;
        readonly LiaqatiDBContext _context;

        public ProgramDetailsModel(LiaqatiDBContext context, IRepoArticles repoArticel, IRepoProgram repoProgram, IRepoProgramExercies repocontext, IRepoExercise repocontextExer)
        {
            _repoProgram = repoProgram;
            _repocontext = repocontext;
            _repocontextExer = repocontextExer;
            _context = context;
            _repoArticles = repoArticel;
        }
        [BindProperty]
        public SportsProgram sports { set; get; }

        public int days { get; set; }

        public List<Exercies_program> exercies_Programs { get; set; }

        public List<Article> Articles { get; set; }
        public List<HealthyRecipe> reicpes { get; set; }
        public List<Comment_Servies> comments { get; set; }
        public List<Exercise> exercises { get; set; } = new();



        public async Task OnGetAsync(string id)

        {

            try
            {
                sports = await _repoProgram.GetProgram(id);


                foreach (var item in sports.Exercies_Programs!)
                {
                    item.SportsProgram = null;

                }
                foreach (var item in sports.Exercies_Programs!)
                {
                    item.Exercise = null;

                }

                sports.Services.Category = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            sports.Services.SportsProgram = null;


            reicpes = _context.TblHealthyRecipe.Take(4).OrderBy(x => x).ToList();
            Articles = _context.TblArticles.Take(4).OrderBy(x => x).ToList();
            exercises = _context.TblExercises.Take(3).OrderBy(x => x).ToList();
            comments = _context.TblCommentServies.Take(3).OrderBy(x => x).ToList();
            days = sports.Length * 7;



        }
    }
}

using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.SportProgram
{
    public class IndexModel : PageModel
    {
        readonly IRepoProgram _context;
        readonly RepoProgramExercies _repocontext;
        readonly RepoExercises _repocontextExer;

        public IndexModel(IRepoProgram context, RepoProgramExercies repocontext, RepoExercises repocontextExer)
        {
            _context = context;
            _repocontext = repocontext;
            _repocontextExer = repocontextExer;
        }



        [BindProperty(SupportsGet = true)]
        public List<SportsProgram> Sports { get; set; }



        public async Task OnGet()
        {



            Sports = await _context.GetAllProgram();


            foreach (var s in Sports)
            {

                s.Services!.Category = null;
                s.Services!.SportsProgram = null;

                foreach (var ss in s.Exercies_Programs)
                {

                    ss.SportsProgram = null;

                }


            }









        }

    }
}

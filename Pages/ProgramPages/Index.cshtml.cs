using liaqati_master.Services.RepoCrud;
using liaqati_master.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.ProgramPages
{
    public class IndexModel : PageModel
    {
        readonly RepoProgram _context;
        readonly RepoProgramExercies _repocontext;
        readonly RepoExercises _repocontextExer;

        public IndexModel(RepoProgram context , RepoProgramExercies repocontext, RepoExercises repocontextExer)
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


            foreach(var s in Sports)
            {

                s.Services!.Category = null;
                s.Services!.sportsProgram = null;

                foreach (var ss in s.Exercies_Programs)
                {

                    ss.SportsProgram = null;

                }


                }









        }

    }
}

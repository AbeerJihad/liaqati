using liaqati_master.Services.RepoCrud;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.ProgramPages
{
    public class IndexModel : PageModel
    {
        readonly RepoProgram _context;

        public IndexModel(RepoProgram context)
        {
            _context = context;
        }


        [BindProperty(SupportsGet =true)]
        public List<SportsProgram> Sports { get; set; }

        [BindProperty(SupportsGet = true)]
        public SportsProgram SportsProgram { get; set; }


        public async Task OnGet()
        {

            Sports = await _context.GetAllProgram();


            foreach(var s in Sports)
            {
                s.Services.sportsProgram = null;
                s.Services.Category = null;

                foreach (var x in s.Exercies_Programs)
                {
                    x.SportsProgram = null;
                }

                }



        }

    }
}

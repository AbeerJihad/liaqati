using liaqati_master.Services.RepoCrud;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.ProgramPages
{
    public class ToDaycshtmlModel : PageModel
    {
        readonly RepoProgram _context;
        readonly RepoProgramExercies _repocontext;
        readonly RepoExercises _repocontextExer;

        public ToDaycshtmlModel(RepoProgram context, RepoProgramExercies repocontext, RepoExercises repocontextExer)
        {
            _context = context;
            _repocontext = repocontext;
            _repocontextExer = repocontextExer;
        }



        [BindProperty(SupportsGet = true)]
        public List<Exercise> Exercises { get; set; }






        public async Task<IActionResult> OnGet(string list)
        {
            List<string> list2= list.Split(',').ToList();

           foreach(var x in list2)
            {
            Exercise item  =await   _repocontextExer.GetExercises(x);
                Exercises.Add(item);

            }

           return Page();

          //  List<string>


        }
    }
}

using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.ProgramPages
{
    public class ToDaycshtmlModel : PageModel
    {
        readonly IRepoProgram _context;
        readonly IRepoProgramExercies _repocontext;
        readonly IRepoExercise _repocontextExer;

        public ToDaycshtmlModel(IRepoProgram context, IRepoProgramExercies repocontext, IRepoExercise repocontextExer)
        {
            _context = context;
            _repocontext = repocontext;
            _repocontextExer = repocontextExer;
        }



        [BindProperty(SupportsGet = true)]
        public List<Exercise> Exercises { get; set; }






        public async Task<IActionResult> OnGet(string list)
        {
            List<string> list2 = list.Split(',').ToList();

            foreach (var x in list2)
            {
                Exercise item = await _repocontextExer.GetByIDAsync(x);
                Exercises.Add(item);

            }

            return Page();

            //  List<string>


        }
    }
}

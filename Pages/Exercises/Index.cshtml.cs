using liaqati_master.Services.RepoCrud;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Exercises
{
    public class IndexModel : PageModel
    {
        readonly RepoExercises _repocontextExer;

        public IndexModel(RepoExercises repocontextExer)
        {
            _repocontextExer = repocontextExer;
        }



        [BindProperty(SupportsGet = true)]
        public List<Exercise> Exercises { get; set; }

        public async Task<IActionResult> OnGet()
        {
            Exercises=await _repocontextExer.GetAllExercises();

            return Page();
        }
    }
}

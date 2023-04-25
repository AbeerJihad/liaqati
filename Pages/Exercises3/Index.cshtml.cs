using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Exercises3
{
    public class IndexModel : PageModel
    {
        readonly IRepoExercise _repocontextExer;

        public IndexModel(IRepoExercise repocontextExer)
        {
            _repocontextExer = repocontextExer;
        }



        [BindProperty(SupportsGet = true)]
        public List<Exercise> Exercises { get; set; }

        public async Task<IActionResult> OnGet()
        {
            Exercises = (await _repocontextExer.GetAllAsync()).ToList();

            return Page();
        }
    }
}

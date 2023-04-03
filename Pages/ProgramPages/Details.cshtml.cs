using liaqati_master.Services.RepoCrud;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.ProgramPages
{
    public class DetailsModel : PageModel
    {
        readonly RepoExercises _repocontextExer;
        readonly LiaqatiDBContext _context;
        public DetailsModel(RepoExercises repocontextExer, LiaqatiDBContext context)
        {
            _repocontextExer = repocontextExer;
            _context = context;
        }


        [BindProperty(SupportsGet = true)]
        public Exercise Exercise { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<Exercise> ExerciseList { get; set; }


        public async Task<IActionResult> OnGet(string? id)
        {

            Exercise exercise=await _repocontextExer.GetExercises(id);

            if (exercise == null)
            {
                return NotFound();
            }


            Exercise = exercise;


          for(int l=0;l<3;l++)
            {
                ExerciseList.Add(_context.TblExercises.ToList()[l]);
            }


            return Page();
        }




    }
}

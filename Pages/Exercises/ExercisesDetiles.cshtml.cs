using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Exercises
{
    public class ExercisesDetilesModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IRepoExercise _repoExercise;
       public ExercisesDetilesModel(UnitOfWork unitOfWork, IRepoExercise repoExercise)
        {
            _unitOfWork = unitOfWork;
            _repoExercise = repoExercise;
        }

     
        public string Message { get; set; }
        public Exercise exercise = new Exercise();
     
        public async Task OnGetAsync(string id)
        {
            if (id != null)
            {
                exercise = await _repoExercise.GetByIDAsync(id);

                if (exercise == null)
                {
                    Message = "NotFound";
                }

            }


        }
    }
}

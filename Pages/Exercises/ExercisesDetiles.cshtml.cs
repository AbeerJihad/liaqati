#nullable disable
namespace liaqati_master.Pages.Exercises
{
    public class ExercisesDetilesModel : PageModel
    {
        private readonly IRepoExercise _repoExercise;
        public ExercisesDetilesModel(IRepoExercise repoExercise)
        {
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

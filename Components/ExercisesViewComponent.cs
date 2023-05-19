namespace liaqati_master.Components
{
    public class ExercisesViewComponent : ViewComponent
    {
        private readonly IRepoExercise _IRepoExercise;
        public ExercisesViewComponent(IRepoExercise repoExercise)
        {
            _IRepoExercise = repoExercise;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Exercise>? ListOfExercises = (await _IRepoExercise.GetAllAsync()).Take(4).ToList();
            return View(ListOfExercises);
        }

    }
}
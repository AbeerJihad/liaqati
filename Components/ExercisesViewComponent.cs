using Microsoft.AspNetCore.Mvc;

namespace liaqati_master.Components
{
    public class ExercisesViewComponent : ViewComponent
    {
        private readonly UnitOfWork _unitOfWork;
        public ExercisesViewComponent(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Exercise>? ListOfExercises = _unitOfWork.ExerciseRepository.Get().Take(4).ToList();
            return View(ListOfExercises);
        }

    }
}

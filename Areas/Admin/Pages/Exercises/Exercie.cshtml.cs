using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Pages.Exercises
{
    public class ExercieModel : PageModel
    {

        private readonly UnitOfWork _unitOfWork;

        public ExercieModel(UnitOfWork UnitOfWork)
        {
            _unitOfWork = UnitOfWork;
        }

        public IList<Exercise> Exercises { get; set; }
        public async Task OnGetAsync()
        {
            if (_unitOfWork != null)
            {

                Exercises = _unitOfWork.ExerciseRepository.GetAllEntity();
            }
        }
    }
}

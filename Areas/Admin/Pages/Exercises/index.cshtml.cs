using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace liaqati_master.Pages.Exercises
{
    public class indexExerciseModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;
        
        public indexExerciseModel(UnitOfWork UnitOfWork)
        {
            _unitOfWork = UnitOfWork;
        }

        public IList<Exercise> Exercises { get; set; }
        public async Task OnGetAsync()
        {
            if (_unitOfWork != null)
            {

                Exercises =  _unitOfWork.ExerciseRepository.GetAllEntity();
            }
        }
    }
}

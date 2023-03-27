using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Pages.Exercises
{
    public class ExerciesDetailsModel : PageModel
    {
        private readonly UnitOfWork _UnitOfWork;

        public ExerciesDetailsModel(UnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        [BindProperty(SupportsGet =true)]
        public Exercise Exercise { set; get; }


        public async Task<IActionResult> OnGet()
        {
            string id = "5aa7b21d-8112-41fe-8607-80b255b45bce";

            Exercise exercise = _UnitOfWork.ExerciseRepository.GetByID(id);
            if(exercise ==null)
            {
                return NotFound();
            }
            Exercise = exercise;

            return Page();
        }
    }
}

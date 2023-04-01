using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Pages.SportPrograms
{
    public class CalenderModel : PageModel
    {
        readonly UnitOfWork _unitOfWork;

        public CalenderModel(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [BindProperty(SupportsGet = true)]
        public string id { get; set; }

        public List<object> data { get; set; }

        public void OnGet()
        {
            SportsProgram program = _unitOfWork.SportsProgramRepository.GetByID(id);

            for (int i = 0; i < program.Exercies_Programs.Count; i++)
            {
                Exercise exercise = _unitOfWork.ExerciseRepository.GetByID(program.Exercies_Programs[i]);

                data.Add(new { Id = CommonMethods.Id_Guid(), name = exercise.Title });

            }




        }
    }
}

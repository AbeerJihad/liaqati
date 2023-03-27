using liaqati_master.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Pages.Programs
{
    public class CalenderModel : PageModel
    {
        readonly UnitOfWork _unitOfWork;

        public CalenderModel(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [BindProperty(SupportsGet =true)]
        public string id { get; set; }

        public List<object> data { get; set; }

        public void OnGet()
        {
            SportsProgram program= _unitOfWork.SportsProgramRepository.GetByID(id);

            for(int i = 0; i < program.exercies_Programs.Count;i++)
            {
                Exercise exercise = _unitOfWork.ExerciseRepository.GetByID(program.exercies_Programs[i]);

                data.Add(new { Id = Guid_Id.Id_Guid(),name= exercise.Title});

            }




        }
    }
}

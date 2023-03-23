using liaqati_master.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        readonly UnitOfWork _unitOfWork;

        public IndexModel(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public Exercise Exercises { get; set; }


        public void OnGet()
        {
        }


        public void OnPost()
        {
            Exercises.Id = Guid_Id.Id_Guid();
            Exercises.Image = "";

            _unitOfWork.ExerciseRepository.Insert(Exercises);

            _unitOfWork.Save();


        }
    }
}








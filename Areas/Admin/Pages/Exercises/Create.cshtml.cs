using liaqati_master.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Exercises
{
    public class CreateExerciseModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;
        private readonly IFormFileMang _repoFile;
        private readonly IFormFileMangVedio _repoFileVedio;

        public CreateExerciseModel(LiaqatiDBContext context, UnitOfWork unitOfWork, IFormFileMang repoFile, IFormFileMangVedio repoFileVedio)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
            _repoFile = repoFile;
            _repoFileVedio = repoFileVedio;
        }


        public IActionResult OnGet()
        {
            


          

            return Page();
        }
       


        [BindProperty]
        public Exercise Exercise { get; set; }

       


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAddAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}



            Exercise.Id = Guid_Id.Id_Guid();


          

            string oldurl = Exercise.Image;
            string oldurlvideo = Exercise.Video;

            if (Exercise.FormFile != null)
            {
                Exercise.Image = await _repoFile.Upload(Exercise.FormFile, "Exercise");

            }
            else
            {
                Exercise.Image = oldurl;
            }



            if (Exercise.FormFileVedio != null)
            {
                Exercise.Video = await _repoFileVedio.Upload(Exercise.FormFileVedio, "Exercise");

            }
            else
            {
                Exercise.Video = oldurlvideo;
            }





            _UnitOfWork.ExerciseRepository.Insert(Exercise);


            _UnitOfWork.Save();
            


            return RedirectToPage("./Index");
        }
    }
}

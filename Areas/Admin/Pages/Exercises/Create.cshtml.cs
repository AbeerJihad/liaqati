using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Pages.Exercises
{
    public class CreateExerciseModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;
        private readonly IFormFileMang _repoFile;
        private readonly IFormFileMangVideo _repoFileVedio;

        public CreateExerciseModel(LiaqatiDBContext context, UnitOfWork unitOfWork, IFormFileMang repoFile, IFormFileMangVideo repoFileVedio)
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
        [BindProperty]
        public IFormFile Image { get; set; }
        [BindProperty]
        public IFormFile Video { get; set; }

        public async Task<IActionResult> OnPostAddAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            Exercise.Id = Guid_Id.Id_Guid();
            string? oldurl = Exercise.Image;
            string? oldurlvideo = Exercise.Video;
            if (Image != null)
            {
                Exercise.Image = await _repoFile.Upload(Image, "Exercise");
            }
            else
            {
                Exercise.Image = oldurl;
            }
            if (Video != null)
            {
                Exercise.Video = await _repoFileVedio.Upload(Video, "Exercise");
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

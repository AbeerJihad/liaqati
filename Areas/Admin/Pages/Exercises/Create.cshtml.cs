namespace liaqati_master.Areas.Admin.Pages.Exercises
{
    public class CreateExerciseModel : PageModel
    {
        private readonly IRepoExercise _repoExercise;
        private readonly IFormFileMang _repoFile;

        public CreateExerciseModel(IRepoExercise repoExercise, IFormFileMang repoFile)
        {
            _repoExercise = repoExercise;
            _repoFile = repoFile;
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
            Exercise.Id = CommonMethods.Id_Guid();
            string? oldurl = Exercise.Image;
            string? oldurlvideo = Exercise.Video;
            if (Image != null)
            {
                Exercise.Image = await _repoFile.Upload(Image, "~/images/atricles", "Exercise");
            }
            else
            {
                Exercise.Image = oldurl;
            }
            if (Video != null)
            {
                Exercise.Video = await _repoFile.Upload(Video, "Video", "Exercise");
            }
            else
            {
                Exercise.Video = oldurlvideo;
            }
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null)
            {
                Exercise.UserId = userid;
            }

            await _repoExercise.AddEntityAsync(Exercise);
            return RedirectToPage("./Index");
        }
    }
}

namespace liaqati_master.Areas.Admin.Pages.Exercises
{
    public class EditExerciseModel : PageModel
    {
        private readonly IRepoExercise _repoExercise;
        private readonly IFormFileMang _repoFile;


        public EditExerciseModel(IRepoExercise repoExercise, IFormFileMang repoFile)
        {
            _repoExercise = repoExercise;
            _repoFile = repoFile;
        }
        [BindProperty(SupportsGet = true)]
        public Exercise Exercise { get; set; }
        [BindProperty]
        public IFormFile Image { get; set; }
        [BindProperty]
        public IFormFile Video { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercise = await _repoExercise.GetByIDAsync(id);
            if (exercise == null)
            {
                return NotFound();
            }
            Exercise = exercise;



            return Page();
        }

        public async Task<IActionResult> OnPost()
        {

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            var id = Exercise.Id;

            var item = await _repoExercise.GetByIDAsync(id);
            if (item is null)
            {
                return NotFound();
            }
            item.Title = Exercise.Title;
            item.Detail = Exercise.Detail;
            item.Duration = Exercise.Duration;
            item.Equipments = Exercise.Equipments;
            item.TraningType = Exercise.TraningType;
            item.Difficulty = Exercise.Difficulty;
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
            await _repoExercise.UpdateEntityAsync(item);


            //  _context.Attach(MealPlans).State = EntityState.Modified;


            return RedirectToPage("./Index");
        }


    }
}

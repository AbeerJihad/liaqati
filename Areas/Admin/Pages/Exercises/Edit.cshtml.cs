using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Pages.Exercises
{
    public class EditExerciseModel : PageModel
    {

        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;
        private readonly IFormFileMang _repoFile;
        private readonly IFormFileMangVideo _repoFileVedio;

        public EditExerciseModel(LiaqatiDBContext context, UnitOfWork unitOfWork, IFormFileMang repoFile, IFormFileMangVideo repoFileVedio)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
            _repoFile = repoFile;
            _repoFileVedio = repoFileVedio;
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

            var exercise = _UnitOfWork.ExerciseRepository.GetByID(id);
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

            var item = _UnitOfWork.ExerciseRepository.GetByID(id);

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
                item.Image = await _repoFile.Upload(Image, "Exercise");
            }
            else
            {
                item.Image = oldurl;
            }
            if (Video != null)
            {
                item.Video = await _repoFileVedio.Upload(Video, "Exercise");
            }
            else
            {
                item.Video = oldurlvideo;
            }

            _UnitOfWork.ExerciseRepository.Update(item);


            //  _context.Attach(MealPlans).State = EntityState.Modified;

            try
            {
                _UnitOfWork.Save();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(Exercise.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StudentExists(string id)
        {
            return _context.TblMealPlans.Any(e => e.Id == id);
        }
    }
}

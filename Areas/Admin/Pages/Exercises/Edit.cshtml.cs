using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Pages.Exercises
{
    public class EditExerciseModel : PageModel
    {

        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;
        private readonly IFormFileMang _repoFile;

        public EditExerciseModel(LiaqatiDBContext context, UnitOfWork unitOfWork, IFormFileMang repoFile)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
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
            string oldurl = Exercise.Image;
            string oldurlvideo = Exercise.Video;

            if (Exercise.FormFile != null)
            {
                Exercise.Image = await _repoFile.Upload(Exercise.FormFile, "Images", "Exercise");

            }
            else
            {
                Exercise.Image = oldurl;
            }



            if (Exercise.FormFileVedio != null)
            {
                Exercise.Video = await _repoFile.Upload(Exercise.FormFileVedio, "Vedio", "Exercise");

            }
            else
            {
                Exercise.Video = oldurlvideo;
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

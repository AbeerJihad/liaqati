using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Exercises
{
    public class IndexModel : PageModel
    {
        readonly IRepoExercise _repocontextExer;

        public IndexModel(IRepoExercise repocontextExer)
        {
            _repocontextExer = repocontextExer;
            BodyFoucs = Database.GetListOfBodyFocus().Select(b => b.Value).ToList();
            TraningType = Database.GetListOfTrainingType().Select(b => b.Value).ToList();
            Equipment = Database.GetListOfEquipment().Select(b => b.Value).ToList();
            Difficulty = Database.GetListOfDifficulty().Select(b => b.Value).ToList();
        }



        [BindProperty]
        public List<Exercise>? Exercises { get; set; }

        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value="RateId",Text="الأعلى تقيماً"},
            new SelectListItem(){Value="exerciseDate",Text="الأحدث"},
        };


        //  public List<string> BodyFoucs { get; set; } = new List<string>() { "الجسم بالكامل", "الجسم السفلي", "الجسم العلوي", "الجسم الوسط" };
        //public List<string> BodyFoucs { get; set; } = new List<string>() { "الجسم بالكامل", "الجسم السفلي", "الجسم العلوي", "الجسم الوسط" };
        public List<string> BodyFoucs { get; set; } //= new List<string>() { "الجسم بالكامل", "الجسم السفلي", "الجسم العلوي", "الجسم الوسط" };
        public List<string> TraningType { get; set; }// = new List<string>() { "لياقة", "اليوجا", "تدريب القوة", "الحركة" };
        public List<string> Difficulty { get; set; }
        public List<string> Equipment { get; set; } //= new List<string>() { "الجسم بالكامل", "الجسم السفلي", "الجسم العلوي", "الجسم الوسط" };

        public List<SelectListItem> Duration { get; set; } = new List<SelectListItem>() {
            new SelectListItem("43","43"),
            new SelectListItem("26","26"),
            new SelectListItem("45","45"),
            new SelectListItem("37","37")

        };

        [BindProperty(SupportsGet = true)]
        public ExerciseQueryParamters queryParameters { get; set; }

        public void OnPost()
        {


        }

        public async Task OnGet()
        {


        }
    }
}

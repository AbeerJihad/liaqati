using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Exercises2
{
    public class IndexModel : PageModel
    {
        readonly RepoExercises _repocontextExer;

        public IndexModel(RepoExercises repocontextExer)
        {
            _repocontextExer = repocontextExer;
        }



        [BindProperty]
        public List<Exercise>? Exercises { get; set; }

        public List<SelectListItem> Skills { get; set; } = new List<SelectListItem>() {
            new SelectListItem("JavaScript","JavaScript"),
            new SelectListItem("C#","C#"),
            new SelectListItem("Asp.Net","Asp.Net"),
            new SelectListItem("Front-End","Front-End")
        };


        public List<SelectListItem> BodyFoucs { get; set; } = new List<SelectListItem>() {
            new SelectListItem("الجسم العلوي","الجسم العلوي"),
            new SelectListItem("الجسم السفلي","الجسم السفلي"),
            new SelectListItem("الجسم بالكامل","الجسم بالكامل")

        };
        [BindProperty]
        public List<string>? MultiSection { get; set; }

        [BindProperty(SupportsGet = true)]
        public ExerciseQueryParamters queryParameters { get; set; }

        public void OnPost()
        {
            if (MultiSection != null)
            {
                //foreach (var item in SingleSection)
                //    if (!Skills.Exists(x => x.Value == item))
                //    {
                //        Skills.Add(new SelectListItem(item, item));
                //    }
            }

        }

        public async Task OnGet()
        {

            Exercises = await _repocontextExer.GetAllExercises();
            ////var url = $"https://localhost:7232/api/ExerciseApi/searchforExercise?BodyFocus=BodyFoucs&TraningType=&Difficulty=3&Equipment=&Duration=24";








            ////HttpResponseMessage response = await new HttpClient().GetAsync(url);
            ////Exercises = await response.Content.ReadFromJsonAsync<IEnumerable<Exercise>>();


            //////Exercises = await _repocontextExer.GetAllExercises();



            ////return Page();
        }
    }
}

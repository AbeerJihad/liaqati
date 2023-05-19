using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.SportProgram
{
    public class ClenderModel : PageModel
    {

        readonly IRepoProgram _repoProgram;
        readonly IRepoProgramExercies _repocontext;
        readonly IRepoExercise _repocontextExer;

        public ClenderModel(IRepoProgram repoProgram, IRepoProgramExercies repocontext, IRepoExercise repocontextExer)
        {
            _repoProgram = repoProgram;
            _repocontext = repocontext;
            _repocontextExer = repocontextExer;
        }


        [BindProperty(SupportsGet = true)]
        public List<SportsProgram> Sports { get; set; }

        [BindProperty(SupportsGet = true)]
        public SportsProgram SportsProgram { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<Event> Events { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ExerId { get; set; }
        public async Task<IActionResult> OnGet(string id)
        {

            Events = new List<Event>();
            List<DateOnly> dates = new();
            DateTime date = DateTime.Now;

            // var id = "7ff237a7-96df-4bed-b5d9-78ad69ae6ba3";
            SportsProgram sport = await _repoProgram.GetProgram(id);
            if (sport == null)
            {
                return NotFound();
            }
            var weeks = sport.Length;

            for (int b = 1; b <= weeks; b++)
            {
                for (int bb = 1; bb <= 7; bb++)
                {
                    List<Exercies_program> exercies_Programs = _repocontext.GetMultiExercies_program(sport.Id, b, bb);

                    if (exercies_Programs.Count > 0)
                    {

                        foreach (Exercies_program exercies in exercies_Programs)
                        {

                            Exercise ex = await _repocontextExer.GetByIDAsync(exercies.ExerciseId);


                            Events.Add(new Event() { Id = id, title = "", start = DateOnly.FromDateTime(date).ToString("yyyy-MM-dd") });

                        }
                    }

                    date = date.AddDays(1);
                }
            }
            return Page();

        }

    }
}




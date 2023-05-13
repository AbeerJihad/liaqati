using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Articles
{
    public class ArticleDetailModel : PageModel
    {
        readonly IRepoArticles _repoArticles;
        readonly IRepoExercise _repoExercise;

        public ArticleDetailModel(IRepoArticles repoArticles, IRepoExercise repoExercise)
        {
            _repoArticles = repoArticles;
            _repoExercise = repoExercise;
        }

        [BindProperty(SupportsGet = true)]
        public Article item { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<Article> Articles { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<Exercise> Exercises { get; set; }



        public async Task<IActionResult> OnGet(string id)
        {

            Articles = ((await _repoArticles.GetAllAsync()).Skip(0).Take(5)).ToList();
            Exercises = ((await _repoExercise.GetAllAsync()).Skip(0).Take(3)).ToList();



            if (id is null)
                return NotFound();

             item = await _repoArticles.GetByIDAsync(id);

            if(item == null)
                return NotFound();



            return Page();
        }
    }
}

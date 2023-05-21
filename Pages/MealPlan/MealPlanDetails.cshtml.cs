namespace liaqati_master.Pages.MealPlan
{
    public class MealPlanDetailsModel : PageModel
    {

        readonly IRepoMealPlans _repoMealPlan;
        readonly IRepoArticles _repoArticles;
        readonly IRepoExercise _repocontextExer;
        readonly LiaqatiDBContext _context;

        public MealPlanDetailsModel(LiaqatiDBContext context, IRepoArticles repoArticel, IRepoMealPlans repoMealPlan, IRepoExercise repocExer)
        {
            _repoArticles = repoArticel;
            _repocontextExer = repocExer;
            _repoMealPlan = repoMealPlan;
            _context = context;
        }


        [BindProperty]
        public MealPlans? mealplans { set; get; }

        public int days { get; set; }

        public List<Meal_Healthy> Meal_Healthy { get; set; }

        public List<Article> Articles { get; set; }
        public List<Comment_Servies> comments { get; set; }
        public List<Exercise> exercises { get; set; } = new();
        public async Task<IActionResult> OnGet(string id)
        {


            try
            {
                mealplans = await _repoMealPlan.GetByIDAsync(id);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Articles = _context.TblArticles.Take(4).OrderBy(x => x.Id).ToList();
            exercises = _context.TblExercises.Take(3).OrderBy(x => x.Id).ToList();
            comments = _context.TblCommentServies.Take(3).OrderBy(x => x.Id).ToList();
            days = (int)(mealplans.Length * 7);
            ////ala


            return Page();
        }
    }
}

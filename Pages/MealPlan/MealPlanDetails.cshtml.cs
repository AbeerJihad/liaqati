namespace liaqati_master.Pages.MealPlan
{
    public class MealPlanDetailsModel : PageModel
    {

        readonly IRepoMealPlans _repoMealPlan;
        readonly IRepoArticles _repoArticles;
        readonly IRepoComment_Servies _IRepoComment_Servies;
        readonly IRepoExercise _repocontextExer;
        readonly LiaqatiDBContext _context;

        public MealPlanDetailsModel(LiaqatiDBContext context, IRepoArticles repoArticel, IRepoMealPlans repoMealPlan, IRepoExercise repocExer, IRepoComment_Servies iRepoComment_Servies)
        {
            _repoArticles = repoArticel;
            _repocontextExer = repocExer;
            _repoMealPlan = repoMealPlan;
            _context = context;
            _IRepoComment_Servies = iRepoComment_Servies;
        }


        [BindProperty]
        public MealPlans? mealplans { set; get; }

        public int days { get; set; }

        public List<Meal_Healthy> Meal_Healthy { get; set; }

        public List<Article> Articles { get; set; }
        public List<Comment_Servies> comments { get; set; }
        public List<Exercise> exercises { get; set; } = new();
        public async Task OnGet(string id)
        {

            try
            {
                mealplans = await _repoMealPlan.GetByIDAsync(id);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Articles = (await _repoArticles.GetAllAsync()).Take(4).ToList();
            exercises = (await _repocontextExer.GetAllAsync()).Take(3).OrderBy(x => x).ToList();
            comments = (await _IRepoComment_Servies.GetAllAsync()).Take(3).OrderBy(x => x).ToList();
            days = (int)(mealplans.Length * 7);

        }
    }
}

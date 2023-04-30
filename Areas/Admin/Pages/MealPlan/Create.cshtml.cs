namespace liaqati_master.Pages.MealPlan
{
    public class CreateModel : PageModel
    {
        private readonly IRepoMealPlans _repoMealPlans;
        private readonly IRepoHealthyRecipe _repoHealthyRecipe;
        private readonly IRepoService _repoService;
        private readonly IRepoCategory _repoCategory;
        private readonly IRepoMeal_Healthy _repoMeal_Healthy;
        public CreateModel(IRepoMealPlans repoMealPlans, IRepoHealthyRecipe repoHealthyRecipe, IRepoCategory repoCategory, IRepoService repoService, IRepoMeal_Healthy repoMeal_Healthy)
        {
            _repoMealPlans = repoMealPlans;
            _repoHealthyRecipe = repoHealthyRecipe;
            _repoCategory = repoCategory;
            _repoService = repoService;
            _repoMeal_Healthy = repoMeal_Healthy;
        }
        public SelectList CatogeryName { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<VmCheckBox> lstCheckBox { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<VmCheckBox> lstCheckBoxDietaryType { get; set; }

        public List<string> MealType { get; set; } = Database.GetListOfMealType().Select(b => b.Value).ToList();
        public List<string> DietaryType { get; set; } = Database.GetListOfDietaryType().Select(b => b.Value).ToList();


        public string Display { get; set; } = "d-none";

        public int btnSave { get; set; }

        public async Task<IActionResult> OnGet()
        {

            foreach (var item in MealType)
            {
                lstCheckBox.Add(new VmCheckBox() { Name = item });

            }

            foreach (var item in DietaryType)
            {
                lstCheckBoxDietaryType.Add(new VmCheckBox() { Name = item });

            }










            Display = "d-none";
            btnSave = 0;


            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(
                 c => c.Target == Database.GetListOfTargets()[nameof(MealPlans)]),
                 nameof(Category.Id), nameof(Category.Name));


            return Page();
        }

        public async Task<HealthyRecipe?> getHealthyRecipe(string id)
        {
            HealthyRecipe? HealthyRecipe = await _repoHealthyRecipe.GetByIDAsync(id);

            return HealthyRecipe;
        }








        [BindProperty(SupportsGet = true)]
        public MealPlans MealPlan { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAddAsync()
        {


            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(
                 c => c.Target == Database.GetListOfTargets()[nameof(MealPlans)]),
                 nameof(Category.Id), nameof(Category.Name));
            if (!ModelState.IsValid)
            {
                return Page();
            }

            btnSave = 1;
            MealPlan.Id = CommonMethods.Id_Guid();

            MealPlan.Services!.Id = MealPlan.Id;
            MealPlan.MealType = string.Join(',', lstCheckBox.Where(ch => ch.IsChecked).Select(ch => ch.Name));
            MealPlan.DietaryType = string.Join(',', lstCheckBoxDietaryType.Where(ch => ch.IsChecked).Select(ch => ch.Name));
            MealPlan.Services.CategoryId = MealPlan.Services.CategoryId;

            await _repoService.AddEntityAsync(MealPlan.Services);
            await _repoMealPlans.AddEntityAsync(MealPlan);
            Display = "d-block";
            return Page();
        }

        public async Task<IActionResult> OnPostAddSystemAsync(string? id)
        {
            btnSave = 1;


            MealPlans? meals = await _repoMealPlans.GetByIDAsync(id);
            if (meals is null)
            {
                return NotFound();
            }

            //List<Meal_Healthy> list = new List<Meal_Healthy>();

            //foreach (Meal_Healthy x in _context.TblMeal_Healthy.ToList())
            //{
            //    if (x.MealPlansId == id)
            //    {
            //        list.Add(x);
            //    }

            //}
            MealPlan = meals;
            MealPlan.Meal_Healthy = (await _repoMeal_Healthy.GetByMealPlansIDAsync(id)).ToList();
            MealPlan.Meal_Healthy = MealPlan.Meal_Healthy!.OrderBy(x => x.Week).ThenBy(y => y.Day).ToList();
            Display = "d-block";
            return Page();
        }




    }
}

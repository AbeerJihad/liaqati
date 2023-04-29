namespace liaqati_master.Pages.MealPlan
{
    public class EditModel : PageModel
    {
        private readonly IRepoMealPlans _repoMealPlans;
        private readonly IRepoCategory _repoCategory;

        public EditModel(IRepoMealPlans repoMealPlans, IRepoCategory repoCategory)
        {
            _repoMealPlans = repoMealPlans;
            _repoCategory = repoCategory;
        }

        public SelectList CatogeryName { get; set; }


        [BindProperty(SupportsGet = true)]
        public MealPlans MealPlans { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meal = await _repoMealPlans.GetByIDAsync(id);
            if (meal == null)
            {
                return NotFound();
            }
            MealPlans = meal;


            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(
                 c => c.Target == Database.GetListOfTargets()[nameof(MealPlan)]),
                 nameof(Category.Id), nameof(Category.Name));


            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var id = MealPlans.Id;

            var item = await _repoMealPlans.GetByIDAsync(id);
            if (item is null)
            {
                return NotFound();
            }
            item.Services!.Title = MealPlans.Services!.Title;
            item.Services.Price = MealPlans.Services.Price;
            item.Services.Description = MealPlans.Services.Description;
            item.Length = MealPlans.Length;
            item.MealType = MealPlans.MealType;
            await _repoMealPlans.UpdateEntityAsync(item);
            //  _context.Attach(MealPlans).State = EntityState.Modified;

            return RedirectToPage("./Index");
        }


    }
}

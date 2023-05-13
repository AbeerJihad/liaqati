using liaqati_master.Services;
using liaqati_master.Services.Repositories;
using Microsoft.EntityFrameworkCore;

namespace liaqati_master.Pages.MealPlan
{
    public class EditModel : PageModel
    {
        private readonly IRepoMealPlans _repoMealPlans;
        private readonly IRepoHealthyRecipe _repoHealthyRecipe;
        private readonly IRepoCategory _repoCategory;
        private readonly IRepoMeal_Healthy _repoMeal_Healthy;
        private readonly LiaqatiDBContext _context;

        public EditModel(IRepoMealPlans repoMealPlans, IRepoCategory repoCategory, IRepoHealthyRecipe repoHealthyRecipe, IRepoMeal_Healthy repoMeal_Healthy, LiaqatiDBContext context)
        {
            _repoMealPlans = repoMealPlans;
            _repoCategory = repoCategory;
            _repoHealthyRecipe = repoHealthyRecipe;
            _repoMeal_Healthy = repoMeal_Healthy;
            _context = context;
        }

        public SelectList CatogeryName { get; set; }


        [BindProperty(SupportsGet = true)]
        public MealPlans MealPlans { get; set; }


        [BindProperty(SupportsGet = true)]
        public Meal_Healthy Meal_Healthy { get; set; }

        public List<SelectListItem> HealthyName { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<VmCheckBox> lstCheckBox { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<VmCheckBox> lstCheckBoxDietaryType { get; set; }

        public List<string> MealType { get; set; } = Database.GetListOfMealType().Select(b => b.Value).ToList();
        public List<string> DietaryType { get; set; } = Database.GetListOfDietaryType().Select(b => b.Value).ToList();







        public async Task<HealthyRecipe?> getHealthy(string id)
        {
            var Healthy = await _repoHealthyRecipe.GetByIDAsync(id);

            return Healthy;
        }






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
                 c => c.Target == Database.GetListOfTargets()[nameof(MealPlans)]),
                 nameof(Category.Id), nameof(Category.Name));


            HealthyName = (await _repoHealthyRecipe.GetAllAsync()).Select(a =>
                                       new SelectListItem
                                       {
                                           Value = a.Id.ToString(),
                                           Text = a.Title
                                       }).ToList();


            foreach (var item in DietaryType)
            {

                bool checksed = MealPlans.DietaryType.Contains(item);

                lstCheckBoxDietaryType.Add(new VmCheckBox() { Name = item ,IsChecked=checksed });

            }

            foreach (var item in MealType)
            {
                bool checksed = MealPlans.MealType.Contains(item);

                lstCheckBox.Add(new VmCheckBox() { Name = item, IsChecked = checksed });

            }

         




            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPost()
        {

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

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

            item.MealType = string.Join(',', lstCheckBox.Where(ch => ch.IsChecked).Select(ch => ch.Name));
            item.DietaryType = string.Join(',', lstCheckBoxDietaryType.Where(ch => ch.IsChecked).Select(ch => ch.Name));



            await _repoMealPlans.UpdateEntityAsync(item);
            //  _context.Attach(MealPlans).State = EntityState.Modified;

            return RedirectToPage("./Index");
        }


        public async Task<IActionResult> OnPostAddSystemAsync(string? id)
        {


            MealPlans sports =await _repoMealPlans.GetByIDAsync(id);
            List<Meal_Healthy> list = new List<Meal_Healthy>();

            foreach (Meal_Healthy x in _context.TblMeal_Healthy.ToList())
            {
                if (x.MealPlansId == id)
                {
                    list.Add(x);
                }

            }
            MealPlans = sports;
            MealPlans.Meal_Healthy = list;



            return Page();
        }


        public async Task<IActionResult> OnPostDeleteMealHealthy(string id)
        {


            if (id == null)
            {
                return NotFound();
            }

            Meal_Healthy x =await _repoMeal_Healthy.GetByIDAsync(id);


            MealPlans sport =  await _repoMealPlans.GetByIDAsync(x.MealPlansId);



            _repoMeal_Healthy.DeleteEntityAsync(id);
            _repoMealPlans.SaveAsync();


            return RedirectToPage("Edit", new { id = sport.Id });
        }

        public async Task<IActionResult> OnPostEditMealHealthy()
        {
            Meal_Healthy Meal_Health =await _repoMeal_Healthy.GetByIDAsync(Meal_Healthy.Id);

            Meal_Health.Day = Meal_Healthy.Day;
            Meal_Health.Week = Meal_Healthy.Week;
            Meal_Health.HealthyRecdpeId = Meal_Healthy.HealthyRecdpeId;

            _repoMeal_Healthy.UpdateEntityAsync(Meal_Health);
            _repoMeal_Healthy.SaveAsync();

            return RedirectToPage("Edit", new { id = Meal_Health.MealPlansId });
        }



    }
}

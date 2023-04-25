using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.HealthyReicpe
{
    public class EditHealthyModel : PageModel
    {

        private readonly LiaqatiDBContext _context;

        private readonly UnitOfWork _UnitOfWork;

        public EditHealthyModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
        }

        public List<SelectListItem> CatogeryName { get; set; }


        [BindProperty(SupportsGet = true)]
        public HealthyRecipe HealthyRecipes { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthyRecipes = _UnitOfWork.HealthyRecipesRepository.GetByID(id);
            if (healthyRecipes == null)
            {
                return NotFound();
            }
            HealthyRecipes = healthyRecipes;

            CatogeryName = _UnitOfWork.CategoryRepository.GetAllEntity().Select(a =>
                                       new SelectListItem
                                       {
                                           Value = a.Id.ToString(),
                                           Text = a.Name
                                       }).ToList();
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

            var id = HealthyRecipes.Id;
            var item = _UnitOfWork.HealthyRecipesRepository.GetByID(id);
            item!.Title = HealthyRecipes.Title;
            item.Price = HealthyRecipes.Price;
            item.Description = HealthyRecipes.Description;
            item.DietaryType = HealthyRecipes.DietaryType;
            item.MealType = HealthyRecipes.MealType;
            item.PrepTime = HealthyRecipes.PrepTime;
            item.Calories = HealthyRecipes.Calories;
            item.Total_Carbohydrate = HealthyRecipes.Total_Carbohydrate;
            item.Protein = HealthyRecipes.Protein;
            item.PreparationMethod = HealthyRecipes.PreparationMethod;
            item.Ingredients = HealthyRecipes.Ingredients;

            //var cid = HealthyRecipes.Category!.Id;
            //if (id != null)
            //{
            //    HealthyRecipes.CategoryId = id;

            //}
            _UnitOfWork.HealthyRecipesRepository.Update(item);
            //  _context.Attach(MealPlans).State = EntityState.Modified;
            try
            {
                _UnitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(HealthyRecipes.Id))
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

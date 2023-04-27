using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace liaqati_master.Pages.MealPlan
{
    public class CreateModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;

        public CreateModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
        }

        public List<SelectListItem> CatogeryName { get; set; }

        [BindProperty(SupportsGet =true)]
        public List<VmCheckBox> lstCheckBox { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<VmCheckBox> lstCheckBoxDietaryType { get; set; }



        

        public List<string> MealType { get; set; } = Database.GetListOfMealType().Select(b => b.Value).ToList();
        public List<string> DietaryType { get; set; } = Database.GetListOfDietaryType().Select(b => b.Value).ToList();


        public string Display { get; set; } = "d-none";

        public int btnSave { get; set; }

        public IActionResult OnGet()
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


            CatogeryName = _UnitOfWork.CategoryRepository.GetAllEntity().Select(a =>
                                         new SelectListItem
                                         {
                                             Value = a.Id.ToString(),
                                             Text = a.Name
                                         }).ToList();


            return Page();
        }

        public HealthyRecipe getHealthyRecipe(string id)
        {
            HealthyRecipe HealthyRecipe = _UnitOfWork.HealthyRecipesRepository.GetByID(id);

            return HealthyRecipe;
        }








        [BindProperty(SupportsGet = true)]
        public MealPlans MealPlans { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAddAsync()
        {


            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

           



            








            btnSave = 1;


            MealPlans.Id = CommonMethods.Id_Guid();

            MealPlans.Services!.Id = MealPlans.Id;
            MealPlans.MealType = string.Join(',', lstCheckBox.Where(ch => ch.IsChecked).Select(ch => ch.Name));

            MealPlans.DietaryType = string.Join(',', lstCheckBoxDietaryType.Where(ch => ch.IsChecked).Select(ch => ch.Name));





            MealPlans.Services.CategoryId = MealPlans.Services.CategoryId;






            _UnitOfWork.MealPlansRepository.Insert(MealPlans);
            _UnitOfWork.ServiceRepository.Insert(MealPlans.Services);


            _UnitOfWork.Save();

            Display = "d-block";

            return Page();
        }

        public async Task<IActionResult> OnPostAddSystemAsync(string? id)
        {
            btnSave = 1;


            MealPlans meals = _UnitOfWork.MealPlansRepository.GetByID(id);

            List<Meal_Healthy> list = new List<Meal_Healthy>();

            foreach (Meal_Healthy x in _context.TblMeal_Healthy.ToList())
            {
                if (x.MealPlansId == id)
                {
                    list.Add(x);
                }

            }
            MealPlans = meals;
            MealPlans.Meal_Healthy = list;

            MealPlans.Meal_Healthy = MealPlans.Meal_Healthy!.OrderBy(x => x.Week).ThenBy(y => y.Day).ToList();


            Display = "d-block";

            return Page();
        }




    }
}

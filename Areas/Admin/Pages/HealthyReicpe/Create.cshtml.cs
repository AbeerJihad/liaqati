namespace liaqati_master.Pages.HealthyReicpe
{
    public class CreateHealthyModel : PageModel
    {
        private readonly IRepoHealthyRecipe _repoHealthyRecipe;

        public CreateHealthyModel(IRepoHealthyRecipe repoHealthyRecipe)
        {
            DietaryTypeStatusList = Database.GetListOfDietaryType();
            MealTypeTypeStatusList = Database.GetListOfMealType();
            _repoHealthyRecipe = repoHealthyRecipe;
        }

        public List<SelectListItem> DietaryTypeStatusList { get; set; }
        public List<SelectListItem> MealTypeTypeStatusList { get; set; }



        [BindProperty]
        public HealthyRecipe HealthyRecipes { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<VmCheckBox> lstCheckBox { get; set; }
        public List<string> MealType { get; set; } = Database.GetListOfMealType().Select(b => b.Value).ToList();






        public IActionResult OnGet()
        {
            foreach (var item in MealType)
            {
                lstCheckBox.Add(new VmCheckBox() { Name = item });

            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var guid = CommonMethods.Id_Guid();
            HealthyRecipes.Id = guid;
            HealthyRecipes!.Id = guid;
            //var id = HealthyRecipes.Category?.Id;

            //if (id != null)
            //{
            //    HealthyRecipes.CategoryId = id;
            //}
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null)
            {
                HealthyRecipes.UserId = userid;
            }

            HealthyRecipes.MealType = string.Join(',', lstCheckBox.Where(ch => ch.IsChecked).Select(ch => ch.Name));
            HealthyRecipes.Image = "";
            await _repoHealthyRecipe.AddEntityAsync(HealthyRecipes);
            return RedirectToPage("./Index");
        }
    }
}

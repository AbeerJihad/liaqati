using Microsoft.AspNetCore.Mvc.RazorPages;


namespace liaqati_master.Pages.HealthyReicpe
{
    public class IndexHealthyModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;

        public IndexHealthyModel(UnitOfWork UnitOfWork)
        {
            _unitOfWork = UnitOfWork;
        }

        public IList<HealthyRecipe> HealthyRecipes { get; set; }
        public async Task OnGetAsync()
        {
            if (_unitOfWork != null)
            {

                HealthyRecipes = _unitOfWork.HealthyRecipesRepository.GetAllEntity();
            }
        }
    }
}

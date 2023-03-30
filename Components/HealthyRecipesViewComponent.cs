using Microsoft.AspNetCore.Mvc;

namespace liaqati_master.Components
{
    public class HealthyRecipesViewComponent : ViewComponent
    {
        private readonly UnitOfWork _unitOfWork;
        public HealthyRecipesViewComponent(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var healthyRecipes = _unitOfWork.HealthyRecipesRepository.Get().Take(8).ToList();
            return View(healthyRecipes);
        }

    }
}

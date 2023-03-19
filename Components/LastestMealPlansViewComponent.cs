using Microsoft.AspNetCore.Mvc;

namespace liaqati_master.Components
{
    public class LastestMealPlansViewComponent : ViewComponent
    {

        private readonly UnitOfWork _unitOfWork;


        public LastestMealPlansViewComponent(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var MealPlans = _unitOfWork.MealPlansRepository.Get().OrderBy(m => m.Id).Take(4).ToList();
            return View(MealPlans);
        }
    }
}

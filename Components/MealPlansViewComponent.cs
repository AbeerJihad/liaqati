namespace liaqati_master.Components
{
    public class MealPlansViewComponent : ViewComponent
    {
        private readonly UnitOfWork _unitOfWork;
        public MealPlansViewComponent(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<MealPlans>? ListOfMealPlans = _unitOfWork.MealPlansRepository.Get().Take(3).ToList();
            return View(ListOfMealPlans);
        }

    }
}

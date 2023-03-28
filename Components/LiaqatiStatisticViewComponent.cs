using liaqati_master.ViewModels;

namespace liaqati_master.Components
{
    public class LiaqatiStatisticViewComponent : ViewComponent
    {
        private readonly UnitOfWork unitOfWork;
        public LiaqatiStatisticViewComponent(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {


            return View(new LiaqatiStatisticViewModel() { NumberOfCoachs = 120, NumberOfMealPans = 120, PerNumberOfCoachs = 70, PerNumberOfMealPans = 60, NumberOfNormalUsers = 3000, PerNumberOfNormalUsers = 50 });
        }
    }
}

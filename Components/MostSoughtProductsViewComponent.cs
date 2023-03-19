using Microsoft.AspNetCore.Mvc;

namespace liaqati_master.Components
{
    public class MostSoughtProductsViewComponent : ViewComponent
    {
        private readonly UnitOfWork _unitOfWork;
        public MostSoughtProductsViewComponent(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ListOfExercises = _unitOfWork.ProductsRepository.Get().Where(p => p.services.Category.Name == "المكملات الغذائية").Take(2).ToList();
            return View(ListOfExercises);
        }

    }
}

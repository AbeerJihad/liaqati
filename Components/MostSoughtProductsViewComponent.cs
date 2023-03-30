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

        public async Task<IViewComponentResult> InvokeAsync(string CategoryID)
        {
            //     var a = _unitOfWork.Order_DetailsRepository.Get().GroupBy(o => o.ServiceId);
            var a = _unitOfWork.Order_DetailsRepository
                .Get(includeProperties: "Service")
                .Where(s => s.Service?.CategoryId == CategoryID)
                .GroupBy(info => info.ServiceId)
                .Select(group => new
                {
                    ServiceId = group.Key,
                    Count = group.Count()
                })
                .OrderByDescending(x => x.Count)
                .Take(2);

            List<Product> products = new();
            foreach (var prodIds in a)
            {
                products.Add(_unitOfWork.ProductsRepository.GetByID(prodIds.ServiceId));
            }
            return View(products);
        }

    }
}

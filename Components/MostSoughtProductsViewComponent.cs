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
            //var a = _unitOfWork.Order_DetailsRepository.Get().GroupBy(o => o.ServiceId);
            VMMostSoughtProducts vMMostSoughtProducts = new();
            List<Category> productCategories = _unitOfWork.CategoryRepository.GetAllEntity().Where(predicate: Category => Category.Target == "منتجات").ToList();
            if (productCategories.Any() && productCategories.Count >= 2)
            {
                vMMostSoughtProducts.ProductsOfCategorySupplementation = GetProducts(productCategories[0].Id);
                vMMostSoughtProducts.ProductsOfCategorySportsEquipment = GetProducts(productCategories[1].Id);
                vMMostSoughtProducts.ProductsCount = _unitOfWork.ProductsRepository.GetAllEntity().Count;
            }

            return View(vMMostSoughtProducts);
        }
        private List<Product> GetProducts(string CategoryID)
        {
            List<Product> products = new();

            var a = _unitOfWork.Order_DetailsRepository.GetAllEntity().Where(s => s.Service?.CategoryId == CategoryID)
               .GroupBy(info => info.ServiceId)
            .Select(group => new
            {
                ServiceId = group.Key,
                Count = group.Count()
            })
            .OrderByDescending(x => x.Count)
            .Take(2);

            foreach (var prodIds in a)
            {
                products.Add(_unitOfWork.ProductsRepository.GetByID(prodIds.ServiceId));
            }
            return products;
        }

    }
}

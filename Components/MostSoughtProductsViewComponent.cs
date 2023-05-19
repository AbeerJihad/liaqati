namespace liaqati_master.Components
{
    public class MostSoughtProductsViewComponent : ViewComponent
    {
        private readonly IRepoProducts _IRepoProducts;
        private readonly IRepoCategory _IRepoCategory;
        private readonly IRepoOrder_Details _IRepoOrder_Details;
        public MostSoughtProductsViewComponent(IRepoProducts repoProducts, IRepoCategory iRepoCategory, IRepoOrder_Details iRepoOrder_Details)
        {
            _IRepoProducts = repoProducts;
            _IRepoCategory = iRepoCategory;
            _IRepoOrder_Details = iRepoOrder_Details;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var a = _unitOfWork.Order_DetailsRepository.Get().GroupBy(o => o.ServiceId);
            VMMostSoughtProducts vMMostSoughtProducts = new();
            List<Category> productCategories = (await _IRepoCategory.GetAllAsync()).Where(predicate: Category => Category.Target == "Product").ToList();
            if (productCategories.Any() && productCategories.Count >= 2)
            {
                vMMostSoughtProducts.ProductsOfCategorySupplementation = await GetProducts(productCategories[0].Id);
                vMMostSoughtProducts.ProductsOfCategorySportsEquipment = await GetProducts(productCategories[1].Id);
                vMMostSoughtProducts.ProductsCount = (await _IRepoProducts.GetAllAsync()).Count();
            }

            return View(vMMostSoughtProducts);
        }
        private async Task<List<Product?>> GetProducts(string CategoryID)
        {
            List<Product?> products = new();

            var a =
                (await _IRepoOrder_Details.GetAllAsync())
                .Where(s => s.Service?.CategoryId == CategoryID)
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
                products.Add(await _IRepoProducts.GetByIDAsync(prodIds.ServiceId));
            }
            return products;
        }

    }
}

namespace liaqati_master.Components
{
    public class GenericComponentProductViewComponent : ViewComponent
    {
        private readonly IRepoProducts _repoProducts;
        private readonly IRepoOrder_Details _repoOrders;
        public GenericComponentProductViewComponent(IRepoProducts repoProducts, IRepoOrder_Details repoOrders)
        {

            _repoProducts = repoProducts;
            _repoOrders = repoOrders;
        }


        public async Task<IViewComponentResult> InvokeAsync(int flag)
        {
            List<Product>? ListOfHealthyRecipe = new();

            if (flag == 0)
            {
                ViewData["ComponentTitle"] = "أحدث المنتجات";
                ListOfHealthyRecipe = (await _repoProducts.GetAllAsync()).OrderByDescending(Product => Product.Services?.CreatedDate).Take(4).ToList();
            }
            else if (flag == 1)
            {
                ViewData["ComponentTitle"] = "الأكثر طلبا";
                ListOfHealthyRecipe = (await _repoProducts.GetAllAsync()).OrderByDescending(Product => Product.Services?.RatePercentage).Take(4).ToList();
                List<Product> products = new();
                var a = (await _repoOrders.GetAllAsync())
                   .GroupBy(info => info.ServiceId)
                .Select(group => new
                {
                    ServiceId = group.Key,
                    Count = group.Count()
                })
                .OrderByDescending(x => x.Count)
                .Take(2);

                foreach (var prod in a)
                {
                    Product? product = await _repoProducts.GetByIDAsync(prod.ServiceId);
                    if (product is not null)
                    {

                        products.Add(product);
                    }
                }
            }
            else if (flag == 2)
            {
                ViewData["ComponentTitle"] = "مميزة";
                ListOfHealthyRecipe = (await _repoProducts.GetAllAsync()).Where(Product => Product.Services?.IsFeatured ?? false).Take(4).ToList();
            }
            return View(ListOfHealthyRecipe);
        }

    }
}

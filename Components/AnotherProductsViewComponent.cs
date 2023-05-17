namespace liaqati_master.Components
{
    public class AnotherProductsViewComponent : ViewComponent
    {
        private readonly IRepoProducts _repoProducts;
        public AnotherProductsViewComponent(IRepoProducts repoProducts)
        {
            _repoProducts = repoProducts;
        }

        public async Task<IViewComponentResult> InvokeAsync(string? CID)
        {

            IQueryable<ProductVM>? ListOfProduct = ((await _repoProducts.GetAllAsync()).Select(p =>
            new ProductVM()
            {
                CategoryName = p.Services?.Category?.Name,
                Id = p.Id,
                Images = p.Services?.Files?.Select(p => p.Path)?.ToList(),
                CategoryId = p.Services?.CategoryId,
                Discount = p.Discount,
                PercentageRate = p.Services?.RatePercentage,
                Price = p.Services?.Price,
                Title = p.Services?.Title

            }).Take(4)).AsQueryable();
            if (CID != null)
            {
                ListOfProduct = ListOfProduct.Where(p => p.CategoryId == CID);
            }
            return View(ListOfProduct.ToList());
        }

    }
}
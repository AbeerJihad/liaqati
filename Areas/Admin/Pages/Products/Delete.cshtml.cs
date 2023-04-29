namespace liaqati_master.Pages.Products
{
    public class DeleteProductModel : PageModel
    {
        private readonly IRepoProducts _repoProducts;

        public DeleteProductModel(IRepoProducts repoProducts)
        {
            _repoProducts = repoProducts;
        }

        [BindProperty]
        public Product? Product { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var product = await _repoProducts.GetByIDAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            else
            {
                Product = product;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == null || _repoProducts == null)
            {
                return NotFound();
            }

            var product = await _repoProducts.GetByIDAsync(id);

            if (product != null)
            {
                Product = product;

                await _repoProducts.DeleteEntityAsync(product);
            }

            return RedirectToPage("./Index");
        }
    }
}

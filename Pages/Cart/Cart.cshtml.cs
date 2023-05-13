namespace liaqati_master.Pages.Cart
{
    public class CartModel : PageModel
    {
        private readonly IRepoCart repoCart;

        public CartModel(IRepoCart repoCart)
        {
            this.repoCart = repoCart;
        }


        public List<CartItem>? CartItems { get; set; }
        public double? Total { get; set; }
        public async Task OnGetAsync()
        {
            Total = (await repoCart.GetCartItems()).Sum(cart => cart.Quantity * cart.UnitPrice);
            CartItems = await repoCart.GetCartItems();
        }
        public async Task<IActionResult> OnPostIncreaseAsync(string id)
        {
            await repoCart.AddToCart(id);
            return RedirectToPage();


        }
        public async Task<IActionResult> OnPostDecreaseAsync(string id)
        {
            await repoCart.RemoveItem(id);
            return RedirectToPage();

        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            await repoCart.RemoveItemFromCart(id);
            return RedirectToPage();

        }
    }
}

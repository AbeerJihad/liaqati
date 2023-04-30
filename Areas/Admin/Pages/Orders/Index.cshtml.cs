namespace liaqati_master.Areas.Admin.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly IRepoOrder _repoOrder;

        public IndexModel(IRepoOrder repoOrder)
        {
            _repoOrder = repoOrder;
        }

        public IList<Order> Orders { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (_repoOrder == null)
            {
                return NotFound();
            }
            Orders = (await _repoOrder.GetAllAsync()).ToList();
            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _repoOrder.GetByIDAsync(id);

            if (order != null)
            {
                await _repoOrder.DeleteEntityAsync(order);
            }

            return RedirectToPage("./Index");
        }
    }
}

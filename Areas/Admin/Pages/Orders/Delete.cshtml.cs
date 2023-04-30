namespace liaqati_master.Areas.Admin.Pages.Orders
{
    public class DeleteModel : PageModel
    {
        private readonly IRepoOrder _repoOrder;

        public DeleteModel(IRepoOrder repoOrder)
        {
            _repoOrder = repoOrder;
        }

        [BindProperty]
        public Order? Order { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _repoOrder.GetByIDAsync(id);

            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _repoOrder.GetByIDAsync(id);

            if (Order != null)
            {
                await _repoOrder.DeleteEntityAsync(Order);
            }

            return RedirectToPage("./Index");
        }
    }
}

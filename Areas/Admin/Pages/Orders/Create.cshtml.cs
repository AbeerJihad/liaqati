namespace liaqati_master.Areas.Admin.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly IRepoOrder _repoOrder;

        public CreateModel(IRepoOrder repoOrder)
        {
            _repoOrder = repoOrder;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Order Order { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _repoOrder.AddEntityAsync(Order);
            return RedirectToPage("./Index");
        }
    }
}

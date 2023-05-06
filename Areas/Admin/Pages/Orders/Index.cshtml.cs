namespace liaqati_master.Areas.Admin.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly IRepoOrder _repoOrder;

        public IndexModel(IRepoOrder repoOrder)
        {
            _repoOrder = repoOrder;
        }

        [BindProperty(SupportsGet = true)]
        public OrdersQueryParamters OrdersQueryParamters { get; set; }
        public QueryPageResult<Order> QueryPageResult { get; set; }
        public IEnumerable<SelectListItem> lstPageSize { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem(){Value="5", Text="5"},
            new SelectListItem(){Value="10", Text="10"},
            new SelectListItem(){Value="20", Text="20"}
        };
        public IList<Order> Orders { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            //if (_repoOrder == null)
            //{
            //    return NotFound();
            //}
            Orders = (await _repoOrder.GetAllAsync()).ToList();

            if (_repoOrder != null)
            {
                QueryPageResult = await _repoOrder.SearchOrder(OrdersQueryParamters);
            }

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

#nullable disable
namespace liaqati_master.Areas.Admin.Pages.Sales
{
    public class IndexModel : PageModel
    {
        private readonly IRepoOrder_Details _repoOrder;
        public IndexModel(IRepoOrder_Details repoOrder)
        {
            _repoOrder = repoOrder;
        }
        [BindProperty(SupportsGet = true)]
        public OrdersDetailsQueryParamters OrdersDetailsQueryParamters { get; set; }
        public QueryPageResult<Order_Details> QueryPageResult { get; set; }
        public IEnumerable<SelectListItem> lstPageSize { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem(){Value="5", Text="5"},
            new SelectListItem(){Value="10", Text="10"},
            new SelectListItem(){Value="20", Text="20"}
        };

        public async Task<IActionResult> OnGetAsync()
        {
            if (_repoOrder == null)
            {
                return NotFound();
            }
            if (_repoOrder != null)
            {
                if (User.FindFirstValue(Database.Expert) != null)
                {
                    var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    OrdersDetailsQueryParamters.UserId = userid;
                }

                QueryPageResult = await _repoOrder.SearchOrder(OrdersDetailsQueryParamters);
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

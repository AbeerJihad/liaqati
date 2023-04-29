namespace liaqati_master.Areas.Admin.Pages.Orders
{
    public class DeleteModel : PageModel
    {
        private readonly liaqati_master.Data.LiaqatiDBContext _context;

        public DeleteModel(liaqati_master.Data.LiaqatiDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.TblOrder
                .Include(o => o.User).FirstOrDefaultAsync(m => m.Id == id);

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

            Order = await _context.TblOrder.FindAsync(id);

            if (Order != null)
            {
                _context.TblOrder.Remove(Order);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

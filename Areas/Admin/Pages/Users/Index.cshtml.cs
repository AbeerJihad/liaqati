using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Administrator.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<User> _userManager;

        public IndexModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public List<User> Users { get; set; }
        public async Task OnGetAsync()
        {
            Users = await _userManager.Users.ToListAsync();
        }
    }
}

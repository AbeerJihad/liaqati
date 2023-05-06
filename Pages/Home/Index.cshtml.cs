using Microsoft.AspNetCore.Authorization;

namespace liaqati_master.Pages.Home
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

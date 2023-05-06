using Microsoft.AspNetCore.Authorization;

namespace liaqati_master.Pages.Articles
{
    public class IndexModel : PageModel
    {
        [AllowAnonymous]
        public void OnGet()
        {
        }
    }
}

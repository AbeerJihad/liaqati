using System.Security.Claims;

namespace liaqati_master.Pages.ContactUs
{
    [AllowAnonymous]

    public class IndexModel : PageModel
    {
        private readonly IRepoContactUs _repoContactUs;
        private readonly SignInManager<User> _signInManager;

        public IndexModel(IRepoContactUs repoContactUs, SignInManager<User> signInManager)
        {
            _repoContactUs = repoContactUs;
            _signInManager = signInManager;
        }

        [BindProperty]
        public Models.ContactUs ContactUs { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (ContactUs != null)
                {
                    if (_signInManager.IsSignedIn(User))
                    {
                        ContactUs.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                        await _repoContactUs.AddEntityAsync(ContactUs);

                    }
                    else
                    {
                        return RedirectToPage("/Account/Login", new { area = "Identity" });
                    }
                }
            }
            return Page();
        }

    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Accounts
{
    public class LoginModel : PageModel
    {
        public SignInManager<User> SignInManager;
        public ILogger<LoginModel> Logger;
        public UserManager<User> UserManager;
        public LoginModel(SignInManager<User> signInManager, ILogger<LoginModel> logger, UserManager<User> userManager)
        {
            SignInManager = signInManager;
            Logger = logger;
            UserManager = userManager;
        }

        public class LogInputModel
        {
            [Required(ErrorMessage = "{0} الرجاء إدخال")]
            [Display(Name = "البريد الإلكتروني")]
            [EmailAddress]
            public string Email { get; set; }

            [Required(ErrorMessage = "{0} الرجاء إدخال")]
            [Display(Name = "كلمة المرور")]
            [DataType(DataType.Password)]
            [StringLength(100, ErrorMessage = "Enter at least {2} characters", MinimumLength = 6)]
            public string Password { get; set; }
            [Display(Name = "تذكرني")]
            public bool RememberMe { get; set; }
        }

        [BindProperty]
        public LogInputModel Input { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? retUrl { get; set; }
        public async Task<IActionResult> OnPostLogoutAsync()
        {
            await SignInManager.SignOutAsync();
            Logger.LogInformation("User logged out.");
            return RedirectToPage("/Home/index");
        }
        public async Task<IActionResult> OnPost()
        {
            retUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {

                var result = await SignInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, false);

                var user = await UserManager.FindByEmailAsync(Input.Email);
                var roles = await UserManager.GetRolesAsync(user);
                if (result.Succeeded)
                {
                    Logger.LogInformation($"User {Input.Email} logged in.");
                    //return RedirectToPage(retUrl);
                    return LocalRedirect(retUrl);
                }
                else if (result.IsLockedOut)
                {
                    Logger.LogInformation($"User {Input.Email} is locked out");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError("", "Wrong user name or password.");

                }

            }


            return Page();
        }


    }
}

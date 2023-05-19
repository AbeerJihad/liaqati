using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.WebUtilities;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace liaqati_master.Pages.Accounts
{
    [AllowAnonymous]
    public class SignUpModel : PageModel
    {

        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<SignUpModel> _logger;
        private readonly MyEmailService _emailSender;


        public SignUpModel(SignInManager<User> signInManager, ILogger<SignUpModel> logger, UserManager<User> userManager, MyEmailService appEmailService, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _logger = logger;
            _userManager = userManager;
            _emailSender = appEmailService;
            _roleManager = roleManager;
        }
        public class SignUpInputModel
        {
            [Required]
            [Display(Name = "الإسم الأول")]
            public string FirstName { get; set; }
            [Required]
            [Display(Name = "الإسم الثاني")]
            public string LastName { get; set; }
            [Required]
            [Display(Name = "بريدك الإلكتروني")]
            [EmailAddress]
            public string Email { get; set; }
            [Required]
            [Display(Name = "هاتفك")]
            public string PhoneNumber { get; set; }
            [Required]
            [Display(Name = "كلمة المرور")]
            [DataType(DataType.Password)]
            public string Password { get; set; }
            [Required]
            [Display(Name = "تأكيد كلمة المرور")]
            [Compare(nameof(Password), ErrorMessage = "لا يوجد تطابق مع كلمة المرور التي قمت بإدخالها")]
            [DataType(DataType.Password)]
            public string ConfirmPassword { get; set; }
            [Display(Name = "هل تود الإنضمام كخبير لياقة؟")]
            public bool IsAnExpert { get; set; }
            //   public bool IAgree { get; set; }
        }

        [BindProperty]
        public SignUpInputModel InputModel { get; set; }
        public string ReturnUrl { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public async Task OnGetAsync(string? returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

        }
        public async Task<IActionResult> OnPostAsync(string? returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                //if (!InputModel.IAgree)
                //{
                //    ModelState.AddModelError(string.Empty, "You must agree on the webiste rules and terms.");
                //    return Page();
                //}

                User n_user = new() { Fname = InputModel.FirstName, Lname = InputModel.LastName, UserName = InputModel.Email, Email = InputModel.Email, PhoneNumber = InputModel.PhoneNumber };

                var result = await _userManager.CreateAsync(n_user, InputModel.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account");

                    var claim = new Claim("UserType", "Client");
                    await _userManager.AddClaimAsync(n_user, claim);
                    var userId = await _userManager.GetUserIdAsync(user: n_user);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(n_user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page("/Account/ConfirmEmail", pageHandler: null, values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl }, protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(InputModel.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = InputModel.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(n_user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }


                await _signInManager.SignInAsync(n_user, isPersistent: false);


                return RedirectToPage("/Home/index");


            }

            return Page();
        }
    }
}

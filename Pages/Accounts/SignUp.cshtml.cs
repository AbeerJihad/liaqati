using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportProductsWeb.Services;

namespace liaqati_master.Pages.Accounts
{
    public class SignUpModel : PageModel
    {

        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<SignUpModel> _logger;
        private readonly AppEmailService _AppEmailService;


        public SignUpModel(SignInManager<User> signInManager, ILogger<SignUpModel> logger, UserManager<User> userManager, AppEmailService appEmailService, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _logger = logger;
            _userManager = userManager;
            _AppEmailService = appEmailService;
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
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {

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
                    if (InputModel.IsAnExpert)
                    {
                        if (await _roleManager.RoleExistsAsync("Trainer"))
                        {
                            IdentityRole role = new() { Name = "Trainer" };
                            await _roleManager.CreateAsync(role);
                            await _userManager.AddToRoleAsync(n_user, "Trainer");
                        }
                        else
                        {

                            await _userManager.AddToRoleAsync(n_user, "Trainer");
                        }
                    }

                    //var userId = await _userManager.GetUserIdAsync(n_user);
                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(n_user);

                    //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                    //var url = Url.Page("/Accounts/ConfirmEmail",
                    //    pageHandler: null,
                    //    values: new
                    //    {
                    //        area = "Portal",
                    //        userId = userId,
                    //        code = code
                    //    },
                    //    protocol: Request.Scheme);

                    //await _AppEmailService.SendEmailAsync(n_user.Email, "Confirm your email", $"Please confirm your email by <a href='{HtmlEncoder.Default.Encode(url)}'></a>");
                    //if (_userManager.Options.SignIn.RequireConfirmedEmail)
                    //{
                    //    return RedirectToPage("RegisterConfirm", new { email = InputModel.Email, retUrl = "" });
                    //}
                    //else
                    //{
                    //    await _signInManager.SignInAsync(n_user, isPersistent: false);
                    //}

                    await _signInManager.SignInAsync(n_user, isPersistent: false);




                    return RedirectToPage("/Home/index");
                }

                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }

            }

            return Page();
        }
    }
}

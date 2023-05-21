// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this File to you under the MIT license.
#nullable disable

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using static liaqati_master.Areas.Admin.Pages.Profile.IndexModel;

namespace liaqati_master.Areas.Identity.Pages.Account
{
    public class ChangePasswordModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        readonly SignInManager<User> _SignInManager;

        public ChangePasswordModel(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _SignInManager = signInManager;
        }

        [BindProperty]
        public ChangePassWord model { get; set; }

      





        public IActionResult OnGet()
        {
           return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (model != null)
            {

                var user = await _userManager.GetUserAsync(User);

                IdentityResult identityResult = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.Password);
                if (identityResult.Succeeded)
                {
                    await _SignInManager.RefreshSignInAsync(user);
                    return Page();

                }
                else
                {
                    foreach (var item in identityResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, item.Description);
                    }
                }

            }
            return Page();



        }
    }
}

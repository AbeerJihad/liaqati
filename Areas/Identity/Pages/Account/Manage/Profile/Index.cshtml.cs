namespace liaqati_master.Areas.Admin.Pages.Profile
{
    [Authorize()]
    public class IndexModel : PageModel
    {
        readonly IRepoUser _IRepoUser;
        readonly UserManager<User> _usermangaer;
        readonly SignInManager<User> _SignInManager;
        public IRepoNotification _repoNotification;



        public IndexModel(IRepoUser IRepoUser, UserManager<User> usermangaer, SignInManager<User> signInManager, IRepoNotification repoNotification)
        {
            _IRepoUser = IRepoUser;
            _usermangaer = usermangaer;
            _SignInManager = signInManager;
            _repoNotification = repoNotification;
        }

        [BindProperty]
        public Notification Notifications { get; set; }
        public IList<Notification> lstNotifications { get; set; } = default!;



        [BindProperty(SupportsGet = true)]
        public VMListNotification List { get; set; } = new VMListNotification();





        [BindProperty(SupportsGet = true)]
        public User? user { get; set; }






        [BindProperty(SupportsGet = true)]
        public ChangePassWord? model { get; set; }





        public async Task<IActionResult> OnPostDeleteAsync(string? id)
        {
            if (id == null || _repoNotification == null)
            {
                return NotFound();
            }

            var notifications = await _repoNotification.GetByIDAsync(id);

            if (notifications != null)
            {
                Notifications = notifications;
                await _repoNotification.DeleteEntityAsync(Notifications);
            }


            return RedirectToPage();
        }
        public async Task OnGetAsync()
        {

            var useritem = User;
            var userid = useritem.FindFirstValue(ClaimTypes.NameIdentifier);

            if (useritem != null)
            {
                user = await _IRepoUser.GetByIDAsync(userid);

                List<Notification> List2 = (await _repoNotification.GetAllAsync()).Where(p => p.UserId == userid).ToList();
                List<Notification> n = List2.Where(n => n.DATE == DateTime.Today).ToList();
                List.Today = n;
                List<Notification> nn = List2.Where(n => n.DATE == DateTime.Today.AddDays(-1)).ToList();
                List.yesterday = nn;
                List2 = List2.Where(n => n.DATE != DateTime.Today.AddDays(-1) && n.DATE == DateTime.Today).ToList();
                List.Other = List2;



            }





        }



        public async Task<IActionResult> OnPostUpdateProfile()
        {

            var user1 = await _IRepoUser.GetByIDAsync(user.Id);
            user1.Fname = user.Fname;
            user1.Lname = user.Lname;
            user1.Height = user.Height;
            user1.Wieght = user.Wieght;
            user1.Specialization = user.Specialization;
            user1.DateOfBirth = user.DateOfBirth;
            user1.PhoneNumber = user.PhoneNumber;




            await _IRepoUser.UpdateEntityAsync(user1);



            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostChangePassword()
        {

            if (model != null)
            {

                var user = await _usermangaer.GetUserAsync(User);

                IdentityResult identityResult = await _usermangaer.ChangePasswordAsync(user, model.CurrentPassword, model.Password);
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
            return RedirectToPage();



        }



    }
}

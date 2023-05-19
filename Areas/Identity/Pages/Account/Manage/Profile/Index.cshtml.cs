using System.Security.Claims;

namespace liaqati_master.Areas.Admin.Pages.Profile
{
    [Authorize()]
    public class IndexModel : PageModel
    {
        private readonly liaqati_master.Data.LiaqatiDBContext _context;
        readonly IHttpContextAccessor _HttpContextAccessor;
        readonly IRepoUser _IRepoUser;
        readonly UserManager<User> _usermangaer;
        readonly SignInManager<User> _SignInManager;
        public IRepoNotification _repoNotification;



        public IndexModel(liaqati_master.Data.LiaqatiDBContext context, IHttpContextAccessor httpContextAccessor, IRepoUser IRepoUser, UserManager<User> usermangaer, SignInManager<User> signInManager, IRepoNotification repoNotification)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
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


        public class ChangePassword
        {

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            public string CurrentPassword { get; set; }



            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            public string Password { get; set; }



            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }




        }




        [BindProperty(SupportsGet = true)]
        public ChangePassword? model { get; set; }





        public async Task<IActionResult> OnPostDeleteAsync(string? id)
        {
            if (id == null || _context.TblNotification == null)
            {
                return NotFound();
            }

            var notifications = await _context.TblNotification.FindAsync(id);

            if (notifications != null)
            {
                Notifications = notifications;
                _context.TblNotification.Remove(Notifications);
                await _context.SaveChangesAsync();
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




            _IRepoUser.UpdateEntityAsync(user1);



            return Page();
        }

        [HttpPost]
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
            return Page();



        }



    }
}

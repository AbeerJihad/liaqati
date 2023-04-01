using Microsoft.AspNetCore.Identity;

namespace liaqati_master.Components
{
    public class TrainersViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;
        public TrainersViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View((await _userManager.GetUsersInRoleAsync("Trainer")).ToList());
        }

    }
}

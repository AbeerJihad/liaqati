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
            var listOfUsers = (await _userManager.GetUsersInRoleAsync("Trainer")).Except(await _userManager.GetUsersInRoleAsync("Admin"));
            return View((listOfUsers).ToList());
        }

    }
}

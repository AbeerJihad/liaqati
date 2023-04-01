using Microsoft.AspNetCore.Identity;

namespace liaqati_master.Components
{
    public class LiaqatiStatisticViewComponent : ViewComponent
    {
        private readonly UnitOfWork unitOfWork;
        private readonly UserManager<User> userManager;
        private readonly LiaqatiDBContext dBContext;
        public LiaqatiStatisticViewComponent(UnitOfWork unitOfWork, UserManager<User> userManager, LiaqatiDBContext dBContext)
        {
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.dBContext = dBContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            int NumberOfUsers = (await dBContext.Users.ToListAsync()).Count;
            int NumberOfSerivces = (await dBContext.TblServices.ToListAsync()).Count;
            int NumberOfMealPlans = (await dBContext.TblMealPlans.ToListAsync()).Count;
            int NumberOfCoachs = (await userManager.GetUsersInRoleAsync("Trainer")).Count;
            int NumberOfCustomer = (await userManager.GetUsersInRoleAsync("Customer")).Count;
            return View(new VMLiaqatiStatistic()
            {
                NumberOfCoachs = NumberOfCoachs,
                NumberOfMealPans = NumberOfMealPlans,
                PerNumberOfCoachs = NumberOfUsers == 0 ? 0 : NumberOfCoachs / NumberOfUsers,
                PerNumberOfMealPans = NumberOfSerivces == 0 ? 0 : NumberOfMealPlans / NumberOfSerivces,
                NumberOfNormalUsers = NumberOfCustomer,
                PerNumberOfNormalUsers = NumberOfUsers == 0 ? 0 : NumberOfCustomer / NumberOfUsers
            });
        }
    }
}

using System.Globalization;

namespace liaqati_master.Areas.Admin.Pages.Dashboard
{
    public class IndexModel : PageModel
    {

        private readonly LiaqatiDBContext _dbContext;
        private readonly UserManager<User> _usermanager;

        public IndexModel(LiaqatiDBContext dbContext, UserManager<User> usermanager)
        {
            _dbContext = dbContext;
            _usermanager = usermanager;
        }

        public Counters CountersModel { get; set; } = new();
        public LastOrdersViewModel? LastestOrders { get; set; }


        public async Task OnGet()
        {


            CountersModel.SportProgramCount = await _dbContext.TblSportsProgram.CountAsync();
            CountersModel.MealPlanCount = await _dbContext.TblMealPlans.CountAsync();
            CountersModel.ExersiesCount = await _dbContext.TblExercises.CountAsync();
            CountersModel.HealthyCount = await _dbContext.TblHealthyRecipe.CountAsync();
            CountersModel.UsersCount = await _dbContext.Users.CountAsync();
            CountersModel.OrdersCount = await _dbContext.TblOrder.CountAsync();
            CountersModel.RevenuesTotal = await _dbContext.TblOrder.SumAsync(order => order.TotalPrice);
            CountersModel.ArticlesCount = await _dbContext.TblArticles.CountAsync();
            CountersModel.ProductsCount = await _dbContext.TblProducts.CountAsync();
            CountersModel.ExpertsCount = (await _usermanager.GetUsersForClaimAsync(new System.Security.Claims.Claim(Database.Expert, "true"))).Count;
            LastestOrders = new LastOrdersViewModel
            {
                Orders = await _dbContext.TblOrder.OrderByDescending(order => order.OrderDate).Take(5).ToListAsync(),
                NumderOfOrdersToday = await _dbContext.TblOrder.CountAsync(order => order.OrderDate == DateTime.Today)
            };

            var a2 =
                (await _dbContext.TblOrder.ToListAsync())
                .AsQueryable().Where(order => order.OrderDate > DateTime.Now.AddMonths(-6));
            var a3 = a2.GroupBy(a => new
            {
                Month = a.OrderDate.Value.Month,
            })
                .AsEnumerable()
                .Select(q => new
                {
                    Month = q.Key.Month,
                    Total = q.Select(a => a.TotalPrice).Sum(a => a)
                }).ToList();


            DateTime timebeforesixmonth = DateTime.Now.AddMonths(-6);
            var a = (await _dbContext.TblOrder.ToListAsync())
                .Where(o => o.OrderDate > timebeforesixmonth)
                .Select(date => date.OrderDate?.ToString("MMMM", new CultureInfo("ar-AE"))).Distinct().OrderByDescending(date => date);
            // .GroupBy(date => date)
            //.Select(group => new
            //{
            //    ServiceId = group.Key,

            //})
            //.OrderByDescending(x => x.Count)
            //.Take(2);
        }


        public class Counters
        {
            public int SportProgramCount { get; set; }
            public int MealPlanCount { get; set; }
            public int ExersiesCount { get; set; }
            public int HealthyCount { get; set; }
            public int UsersCount { get; set; }
            public int ExpertsCount { get; set; }
            public int OrdersCount { get; set; }
            public int ArticlesCount { get; set; }
            public int ProductsCount { get; set; }
            public double? RevenuesTotal { get; set; }
        }
    }
}

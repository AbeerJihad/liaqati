using liaqati_master.Models;
using liaqati_master.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace liaqati_master.Services.Repositories
{
    public class IRepoUser
    {
        private readonly LiaqatiDBContext _context;
        private readonly UserManager<User> _userManager;

        public IRepoUser(LiaqatiDBContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager= userManager;
        }

     
        public async Task<IEnumerable<User>> GetAllTrainerAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return (IEnumerable<User>)await _userManager.GetUsersInRoleAsync("Trainer");
        }

      

        public async Task SaveAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

       public async Task<QueryPageResult<User>> SearchExpert(UserQueryParamters exqParameters)
        {
            IQueryable<User> Trainer = (await GetAllTrainerAsync()).AsQueryable();



            if (!string.IsNullOrEmpty(exqParameters.Name))
            {
                Trainer = Trainer.Where(p =>
                    p.Fname.ToLower().Contains(exqParameters.Name.ToLower()) ||
                    p.Lname.ToLower().Contains(exqParameters.Name.ToLower())
                );
            }

            if (!string.IsNullOrEmpty(exqParameters.Specialization))
            {
                Trainer = Trainer.Where(p =>
                    p.Specialization.ToLower().Trim() == exqParameters.Specialization.ToLower().Trim()
                );
            }






            if (!string.IsNullOrEmpty(exqParameters.SortBy))
            {
                if (exqParameters.SortBy.Equals("Fname", StringComparison.OrdinalIgnoreCase))
                {
                    // if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                    Trainer = Trainer.OrderByDescending(p => p.Fname);
                    //else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                    //    Trainer = Trainer.OrderByDescending(p => p.RateId);

                }
                if (exqParameters.SortBy.Equals("Exp_Years", StringComparison.OrdinalIgnoreCase))
                {
                    // if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                    Trainer = Trainer.OrderByDescending(p => p.Exp_Years);
                    //else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                    //    Trainer = Trainer.OrderByDescending(p => p.RateId);

                }
            }

        
        
            QueryPageResult<User> qpres = CommonMethods.GetPageResult(Trainer, exqParameters);


            return qpres;
        }


    }
}

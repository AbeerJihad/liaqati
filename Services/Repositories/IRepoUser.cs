﻿namespace liaqati_master.Services.Repositories
{
    public class IRepoUser
    {
        private readonly LiaqatiDBContext _context;
        private readonly UserManager<User> _userManager;

        public IRepoUser(LiaqatiDBContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public async Task<IEnumerable<User>> GetAllTrainerAsync()
        {

            List<User> users = (await _userManager.GetUsersForClaimAsync(new Claim("Expert", "true"))).ToList();



            //.Include(Category => Category.Category).Include(com => com.comments)
            return users;
        }
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _userManager.Users.ToListAsync();
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

        public async Task<QueryPageResult<User>> SearchUser(UserQueryParamters userqParameters)
        {
            IQueryable<User> Users = (await GetAllAsync()).AsQueryable();
            if (!string.IsNullOrEmpty(userqParameters.Role))
            {
                if (userqParameters.Role == "Traniers")
                {
                    Users = (await GetAllTrainerAsync()).AsQueryable();

                }
            }
            if (!string.IsNullOrEmpty(userqParameters.Name))
            {
                Users = Users.Where(p =>
                    p.Fname!.ToLower().Contains(userqParameters.Name.ToLower()) ||
                    p.Lname!.ToLower().Contains(userqParameters.Name.ToLower())
                );
            }
            if (!string.IsNullOrEmpty(userqParameters.Specialization))
            {
                Users = Users.Where(p => p.Specialization != null && p.Specialization.ToLower().Trim().Contains(userqParameters.Specialization.ToLower().Trim()));
            }

            //if (!string.IsNullOrEmpty(userqParameters.Specialization))
            //{
            //    List<User> Userss = new();
            //    foreach (var item in Users)
            //    {
            //        if (item.Specialization is not null)
            //            if (item.Specialization.ToLower().Trim().Contains(userqParameters.Specialization.ToLower().Trim()))
            //            {
            //                Userss.Add(item);
            //            }
            //    }
            //    Users = Userss.AsQueryable();


            //}

            if (!string.IsNullOrEmpty(userqParameters.SortBy))
            {
                if (userqParameters.SortBy.Equals(nameof(Models.User.Fname), StringComparison.OrdinalIgnoreCase))
                {
                    if (userqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        Users = Users.OrderBy(p => p.Fname);
                    else if (userqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        Users = Users.OrderByDescending(p => p.Fname);

                }
                else if (userqParameters.SortBy.Equals(nameof(Models.User.Lname), StringComparison.OrdinalIgnoreCase))
                {
                    if (userqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        Users = Users.OrderBy(p => p.Lname);
                    else if (userqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        Users = Users.OrderByDescending(p => p.Lname);

                }
                else if (userqParameters.SortBy.Equals(nameof(Models.User.DateOfBirth), StringComparison.OrdinalIgnoreCase))
                {
                    if (userqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        Users = Users.OrderBy(p => p.DateOfBirth);
                    else if (userqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        Users = Users.OrderByDescending(p => p.DateOfBirth);
                }
                else if (userqParameters.SortBy.Equals(nameof(Models.User.Email), StringComparison.OrdinalIgnoreCase))
                {

                    if (userqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        Users = Users.OrderBy(p => p.Email);
                    else if (userqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        Users = Users.OrderByDescending(p => p.Email);

                }
                else if (userqParameters.SortBy.Equals(nameof(Models.User.Exp_Years), StringComparison.OrdinalIgnoreCase))
                {
                    if (userqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        Users = Users.OrderBy(p => p.Exp_Years);
                    else if (userqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        Users = Users.OrderByDescending(p => p.Exp_Years);

                }
            }
            QueryPageResult<User> qpres = CommonMethods.GetPageResult(Users, userqParameters);
            return qpres;
        }


        public async Task<QueryPageResult<ExpertsViewModel>> SearchExperts(ExpertQueryParamters userqParameters)
        {
            IQueryable<ExpertsViewModel> Users = (await _userManager.GetUsersForClaimAsync(new System.Security.Claims.Claim(Database.Expert, "true"))).Select(user => new ExpertsViewModel() { FullName = string.Concat(user.Fname, " ", user.Lname), Instagram = user.Instagram, WhatsApp = user.WhatsApp, Photo = user.Photo, Specialization = user.Specialization, Twitter = user.Twitter }).AsQueryable(); ;

            if (!string.IsNullOrEmpty(userqParameters.Name))
            {
                Users = Users.Where(p => p.FullName!.ToLower().Contains(userqParameters.Name.ToLower()));
            }
            if (!string.IsNullOrEmpty(userqParameters.Specialization))
            {
                Users = Users.Where(p => p.Specialization != null && p.Specialization.ToLower().Trim().Contains(userqParameters.Specialization.ToLower().Trim()));
            }
            QueryPageResult<ExpertsViewModel> qpres = CommonMethods.GetPageResult(Users, userqParameters);
            return qpres;
        }




        public async Task<User?> GetByIDAsync(string EntityId)
        {
            return await _context.Users.FirstOrDefaultAsync(a => a.Id == EntityId);
        }


        public async Task<User> UpdateEntityAsync(User Entity)
        {
            User? user = await _context.Users.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (user != null)
            {
                await _userManager.UpdateAsync(user);
                //_context.Users.Update(Entity);
                //await SaveAsync();
                return Entity;

            }
            else
            {
                return new User();
            }
        }


    }
}

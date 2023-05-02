using liaqati_master.Services.Repositories;
using liaqati_master.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Experts
{
    public class IndexModel : PageModel
    {
        readonly IRepoUser _repocontextUser;

        public IndexModel(IRepoUser repocontextUser)
        {
           _repocontextUser= repocontextUser;

            //Specialization _repocontextUser.GetAllTrainerAsync();
            //Specialization =Specialization.Select(b => b.S).ToList();
        }



        [BindProperty]
        public List<User>? Users { get; set; }

        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value="Fname",Text=" الاسم الاول"},
            new SelectListItem(){Value="Specialization",Text=" التخصص"},
        };


        public List<string> Specialization { get; set; }

      

        [BindProperty(SupportsGet = true)]
        public UserQueryParamters Parameters { get; set; }

        public QueryPageResult<User> queryPageResult { get; set; }

        public async void OnPost()
        {

            queryPageResult = await _repocontextUser.SearchUser(Parameters);

        }

        public async Task OnGet()
        {
            //Users = (List<User>?)await _repocontextUser.GetAllTrainerAsync();

        }
    }
}

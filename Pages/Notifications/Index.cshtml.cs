using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using liaqati_master.Models;

namespace liaqati_master.Pages.Notifications
{
    public class IndexModel : PageModel
    {
        public IRepoNotification _repoNotification;

        public IndexModel(IRepoNotification repoNotification)
        {
            _repoNotification = repoNotification;
        }

     
       



        [BindProperty(SupportsGet = true)]
        public VMListNotification List { get; set; }=new VMListNotification();


        public async void OnGet(string? id)
        {
            DateTime? date = DateTime.Today;

            if(id is not null)
            {


                List<Notification> List2 = (await _repoNotification.GetAllAsync()).Where(p => p.UserId == id).ToList();

                List<Notification> n = List2.Where(n => n.DATE == DateTime.Today).ToList();


                List.Today = n;




                List<Notification> nn = List2.Where(n => n.DATE == DateTime.Today.AddDays(-1)).ToList();
                 List.yesterday = nn;

                
                List2 = List2.Where(n => n.DATE != DateTime.Today.AddDays(-1) && n.DATE == DateTime.Today).ToList();

                List.Other = List2;
                

            }







        }
    }
}

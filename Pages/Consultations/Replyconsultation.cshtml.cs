using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Consultations
{
    public class ReplyconsultationModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IRepoConsultation _repocons;

        public ReplyconsultationModel(UnitOfWork unitOfWork, IRepoConsultation repocons)
        {
            _unitOfWork = unitOfWork;
            _repocons = repocons;
        }

        public string Message { get; set; }
        public Consultation cons = new Consultation();
        public Replyconsultation repcons = new Replyconsultation();

        public async Task OnGetAsync(string id)
        {
            if (id != null)
            {
                cons = await _repocons.GetByIDAsync(id);


                if (cons != null)
                {
                    repcons = await _repocons.GetReplyAsync(id);
                }
                else
                {          
                    Message = "NotFound";
                }

            }


        }
    }
}

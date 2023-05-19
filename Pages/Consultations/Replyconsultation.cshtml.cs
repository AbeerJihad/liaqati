#nullable disable
namespace liaqati_master.Pages.Consultations
{
    public class ReplyconsultationModel : PageModel
    {
        private readonly IRepoConsultation _repocons;

        public ReplyconsultationModel(IRepoConsultation repocons)
        {
            _repocons = repocons;
        }

        public string Message { get; set; }
        public Consultation Cons { get; set; }
        public List<Replyconsultation> Repcons { get; set; }

        public async Task OnGetAsync(string id)
        {
            if (id != null)
            {
                Cons = await _repocons.GetByIDAsync(id);
                if (Cons != null)
                {
                    Repcons = await _repocons.GetAllReplyAsync(id);
                }
                else
                {
                    Message = "NotFound";
                }
            }
        }
    }
}

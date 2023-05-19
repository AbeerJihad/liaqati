#nullable disable
namespace liaqati_master.Areas.Admin.Pages.Replyconsultations
{
    public class IndexModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IRepoConsultation _repocons;

        public IndexModel(UnitOfWork unitOfWork, IRepoConsultation repocons)
        {
            _unitOfWork = unitOfWork;
            _repocons = repocons;
        }

        public string Message { get; set; }
        public Consultation? Consultation { get; set; }
        public List<Replyconsultation> ListOfReplyconsultation { get; set; }


        public async Task OnGetAsync(string id)
        {
            if (id != null)
            {
                Consultation = await _repocons.GetByIDAsync(id);
                if (Consultation != null)
                {
                    ListOfReplyconsultation = await _repocons.GetAllReplyAsync(id);
                }
                else
                {
                    Message = "NotFound";
                }
            }
        }
    }
}

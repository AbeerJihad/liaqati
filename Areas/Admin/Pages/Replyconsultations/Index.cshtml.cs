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
        public Consultation cons = new Consultation();

        public List<Replyconsultation> repcons = new List<Replyconsultation>();

        public async Task OnGetAsync(string id)
        {
            if (id != null)
            {
                cons = await _repocons.GetByIDAsync(id);


                if (cons != null)
                {
                    repcons = await _repocons.GetAllReplyAsync(id);
                }
                else
                {
                    Message = "NotFound";
                }

            }


        }
    }
}

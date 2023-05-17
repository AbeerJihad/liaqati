using liaqati_master.Services.Repositories;

namespace liaqati_master.Components
{
    public class MostViewedConsultationViewComponent : ViewComponent
    {
        private readonly IRepoConsultation repoConsultation;

        public MostViewedConsultationViewComponent(IRepoConsultation repoConsultation)
        {
            this.repoConsultation = repoConsultation;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Consultation>? ListOfcon = (await repoConsultation.GetAllAsync()).OrderByDescending(con => con.ViewsNumber).Take(4).ToList();
            return View(ListOfcon);
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Pages.Consultations
{
    public class IndexModel : PageModel
    {
        private readonly IRepoConsultation repoConsultation;
        private readonly IRepoCategory _repoCategory;

        public IndexModel(IRepoConsultation repoConsultation, IRepoCategory repoCategory)
        {
            this.repoConsultation = repoConsultation;
            _repoCategory = repoCategory;
        }

        [BindProperty(SupportsGet = true)]
        public ConsultationQueryParamters ConsultationQueryParamters { get; set; }
        public QueryPageResult<Consultation> QueryPageResult { get; set; }
        public bool IsGrid { get; set; }
        public IEnumerable<SelectListItem> lstPageSize { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem(){Value="5", Text="5"},
            new SelectListItem(){Value="10", Text="10"},
            new SelectListItem(){Value="20", Text="20"}
        };
        public List<(string, string)>? ListOfSelectedFilters { get; set; }

        public IEnumerable<SelectListItem> Titles { get; set; }
        public IEnumerable<SelectListItem> Categoires { get; set; }
     
        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value=nameof(Consultation.Title),Text="العنوان"},
            new SelectListItem(){Value=nameof(Consultation.Category.Name),Text="إسم الصنف"},
            new SelectListItem(){Value=nameof(Consultation.ViewsNumber),Text="عدد المشاهدات"},
        };

        public async Task OnGetAsync()
        {


            Categoires = (await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Consultation)]).Select(x => new SelectListItem() { Text = x.Name, Value = x.Id });

            if (!string.IsNullOrEmpty(ConsultationQueryParamters.CategoryId))
            {
                Titles = (await repoConsultation.GetAllAsync()).Where(c => c.CategoryId == ConsultationQueryParamters.CategoryId).Select(x => new SelectListItem() { Text = x.Title, Value = x.Title });

            }
            else
            {
                Titles = (await repoConsultation.GetAllAsync()).Select(x => new SelectListItem() { Text = x.Title, Value = x.Title });

            }
            if (repoConsultation != null)
            {
                QueryPageResult = await repoConsultation.Searchconsult(ConsultationQueryParamters);
            }
        }

    }
}

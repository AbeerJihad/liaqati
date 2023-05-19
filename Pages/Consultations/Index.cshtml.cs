#nullable disable
namespace liaqati_master.Pages.Consultations
{
    public class IndexModel : PageModel
    {
        private readonly IRepoConsultation _repocons;

        public IndexModel(IRepoConsultation repocons)
        {
            _repocons = repocons;
        }




        [BindProperty(SupportsGet = true)]
        public ConsultationQueryParamters Parameters { get; set; }

        public QueryPageResult<Consultation> queryPageResult { get; set; }


        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value="oldest",Text="الاقدم"},
            new SelectListItem(){Value="newst",Text="الاحدث"},
              };
        public IEnumerable<SelectListItem> TypeList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value="13",Text="تغذية"},
            new SelectListItem(){Value="14",Text="لياقة بدنية"},
              };

        public async Task OnGetAsync()
        {

            queryPageResult = await _repocons.Searchconsult(Parameters);

            //return RedirectToPage("./index");
        }


    }
}

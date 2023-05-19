#nullable disable
namespace liaqati_master.Areas.Admin.Pages.Consultations
{
    public class CreateModel : PageModel
    {
        private readonly IRepoConsultation _IRepoConsultation;
        private readonly IRepoCategory _IRepoCategory;

        public CreateModel(IRepoConsultation repoConsultation, IRepoCategory iRepoCategory)
        {
            _IRepoConsultation = repoConsultation; _IRepoCategory = iRepoCategory;

        }


        public SelectList CategoriesSelect { get; set; }
        public async Task<IActionResult> OnGet()
        {
            CategoriesSelect = new SelectList(await _IRepoCategory.GetAllAsync(), nameof(Category.Id), nameof(Category.Name));
            return Page();
        }
        [BindProperty]
        public Consultation Consultations { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {

            Consultations.Id = CommonMethods.Id_Guid();
            if (!ModelState.IsValid)
            {
                CategoriesSelect = new SelectList(await _IRepoCategory.GetAllAsync(),
                    nameof(Category.Id), nameof(Category.Name));
                return Page();
            }
            await _IRepoConsultation.AddEntityAsync(Consultations);
            return RedirectToPage("./Index");
        }
    }
}

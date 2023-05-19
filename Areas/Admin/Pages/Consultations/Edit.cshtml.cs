#nullable disable
namespace liaqati_master.Areas.Admin.Pages.Consultations
{
    public class EditModel : PageModel
    {
        private readonly IRepoConsultation _IRepoConsultation;
        private readonly IRepoCategory _IRepoCategory;

        public EditModel(IRepoConsultation iRepoConsultation, IRepoCategory iRepoCategory)
        {
            _IRepoConsultation = iRepoConsultation;
            _IRepoCategory = iRepoCategory;
        }

        [BindProperty]
        public Consultation Consultations { get; set; } = default!;
        public SelectList CategoriesSelect { get; set; }


        public async Task<IActionResult> OnGetAsync(string id)
        {
            CategoriesSelect = new SelectList(await _IRepoCategory.GetAllAsync(), nameof(Category.Id), nameof(Category.Name));
            if (id == null || _IRepoConsultation == null)
            {
                return NotFound();
            }
            var consultation = await _IRepoConsultation.GetByIDAsync(id);
            if (consultation == null)
            {
                return NotFound();
            }
            Consultations = consultation;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                CategoriesSelect = new SelectList(await _IRepoCategory.GetAllAsync(), nameof(Category.Id), nameof(Category.Name));
                return Page();
            }
            await _IRepoConsultation.UpdateEntityAsync(Consultations);
            return RedirectToPage("./Index");
        }


    }
}

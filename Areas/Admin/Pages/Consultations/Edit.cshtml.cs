using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Areas.Admin.Pages.Consultations
{
    public class EditModel : PageModel
    {
        private readonly IRepoConsultation repoConsultation;
        private readonly IRepoCategory _repoCategory;

        public EditModel(IRepoConsultation repoConsultation, IRepoCategory repoCategory)
        {
            this.repoConsultation = repoConsultation;
            _repoCategory = repoCategory;
        }

        [BindProperty]
        public Consultation Consultations { get; set; } = default!;
        public SelectList CategoriesSelect { get; set; }


        public async Task<IActionResult> OnGetAsync(string? id)
        {
            CategoriesSelect = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Consultation)]), nameof(Category.Id), nameof(Category.Name));


            if (id == null || repoConsultation == null)
            {
                return NotFound();
            }

            var articles = await repoConsultation.GetByIDAsync(id);

            if (articles == null)
            {
                return NotFound();
            }
            Consultations = articles;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            CategoriesSelect = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Consultation)]), nameof(Category.Id), nameof(Category.Name));
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await repoConsultation.UpdateEntityAsync(Consultations);
            return RedirectToPage("/Index");
        }


    }
}

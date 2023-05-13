using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Areas.Admin.Pages.Consultations
{
    public class EditModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;

        public EditModel(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public Consultation Consultations { get; set; } = default!;
        public SelectList CategoriesSelect { get; set; }


        public async Task<IActionResult> OnGetAsync(string? id)
        {
            CategoriesSelect = new SelectList(_unitOfWork.CategoryRepository.Get().Where(c=>c.Target== "استشارات"), nameof(Category.Id), nameof(Category.Name));


            if (id == null || _unitOfWork.ConsultationRepository == null)
            {
                return NotFound();
            }

            var articles = _unitOfWork.ConsultationRepository.GetByID(id);
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
            CategoriesSelect = new SelectList(_unitOfWork.CategoryRepository.Get(), nameof(Category.Id), nameof(Category.Name));

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _unitOfWork.ConsultationRepository.Update(Consultations);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_unitOfWork.ConsultationRepository.GetByID(Consultations.Id) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }


    }
}

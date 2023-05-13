using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Areas.Admin.Pages.Consultations
{
    public class CreateModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IFormFileMang _formFileMang;

        public CreateModel(UnitOfWork unitOfWork, IFormFileMang formFileMang)
        {
            _unitOfWork = unitOfWork;
            _formFileMang = formFileMang;
            CategoriesSelect = new SelectList(_unitOfWork.CategoryRepository.Get(), nameof(Category.Id), nameof(Category.Name));
        }


        public SelectList CategoriesSelect { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Consultation Consultations { get; set; }

     
        public async Task<IActionResult> OnPostAsync()
        {

            Consultations.Id = CommonMethods.Id_Guid();
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Consultations.PostDate = DateTime.Now;
            _unitOfWork.ConsultationRepository.Insert(Consultations);
            try
            {
                _unitOfWork.Save();

            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToPage("./Index");
        }
    }
}

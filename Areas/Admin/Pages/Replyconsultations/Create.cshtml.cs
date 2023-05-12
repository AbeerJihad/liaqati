using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Areas.Admin.Pages.Replyconsultations
{
    public class CreateModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IFormFileMang _formFileMang;

        public CreateModel(UnitOfWork unitOfWork, IFormFileMang formFileMang)
        {
            _unitOfWork = unitOfWork;
            _formFileMang = formFileMang;
        }


     

        [BindProperty]
        public Replyconsultation Replyconsultations { get; set; }

        public string Id { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            Replyconsultations.Id = CommonMethods.Id_Guid();
            Replyconsultations.consId = Id;
            if (!ModelState.IsValid)
            {
                return Page();
            }

         
            _unitOfWork.ReplyconsultationRepository.Insert(Replyconsultations);
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

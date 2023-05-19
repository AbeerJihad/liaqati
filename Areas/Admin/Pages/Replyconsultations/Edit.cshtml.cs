namespace liaqati_master.Areas.Admin.Pages.Replyconsultations
{
    public class EditModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;

        public EditModel(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public Replyconsultation Replyconsultations { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string? id)
        {


            if (id == null || _unitOfWork.ReplyconsultationRepository == null)
            {
                return NotFound();
            }

            var articles = _unitOfWork.ReplyconsultationRepository.GetByID(id);
            if (articles == null)
            {
                return NotFound();
            }
            Replyconsultations = articles;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _unitOfWork.ReplyconsultationRepository.Update(Replyconsultations);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_unitOfWork.ReplyconsultationRepository.GetByID(Replyconsultations.Id) == null)
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

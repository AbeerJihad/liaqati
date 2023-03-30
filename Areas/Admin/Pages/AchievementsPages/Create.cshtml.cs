using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Administrator.Pages.AchievementsPages
{
    public class CreateModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;
        public CreateModel(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public Achievements Achievements { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _unitOfWork.AchievementsRepository == null || Achievements == null)
            {
                return Page();
            }

            Achievements.Id = Guid_Id.Id_Guid();
            Achievements.UserId = "1";
            _unitOfWork.AchievementsRepository.Insert(Achievements);
            _unitOfWork.Save();
            return RedirectToPage("./Index");
        }
    }
}

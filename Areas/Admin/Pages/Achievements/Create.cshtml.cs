using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Administrator.Pages.Achievements
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
        public Achievement Achievements { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _unitOfWork.AchievementsRepository == null || Achievements == null)
            {
                return Page();
            }

            Achievements.Id = CommonMethods.Id_Guid();
            Achievements.UserId = "1";
            _unitOfWork.AchievementsRepository.Insert(Achievements);
            _unitOfWork.Save();
            return RedirectToPage("./Index");
        }
    }
}

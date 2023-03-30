using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Administrator.Pages.AchievementsPages
{
    public class IndexModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;

        public IndexModel(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IList<Achievements> Achievements { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_unitOfWork.AchievementsRepository != null)
            {
                Achievements = _unitOfWork.AchievementsRepository.Get().ToList();
            }
        }
        public async Task<IActionResult> OnPostAsync(int? Id)
        {
            if (Id == null || _unitOfWork.AchievementsRepository.Get() == null)
            {
                return NotFound();
            }
            var articles = _unitOfWork.AchievementsRepository.GetByID(Id);

            if (articles != null)
            {
                _unitOfWork.AchievementsRepository.Delete(articles);
                _unitOfWork.Save();
            }

            return RedirectToPage("./Index");
        }


    }
}

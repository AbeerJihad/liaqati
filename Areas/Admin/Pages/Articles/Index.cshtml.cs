using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Admin.Articles
{
    public class IndexModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;

        public IndexModel(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IList<Article> Articles { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_unitOfWork.ArticleRepository.Get() != null)
            {
                Articles = _unitOfWork.ArticleRepository.GetAllEntity().ToList();
            }
        }
        public async Task<IActionResult> OnPostAsync(string? id)

        {
            if (id == null || _unitOfWork.ArticleRepository.Get() == null)
            {
                return NotFound();
            }
            Article? articles = _unitOfWork.ArticleRepository.GetByID(id);

            if (articles != null)
            {
                _unitOfWork.ArticleRepository.Delete(articles);
                _unitOfWork.Save();
            }

            return RedirectToPage("./Index");
        }



    }
}

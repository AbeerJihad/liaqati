using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Articles
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
                Articles = _unitOfWork.ArticleRepository.Get(includeProperties: "Category").ToList();
            }
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _unitOfWork.ArticleRepository.Get() == null)
            {
                return NotFound();
            }
            var articles = _unitOfWork.ArticleRepository.GetByID(id);

            if (articles != null)
            {
                _unitOfWork.ArticleRepository.Delete(articles);
                _unitOfWork.Save();
            }

            return RedirectToPage("./Index");
        }



    }
}

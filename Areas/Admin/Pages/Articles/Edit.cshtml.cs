using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Articles
{
    public class EditModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;

        public EditModel(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public Article Articles { get; set; } = default!;
        public SelectList CategoriesSelect { get; set; }


        public async Task<IActionResult> OnGetAsync(string? id)
        {
            CategoriesSelect = new SelectList(_unitOfWork.CategoryRepository.Get(), nameof(Category.Id), nameof(Category.Name));


            if (id == null || _unitOfWork.ArticleRepository == null)
            {
                return NotFound();
            }

            var articles = _unitOfWork.ArticleRepository.GetByID(id);
            if (articles == null)
            {
                return NotFound();
            }
            Articles = articles;
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

            _unitOfWork.ArticleRepository.Update(Articles);

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_unitOfWork.ArticleRepository.GetByID(Articles.Id) == null)
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

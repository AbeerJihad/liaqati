using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Articles
{
    public class CreateModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;

        //test Branch

        public CreateModel(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public SelectList CategoriesSelect { get; set; }
        public IActionResult OnGet()
        {
            CategoriesSelect = new SelectList(_unitOfWork.CategoryRepository.Get(), nameof(Category.Id), nameof(Category.Name));
            return Page();
        }

        [BindProperty]
        public Article Articles { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            CategoriesSelect = new SelectList(_unitOfWork.CategoryRepository.Get(), nameof(Category.Id), nameof(Category.Name));


            Articles.Id = Guid_Id.Id_Guid();
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Articles.PostDate = DateTime.Now;
            _unitOfWork.ArticleRepository.Insert(Articles);
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

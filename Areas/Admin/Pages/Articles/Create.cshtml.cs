using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Areas.Admin.Pages.Articles
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
        public Article Articles { get; set; }

        [BindProperty]
        [Required(ErrorMessage = " {0} حقل مطلوب")]
        [Display(Name = "أضف صورة")]
        public IFormFile Image { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

            Articles.Id = CommonMethods.Id_Guid();
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Articles.PostDate = DateTime.Now;
            Articles.Image = await _formFileMang.Upload(Image, "Images", "Articles");
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

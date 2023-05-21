using liaqati_master.Services.CustomValidation;
using liaqati_master.Services.CustomValidationAttribute;

namespace liaqati_master.Areas.Admin.Pages.Articles
{
    public class CreateModel : PageModel
    {
        private readonly IFormFileMang _formFileMang;
        private readonly IRepoArticles _repoArticles;
        private readonly IRepoCategory _repoCategory;

        public CreateModel(IFormFileMang formFileMang, IRepoArticles repoArticles, IRepoCategory repoCategory)
        {
            _formFileMang = formFileMang;
            _repoArticles = repoArticles;
            _repoCategory = repoCategory;
        }


        public SelectList CategoriesSelect { get; set; }
        public async Task OnGet()
        {
            CategoriesSelect = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Article)]), nameof(Category.Id), nameof(Category.Name));

        }

        [BindProperty]
        public Article Articles { get; set; }

        [BindProperty]
        [Required(ErrorMessage = " {0} حقل مطلوب")]
        [Display(Name = "أضف صورة")]
        [AllowedExtensions(new string[] { ".png", ".jpg" }, ErrorMessage = " نوع الملف يجب أن يكون jpg , png  ")]
        [FilesMaxSize(maxFileSize: 1024 * 1024 * 2, "حجم الملف يزيد عن 2 ميغا بايت")]
        public IFormFile Image { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {

            CategoriesSelect = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Article)]), nameof(Category.Id), nameof(Category.Name));
            Articles.Id = CommonMethods.Id_Guid();
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null)
            {
                Articles.UserId = userid;
            }
            Articles.Image = await _formFileMang.Upload(Image, "Images", "Articles");
            await _repoArticles.AddEntityAsync(Entity: Articles);
            return RedirectToPage("./Index");
        }
    }
}

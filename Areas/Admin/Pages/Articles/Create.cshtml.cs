namespace liaqati_master.Areas.Admin.Pages.Articles
{
    public class CreateModel : PageModel
    {
        private readonly IFormFileMang _formFileMang;
        private readonly IRepoArticles _repoArticles;
        private readonly IRepoCategory _repoCategory;

        public CreateModel(IFormFileMang formFileMang, IRepoArticles repoArticles)
        {
            _formFileMang = formFileMang;
            _repoArticles = repoArticles;
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
        public IFormFile Image { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

            CategoriesSelect = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Article)]), nameof(Category.Id), nameof(Category.Name));
            Articles.Id = CommonMethods.Id_Guid();
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Articles.Image = await _formFileMang.Upload(Image, "Images", "Articles");
            await _repoArticles.AddEntityAsync(Articles);
            return RedirectToPage("./Index");
        }
    }
}

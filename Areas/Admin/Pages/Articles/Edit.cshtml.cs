namespace liaqati_master.Areas.Admin.Pages.Articles
{
    public class EditModel : PageModel
    {
        private readonly IRepoArticles _repoArticles;
        private readonly IRepoCategory _repoCategory;

        public EditModel(IRepoArticles repoArticles, IRepoCategory repoCategory)
        {
            _repoArticles = repoArticles;
            _repoCategory = repoCategory;

        }

        [BindProperty]
        public Article Articles { get; set; } = default!;
        public SelectList CategoriesSelect { get; set; }


        public async Task<IActionResult> OnGetAsync(string? id)
        {
            CategoriesSelect = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Article)]), nameof(Category.Id), nameof(Category.Name));


            if (id == null || _repoArticles == null)
            {
                return NotFound();
            }

            var articles = await _repoArticles.GetByIDAsync(id);

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
            CategoriesSelect = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Article)]), nameof(Category.Id), nameof(Category.Name));
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _repoArticles.UpdateEntityAsync(Articles);
            return RedirectToPage("./Index");
        }


    }
}

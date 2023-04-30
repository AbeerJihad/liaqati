namespace liaqati_master.Areas.Admin.Pages.Categories
{
    public class IndexAllModel : PageModel
    {
        public enum ShowModelCat { None, Edit, Add }

        private readonly IRepoCategory _repoCategory;

        public IndexAllModel(IRepoCategory repoCategory)
        {
            _repoCategory = repoCategory;
        }

        [BindProperty(SupportsGet = true)]
        public Category Category { get; set; }
        public IList<Category> LstCategory { get; set; }
        public List<SelectListItem> LstTargets { get; set; }

        public ShowModelCat showModel { get; set; } = ShowModelCat.None;


        public async Task OnGetAsync()
        {
            LstCategory = (await _repoCategory.GetAllAsync()).ToList();
            List<SelectListItem> selectListItems = new();
            foreach (var item in Database.GetListOfTargets().Values)
            {
                selectListItems.Add(new SelectListItem() { Value = item, Text = item });

            }
            LstTargets = selectListItems;
        }


        public async Task<IActionResult> OnPostDeleteAsync(string? Id)
        {
            List<SelectListItem> selectListItems = new();
            foreach (var item in Database.GetListOfTargets().Values)
            {
                selectListItems.Add(new SelectListItem() { Value = item, Text = item });

            }
            LstTargets = selectListItems;
            if (Id == null)
            {
                return NotFound();
            }

            var category = await _repoCategory.GetByIDAsync(Id);

            if (category != null)
            {
                Category = category;
                await _repoCategory.DeleteEntityAsync(category);
            }


            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostAddAsync()
        {
            List<SelectListItem> selectListItems = new();
            foreach (var item in Database.GetListOfTargets().Values)
            {
                selectListItems.Add(new SelectListItem() { Value = item, Text = item });

            }
            LstTargets = selectListItems;
            if (!ModelState.IsValid)
            {
                showModel = ShowModelCat.Add;
                return Page();
            }
            Category.Id = CommonMethods.Id_Guid();
            await _repoCategory.AddEntityAsync(Category);
            return RedirectToPage();
        }


        public async Task<IActionResult> OnPostEditAsync()
        {
            List<SelectListItem> selectListItems = new();
            foreach (var item in Database.GetListOfTargets().Values)
            {
                selectListItems.Add(new SelectListItem() { Value = item, Text = item });

            }
            LstTargets = selectListItems;
            if (!ModelState.IsValid)
            {
                showModel = ShowModelCat.Edit;
                return Page();
            }
            var category = await _repoCategory.GetByIDAsync(Category?.Id);
            if (category != null)
            {
                category.Name = Category.Name;
                category.Description = Category.Description;
                category.Target = Category.Target;
                Category = category;
                await _repoCategory.UpdateEntityAsync(Category);
            }
            return RedirectToPage();
        }



    }
}

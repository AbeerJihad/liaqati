using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Areas.Administrator.Pages.Categories
{
    public class IndexAllModel : PageModel
    {
        public enum ShowModelCat { None, Edit, Add }

        private readonly UnitOfWork _unitOfWork;

        public IndexAllModel(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            if (_unitOfWork.CategoryRepository != null)
            {
                LstCategory = _unitOfWork.CategoryRepository.Get().ToList();
            }
        }

        [BindProperty]
        public Category Category { get; set; }
        public IList<Category> LstCategory { get; set; } = default!;

        public ShowModelCat showModel { get; set; } = ShowModelCat.None;


        public async Task OnGetAsync()
        {

        }


        public async Task<IActionResult> OnPostDeleteAsync(string? Id)
        {
            if (Id == null || _unitOfWork.CategoryRepository == null)
            {
                return NotFound();
            }

            var category = _unitOfWork.CategoryRepository.GetByID(Id);

            if (category != null)
            {
                Category = category;
                _unitOfWork.CategoryRepository.Delete(category);
                _unitOfWork.Save();
            }


            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostAddAsync()
        {
            if (!ModelState.IsValid)
            {
                showModel = ShowModelCat.Add;
                return Page();
            }

            if (Category.Id == null)
            {
                ModelState.AddModelError("Student.Id", "Invalid Id");
                showModel = ShowModelCat.Add;
                return Page();
            }

            var student = _unitOfWork.CategoryRepository.GetByID(Category.Id);

            if (student != null)
            {
                ModelState.AddModelError("Student.Id", "This id is aleady exsits, dupliation not allowed");
                showModel = ShowModelCat.Add;
                return Page();
            }

            _unitOfWork.CategoryRepository.Insert(Category);

            _unitOfWork.Save();

            return RedirectToPage();
        }


        public async Task<IActionResult> OnPostEditAsync()
        {
            if (!ModelState.IsValid)
            {
                showModel = ShowModelCat.Edit;
                return Page();
            }

            var category = _unitOfWork.CategoryRepository.GetByID(Category.Id);

            if (category != null)
            {
                category.Name = Category.Name;
                Category = category;
                _unitOfWork.CategoryRepository.Update(Category);
            }

            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_unitOfWork.CategoryRepository.GetByID(Category.Id) != null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage();
        }



    }
}

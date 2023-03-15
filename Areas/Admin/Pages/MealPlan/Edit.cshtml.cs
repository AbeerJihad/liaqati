using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace liaqati_master.Pages.MealPlan
{
    public class EditModel : PageModel
    {

        private readonly LiaqatiDBContext _context;

        private readonly UnitOfWork _UnitOfWork;

        public EditModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
        }

        public List<SelectListItem> CatogeryName { get; set; }


        [BindProperty(SupportsGet =true)]
        public MealPlans MealPlans { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var meal =  _UnitOfWork.MealPlansRepository.GetByID(id);
            if (meal == null)
            {
                return NotFound();
            }
            MealPlans = meal;

            CatogeryName = _UnitOfWork.CategoryRepository.GetAllEntity().Select(a =>
                                       new SelectListItem
                                       {
                                           Value = a.Id.ToString(),
                                           Text = a.Name
                                       }).ToList();


            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var id=MealPlans.Id;

        var item= _UnitOfWork.MealPlansRepository.GetByID(id);
            item.services!.Title = MealPlans.services!.Title;
            item.services.Price = MealPlans.services.Price;
            item.services.Description = MealPlans.services.Description;
            item.Length = MealPlans.Length;
            item.mealType= MealPlans.mealType;


            var cid = MealPlans.services!.Category!.Id;
            if (id != null)
            {
                MealPlans.services.CategoryId = id;

            }

            item.services.Category = null;


            _UnitOfWork.MealPlansRepository.Update(item);

          
          //  _context.Attach(MealPlans).State = EntityState.Modified;

            try
            {
                _UnitOfWork.Save();
            }




            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(MealPlans.Id))
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

        private bool StudentExists(string id)
        {
            return _context.TblMealPlans.Any(e => e.Id == id);
        }
    }
}

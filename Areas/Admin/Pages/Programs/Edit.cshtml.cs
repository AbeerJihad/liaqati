using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace liaqati_master.Pages.Programs
{
    public class EditProgramModel : PageModel
    {

        private readonly LiaqatiDBContext _context;

        private readonly UnitOfWork _UnitOfWork;

        public EditProgramModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
        }

        public List<SelectListItem> CatogeryName { get; set; }


        [BindProperty(SupportsGet =true)]
        public SportsProgram SportsProgram { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var sportsProgram =  _UnitOfWork.SportsProgramRepository.GetByID(id);
            if (sportsProgram == null)
            {
                return NotFound();
            }
            SportsProgram = sportsProgram;

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

            var id=SportsProgram.Id;

        var item= _UnitOfWork.MealPlansRepository.GetByID(id);
            item.services!.Title = SportsProgram.services!.Title;
            item.services.Price = SportsProgram.services.Price;
            item.services.Description = SportsProgram.services.Description;
            item.Length = SportsProgram.Length;
            item.mealType= SportsProgram.BodyFocus;
            item.mealType= SportsProgram.Difficulty;
            item.mealType= SportsProgram.Equipment;
            item.mealType= SportsProgram.TrainingType;


            var cid = SportsProgram.services!.Category!.Id;
            if (id != null)
            {
                SportsProgram.services.CategoryId = id;

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
                if (!StudentExists(SportsProgram.Id))
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

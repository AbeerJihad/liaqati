using liaqati_master.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace liaqati_master.Pages.Exercises
{
    public class EditExerciseModel : PageModel
    {

        private readonly LiaqatiDBContext _context;

        private readonly UnitOfWork _UnitOfWork;

        public EditExerciseModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
        }

       

        [BindProperty(SupportsGet =true)]
        public Exercise Exercise { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var exercise =  _UnitOfWork.ExerciseRepository.GetByID(id);
            if (exercise == null)
            {
                return NotFound();
            }
            Exercise = exercise;

           

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPost()
        {

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            var id= Exercise.Id;

        var item= _UnitOfWork.ExerciseRepository.GetByID(id);
           
            item.Title = Exercise.Title;
            item.Detail = Exercise.Detail;
            item.DEx = Exercise.DEx;
            item.Equipments = Exercise.Equipments;
            item.TraningType = Exercise.TraningType;
            item.Difficulty = Exercise.Difficulty;
            _UnitOfWork.ExerciseRepository.Update(item);

          
          //  _context.Attach(MealPlans).State = EntityState.Modified;

            try
            {
                _UnitOfWork.Save();
            }




            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(Exercise.Id))
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

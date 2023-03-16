using liaqati_master.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Exercises
{
    public class CreateExerciseModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;

        public CreateExerciseModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
        }


        public IActionResult OnGet()
        {
            


          

            return Page();
        }
       


        [BindProperty]
        public Exercise Exercise { get; set; }

       


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAddAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}



            Exercise.Id = Guid_Id.Id_Guid();


            Exercise.Image = "";
         




            _UnitOfWork.ExerciseRepository.Insert(Exercise);


            _UnitOfWork.Save();
            


            return RedirectToPage("./Index");
        }
    }
}

using liaqati_master.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.Programs
{
    public class CreatProgrameModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;

        public CreatProgrameModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
        {
            _context = context;
            _UnitOfWork = unitOfWork;
        }

        public List<SelectListItem> CatogeryName { get; set; }

        public IActionResult OnGet()
        {
            


            CatogeryName = _UnitOfWork.CategoryRepository.GetAllEntity().Select(a =>
                                         new SelectListItem
                                         {
                                             Value = a.Id.ToString(), Text = a.Name
                                         }).ToList();


            return Page();
        }
       








        [BindProperty]
        public SportsProgram SportsProgram { get; set; }

       


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAddAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

          

            SportsProgram.Id = Guid_Id.Id_Guid();

            SportsProgram.services!.Id= SportsProgram.Id;

            SportsProgram.services.sportsProgramId = SportsProgram.Id;

          // MealPlans.servicesId = MealPlans.Id;

            var id = SportsProgram.services!.Category!.Id;
            if (id != null)
            {
                SportsProgram.services.CategoryId = id;

            }
            SportsProgram.services.Category = null;




            _UnitOfWork.SportsProgramRepository.Insert(SportsProgram);
            _UnitOfWork.ServiceRepository.Insert(SportsProgram.services);


            _UnitOfWork.Save();
            


            return RedirectToPage("./Index");
        }
    }
}

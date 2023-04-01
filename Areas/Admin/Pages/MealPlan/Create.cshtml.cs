using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.MealPlan
{
    public class CreateModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly UnitOfWork _UnitOfWork;

        public CreateModel(LiaqatiDBContext context, UnitOfWork unitOfWork)
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
                                             Value = a.Id.ToString(),
                                             Text = a.Name
                                         }).ToList();


            return Page();
        }









        [BindProperty]
        public MealPlans MealPlans { get; set; }




        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAddAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}



            MealPlans.Id = CommonMethods.Id_Guid();

            MealPlans.Services!.Id = MealPlans.Id;

            //MealPlans.Services.MealPlansId = MealPlans.Id;

            // MealPlans.ServicesId = MealPlans.Id;

            var id = MealPlans.Services!.Category!.Id;
            if (id != null)
            {
                MealPlans.Services.CategoryId = id;

            }
            MealPlans.Services.Category = null;




            _UnitOfWork.MealPlansRepository.Insert(MealPlans);
            _UnitOfWork.ServiceRepository.Insert(MealPlans.Services);


            _UnitOfWork.Save();



            return RedirectToPage("./Index");
        }
    }
}

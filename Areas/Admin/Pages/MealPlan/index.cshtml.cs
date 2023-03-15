using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace liaqati_master.Pages.MealPlan
{
    public class indexModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;
        
        public indexModel(UnitOfWork UnitOfWork)
        {
            _unitOfWork = UnitOfWork;
        }

        public IList<MealPlans> MealPlans { get; set; }
        public async Task OnGetAsync()
        {
            if (_unitOfWork != null)
            {

                MealPlans =  _unitOfWork.MealPlansRepository.GetAllEntity();
            }
        }
    }
}

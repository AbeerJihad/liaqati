using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace liaqati_master.Pages.HealthyReicpe
{
    public class indexHealthyModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;
        
        public indexHealthyModel(UnitOfWork UnitOfWork)
        {
            _unitOfWork = UnitOfWork;
        }

        public IList<HealthyRecipes> HealthyRecipes { get; set; }
        public async Task OnGetAsync()
        {
            if (_unitOfWork != null)
            {

                HealthyRecipes =  _unitOfWork.HealthyRecipesRepository.GetAllEntity();
            }
        }
    }
}

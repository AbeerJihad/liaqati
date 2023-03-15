using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace liaqati_master.Pages.Product
{
    public class indexProductModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;
        
        public indexProductModel(UnitOfWork UnitOfWork)
        {
            _unitOfWork = UnitOfWork;
        }

        public IList<Products> Products { get; set; }
        public async Task OnGetAsync()
        {
            if (_unitOfWork != null)
            {

                Products =  _unitOfWork.ProductsRepository.GetAllEntity();
            }
        }
    }
}

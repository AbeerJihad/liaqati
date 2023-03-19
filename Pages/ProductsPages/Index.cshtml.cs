using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.ProductsPages
{
    public class IndexModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;

        public IndexModel(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            lstProuduct = unitOfWork.ProductsRepository.Get().ToList();

        }
        public IList<Products> lstProuduct { get; set; }

        public void OnGet()
        {
        }
    }
}

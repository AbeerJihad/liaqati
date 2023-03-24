using liaqati_master.Model;
using liaqati_master.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace liaqati_master.Pages.ProductsPages
{
    public class IndexModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;

        public IndexModel(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;


        }

        [BindProperty(SupportsGet = true)]
        public ProductQueryParamters Parameters { get; set; }

        public QueryPageResult<Products> queryPageResult { get; set; }


        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value="MinPrice",Text="الأقل سعرا"},
            new SelectListItem(){Value="MaxPrice",Text="الأعلى سعرا"},
            new SelectListItem(){Value="MaxRate",Text="الأغلى تقييما"},
        };

        public async Task OnGet()
        {
            IQueryable<Products> products = _unitOfWork.ProductsRepository.Get().AsQueryable();

            if (Parameters.CategoryId != null)
            {
                products = products.Where(p => p.services.CategoryId == Parameters.CategoryId);
            }

            if (Parameters.MinPrice != null)
            {
                products = products.Where(p => p.services.Price >= Parameters.MinPrice);
            }

            if (Parameters.MaxPrice != null)
            {
                products = products.Where(p => p.services.Price <= Parameters.MaxPrice);
            }

            if (!string.IsNullOrEmpty(Parameters.SearchTearm))
            {
                products = products.Where(p =>
                    p.services.Title.ToLower().Contains(Parameters.SearchTearm.ToLower())
                 );
            }

            if (!string.IsNullOrEmpty(Parameters.Tilte))
            {
                products = products.Where(p => p.services.Title.ToLower() == Parameters.Tilte.ToLower());
            }

            //  products = products.OrderByCustom(Parameters.SortBy, Parameters.SortOrder);
            if (!string.IsNullOrEmpty(Parameters.SortBy))
            {
                if (Parameters.SortBy.Equals("MinPrice", StringComparison.OrdinalIgnoreCase))
                {
                    products = products.OrderBy(p => p.services.Price);

                }
                else if (Parameters.SortBy.Equals("MaxPrice", StringComparison.OrdinalIgnoreCase))
                {
                    products = products.OrderByDescending(p => p.services.Price);

                }
            }
            queryPageResult = new()
            {
                TotalCount = products.Count()
            };
            queryPageResult.TotalPages = (int)Math.Ceiling(queryPageResult.TotalCount / (double)Parameters.Size);
            if ((Parameters.CurPage - 1) > 0)
                queryPageResult.PreviousPage = Parameters.CurPage - 1;

            if ((Parameters.CurPage + 1) <= queryPageResult.TotalPages)
                queryPageResult.NextPage = Parameters.CurPage + 1;

            if (queryPageResult.TotalCount == 0)
                queryPageResult.FirstRowOnPage = queryPageResult.LastRowOnPage = 0;
            else
            {
                queryPageResult.FirstRowOnPage = (Parameters.CurPage - 1) * Parameters.Size + 1;
                queryPageResult.LastRowOnPage = Math.Min(Parameters.CurPage * Parameters.Size, queryPageResult.TotalCount);
            }

            products = products.Skip(Parameters.Size * (Parameters.CurPage - 1))
                .Take(Parameters.Size);
            queryPageResult.ListOfData = products;

            //return RedirectToPage("./index");
        }
    }
}

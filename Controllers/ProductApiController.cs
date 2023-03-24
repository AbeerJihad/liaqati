using liaqati_master.Model;
using liaqati_master.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;
        public ProductApiController(LiaqatiDBContext context)
        {
            _context = context;
        }

        [HttpGet("AllProduct")]
        public async Task<ActionResult<List<Products>>> GetAllProduct()
        {

            return Ok(await _context.TblProducts.ToArrayAsync());
        }

        [HttpGet("GetProductsById/{id}")]
        public async Task<ActionResult<List<Products>>> GetProductsById(string id)
        {

            return Ok(await _context.TblProducts.FindAsync(id));
        }

        [HttpGet("GetProductsByCatId/{id}")]
        public async Task<ActionResult<List<Products>>> GetProductsByCatId(string id)
        {
            List<Products> list = _context.TblProducts.ToList();
            try
            {
                list = list.Where(x => x.services.CategoryId == id).ToList();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }
            return Ok(list);
        }


        [HttpGet("LatesProducts")]
        public async Task<ActionResult<List<Products>>> LatesProducts()
        {

            return Ok(await _context.TblProducts.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        [HttpPost]
        public async Task<ActionResult<Products>> AddProducts([FromForm] Products Products)
        {
            await _context.TblProducts.AddAsync(Products);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            return Ok(Products);

        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<Products>> DeleteProducts(int id)
        {
            Products item = _context.TblProducts.Find(id);

            if (item == null)
            {
                return NotFound();
            }
            try
            {
                _context.TblProducts.Remove(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }
            return Ok();
        }

        [HttpDelete("{DeleteToList}")]
        public async Task<ActionResult<List<Products>>> DeleteMultiProducts([FromForm] string[] ids)
        {
            var plist = new List<Products>();
            foreach (var id in ids)
            {
                var Products = _context.TblProducts.Find(id);
                if (Products == null)
                {
                    return NotFound();
                }
                else
                {
                    plist.Add(Products);
                }
            }
            try
            {
                _context.TblProducts.RemoveRange(plist);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }
            return Ok(plist);

        }


        [HttpPut("EditArticles/{id}")]
        public async Task<ActionResult<Products>> EditArticles(int id, Products Products)
        {
            if (_context.TblProducts.Find(id) == null)
            {
                return BadRequest();
            }
            //  _context.Product.Update(product);
            _context.Entry(Products).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }
            return Ok();
        }
        [HttpGet]
        [Route("search")]
        public async Task<ActionResult> SearchForProduct([FromQuery] ProductQueryParamters Parameters)
        {

            IQueryable<Products> products = _context.TblProducts;

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
            //if(! string.IsNullOrEmpty(pqParameters.SortBy))
            //{
            //    if(pqParameters.SortBy.Equals("Price",StringComparison.OrdinalIgnoreCase))
            //    {
            //        if(pqParameters.SortOrder.Equals("asc",StringComparison.OrdinalIgnoreCase))
            //            products=products.OrderBy(p => p.Price);
            //        else if (pqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
            //            products = products.OrderByDescending(p => p.Price);

            //    }
            //}
            QueryPageResult<Products> queryPageResult = new()
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
            Response.Headers.Add("PageStatstics", JsonSerializer.Serialize(queryPageResult));

            products = products.Skip(Parameters.Size * (Parameters.CurPage - 1))
                .Take(Parameters.Size);
            queryPageResult.ListOfData = products;

            return Ok(queryPageResult);

        }

    }
}

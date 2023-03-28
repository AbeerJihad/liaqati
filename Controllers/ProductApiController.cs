using liaqati_master.ViewModels;

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
        public async Task<ActionResult<List<Product>>> GetAllProduct()
        {

            return Ok(await _context.TblProducts.ToArrayAsync());
        }

        [HttpGet("GetProductsById/{id}")]
        public async Task<ActionResult<List<Product>>> GetProductsById(string id)
        {

            return Ok(await _context.TblProducts.FindAsync(id));
        }

        [HttpGet("GetProductsByCatId/{id}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCatId(string id)
        {
            List<Product> list = _context.TblProducts.ToList();
            try
            {
                list = list.Where(x => x.Services.CategoryId == id).ToList();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }
            return Ok(list);
        }


        [HttpGet("LatesProducts")]
        public async Task<ActionResult<List<Product>>> LatesProducts()
        {

            return Ok(await _context.TblProducts.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        [HttpPost]
        public async Task<ActionResult<Product>> AddProducts([FromForm] Product Products)
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
        public async Task<ActionResult<Product>> DeleteProducts(int id)
        {
            Product item = _context.TblProducts.Find(id);

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
        public async Task<ActionResult<List<Product>>> DeleteMultiProducts([FromForm] string[] ids)
        {
            var plist = new List<Product>();
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
        public async Task<ActionResult<Product>> EditArticles(int id, Product Products)
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

            IQueryable<Product> products = _context.TblProducts;

            if (Parameters.CategoryId != null)
            {
                products = products.Where(p => p.Services.CategoryId == Parameters.CategoryId);
            }

            if (Parameters.MinPrice != null)
            {
                products = products.Where(p => p.Services.Price >= Parameters.MinPrice);
            }

            if (Parameters.MaxPrice != null)
            {
                products = products.Where(p => p.Services.Price <= Parameters.MaxPrice);
            }

            if (!string.IsNullOrEmpty(Parameters.SearchTearm))
            {
                products = products.Where(p =>
                    p.Services.Title.ToLower().Contains(Parameters.SearchTearm.ToLower())
                 );
            }

            if (!string.IsNullOrEmpty(Parameters.Tilte))
            {
                products = products.Where(p => p.Services.Title.ToLower() == Parameters.Tilte.ToLower());
            }

            if (!string.IsNullOrEmpty(Parameters.SortBy))
            {
                if (Parameters.SortBy.Equals("MinPrice", StringComparison.OrdinalIgnoreCase))
                {
                    products = products.OrderBy(p => p.Services.Price);

                }
                else if (Parameters.SortBy.Equals("MaxPrice", StringComparison.OrdinalIgnoreCase))
                {
                    products = products.OrderByDescending(p => p.Services.Price);

                }
            }
            QueryPageResult<Product> queryPageResult = new()
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
            Response.Headers.Add("PageStatstics", System.Text.Json.JsonSerializer.Serialize(queryPageResult));

            products = products.Skip(Parameters.Size * (Parameters.CurPage - 1))
                .Take(Parameters.Size);
            queryPageResult.ListOfData = products;

            return Ok(queryPageResult);

        }

    }
}

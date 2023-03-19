using Microsoft.AspNetCore.Mvc;

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





    }
}

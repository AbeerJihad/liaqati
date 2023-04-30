using liaqati_master.Services.Repositories;
using liaqati_master.ViewModels;

namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;
         readonly IRepoProgram _repoprogram;


        public OrderApiController(LiaqatiDBContext context , IRepoProgram repoprogram)
        {
            _context = context;
            _repoprogram = repoprogram;

        }

        [HttpGet("AllOrder")]
        public async Task<ActionResult<List<Order>>> GetAllOrder()
        {

            return Ok(await _context.TblOrder.ToArrayAsync());
        }

        [HttpGet("GetOrderById/{id}")]

        public async Task<ActionResult<List<Order>>> GetOrderById(string id)
        {

            return Ok(await _context.TblOrder.FindAsync(id));
        }


        [HttpGet("LatesOrder")]
        public async Task<ActionResult<List<Order>>> LatesOrder()
        {

            return Ok(await _context.TblOrder.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        ///
        [HttpPost("AddOrder")]
        public async Task<ActionResult<Order>> AddOrder([FromForm] Order Order)
        {
            await _context.TblOrder.AddAsync(Order);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


            return Ok(Order);

        }

        [HttpDelete("DeleteOrder/{id}")]

        public async Task<ActionResult<Order>> DeleteOrder(string id)
        {
            Order item = _context.TblOrder.Find(id);

            if (item == null)
            {
                return NotFound();
            }




            try
            {
                _context.TblOrder.Remove(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }

            return Ok();

        }

        [HttpDelete("{DeleteToList}")]


        public async Task<ActionResult<List<Order>>> DeleteMultiSportsProgram([FromForm] string[] ids)
        {
            var plist = new List<Order>();

            foreach (string id in ids)
            {
                var Order = _context.TblOrder.Find(id);

                if (Order == null)
                {
                    return NotFound();
                }
                else
                {
                    plist.Add(Order);

                }

            }
            try
            {
                _context.TblOrder.RemoveRange(plist);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });

            }

            return Ok(plist);

        }


        [HttpPut("EditOrder/{id}")]

        public async Task<ActionResult<Order>> EditSportsProgram(string id, Order Order)
        {
            if (_context.TblOrder.Find(id) == null)
            {
                return BadRequest();
            }


            //  _context.Product.Update(product);
            _context.Entry(Order).State = EntityState.Modified;

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


        //[HttpPost]
        //[Route("SearchForOrder")]
        //public async Task<ActionResult> SearchForOrder([FromBody] ProgramQueryParamters exqParameters)
        //{
        //    return Ok(await _repoprogram.SearchSportsProgram(exqParameters));





        //}







    }
}

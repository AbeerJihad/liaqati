using liaqati_master.Services.Repositories;
using liaqati_master.ViewModels;

namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredentApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;
         readonly IRepoProgram _repoprogram;


        public IngredentApiController(LiaqatiDBContext context , IRepoProgram repoprogram)
        {
            _context = context;
            _repoprogram = repoprogram;

        }

        [HttpGet("AllIngredent")]
        public async Task<ActionResult<List<Ingredent>>> GetAllIngredent()
        {

            return Ok(await _context.TblIngredent.ToArrayAsync());
        }

        [HttpGet("GetIngredentById/{id}")]

        public async Task<ActionResult<List<Ingredent>>> GetIngredentById(string id)
        {

            return Ok(await _context.TblIngredent.FindAsync(id));
        }


        [HttpGet("LatesIngredent")]
        public async Task<ActionResult<List<Ingredent>>> LatesIngredent()
        {

            return Ok(await _context.TblIngredent.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        ///
        [HttpPost("AddIngredent")]
        public async Task<ActionResult<Ingredent>> AddOrder([FromForm] Ingredent Ingredent)
        {
            await _context.TblIngredent.AddAsync(Ingredent);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


            return Ok(Ingredent);

        }

        [HttpDelete("DeleteIngredent/{id}")]

        public async Task<ActionResult<Ingredent>> DeleteIngredent(string id)
        {
            Ingredent item = _context.TblIngredent.Find(id);

            if (item == null)
            {
                return NotFound();
            }




            try
            {
                _context.TblIngredent.Remove(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }

            return Ok();

        }

        [HttpDelete("{DeleteToList}")]


        public async Task<ActionResult<List<Ingredent>>> DeleteMultiIngredent([FromForm] string[] ids)
        {
            var plist = new List<Ingredent>();

            foreach (string id in ids)
            {
                var Ingredent = _context.TblIngredent.Find(id);

                if (Ingredent == null)
                {
                    return NotFound();
                }
                else
                {
                    plist.Add(Ingredent);

                }

            }
            try
            {
                _context.TblIngredent.RemoveRange(plist);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });

            }

            return Ok(plist);

        }


        [HttpPut("EditIngredent/{id}")]

        public async Task<ActionResult<Ingredent>> EditIngredent(string id, Ingredent Ingredent)
        {
            if (_context.TblIngredent.Find(id) == null)
            {
                return BadRequest();
            }


            //  _context.Product.Update(product);
            _context.Entry(Ingredent).State = EntityState.Modified;

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

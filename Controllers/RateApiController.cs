using liaqati_master.Services.Repositories;
using liaqati_master.ViewModels;

namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;
         readonly IRepoProgram _repoprogram;


        public RateApiController(LiaqatiDBContext context , IRepoProgram repoprogram)
        {
            _context = context;
            _repoprogram = repoprogram;

        }

        [HttpGet("AllRate")]
        public async Task<ActionResult<List<Rate>>> GetAllOrder()
        {

            return Ok(await _context.TblRate.ToArrayAsync());
        }

        [HttpGet("GetRateById/{id}")]

        public async Task<ActionResult<List<Rate>>> GetRateById(string id)
        {

            return Ok(await _context.TblRate.FindAsync(id));
        }


        [HttpGet("LatesRate")]
        public async Task<ActionResult<List<Rate>>> LatesRate()
        {

            return Ok(await _context.TblRate.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        ///
        [HttpPost("AddRate")]
        public async Task<ActionResult<Rate>> AddRate([FromForm] Rate Rate)
        {
            await _context.TblRate.AddAsync(Rate);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


            return Ok(Rate);

        }


        //[HttpPost]
        //[Route("SearchForOrder")]
        //public async Task<ActionResult> SearchForOrder([FromBody] ProgramQueryParamters exqParameters)
        //{
        //    return Ok(await _repoprogram.SearchSportsProgram(exqParameters));





        //}







    }
}

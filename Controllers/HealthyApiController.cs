using liaqati_master.Services.Repositories;


namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthyApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;
        private readonly IRepoHealthyRecipe _repoHealthyRecipe;

        public HealthyApiController(LiaqatiDBContext context, IRepoHealthyRecipe repoHealthyRecipe)
        {
            _context = context;
            _repoHealthyRecipe = repoHealthyRecipe;
        }

        [HttpGet("AllHealthyRecipe")]
        public async Task<ActionResult<List<HealthyRecipe>>> GetAllHealthyRecipe()
        {

            return Ok(await _context.TblHealthyRecipe.ToArrayAsync());
        }

        [HttpGet("GetHealthyRecipeById/{id}")]

        public async Task<ActionResult<List<HealthyRecipe>>> GetHealthyRecipeById(string id)
        {

            return Ok(await _context.TblHealthyRecipe.FindAsync(id));
        }




        [HttpGet("LatesHealthyRecipe")]
        public async Task<ActionResult<List<HealthyRecipe>>> HealthyRecipeExercise()
        {

            return Ok(await _context.TblHealthyRecipe.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        [HttpPost]
        public async Task<ActionResult<HealthyRecipe>> AddArticles([FromForm] HealthyRecipe HealthyRecipe)
        {



            await _context.TblHealthyRecipe.AddAsync(HealthyRecipe);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


            return Ok(HealthyRecipe);

        }

        [HttpDelete("DeleteHealthyRecipe/{id}")]
        public async Task<ActionResult<HealthyRecipe>> DeleteHealthyRecipe(string id)
        {
            HealthyRecipe item = _context.TblHealthyRecipe.Find(id);

            if (item == null)
            {
                return NotFound();
            }




            try
            {
                _context.TblHealthyRecipe.Remove(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }

            return Ok();

        }

        [HttpDelete("{DeleteToList}")]
        public async Task<ActionResult<List<HealthyRecipe>>> DeleteMultiExercise([FromForm] string[] ids)
        {
            var plist = new List<HealthyRecipe>();

            foreach (string id in ids)
            {
                var HealthyRecipe = _context.TblHealthyRecipe.Find(id);

                if (HealthyRecipe == null)
                {
                    return NotFound();
                }
                else
                {
                    plist.Add(HealthyRecipe);

                }

            }
            try
            {
                _context.TblHealthyRecipe.RemoveRange(plist);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });

            }

            return Ok(plist);

        }


        [HttpPut("EditHealthyRecipe/{id}")]
        public async Task<ActionResult<HealthyRecipe>> EditExercise(int id, HealthyRecipe HealthyRecipe)
        {
            if (_context.TblHealthyRecipe.Find(id) == null)
            {
                return BadRequest();
            }


            //  _context.Product.Update(product);
            _context.Entry(HealthyRecipe).State = EntityState.Modified;

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
        [HttpPost]
        [Route("searchforHealty")]
        public async Task<ActionResult> Search([FromBody] HealthyRecipeQueryParamters exqParameters)
        {
            return Ok(await _repoHealthyRecipe.SearchHealty(exqParameters));
        }
    }
}

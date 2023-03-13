using Microsoft.AspNetCore.Mvc;

namespace ProgectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;


        public ExerciseApiController(LiaqatiDBContext context)
        {
            _context = context;

        }

        [HttpGet("AllExercise")]
        public async Task<ActionResult<List<Exercise>>> GetAllExercise()
        {

            return Ok(await _context.TblExercises.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Exercise>>> GetExerciseById(int id)
        {

            return Ok(await _context.TblExercises.FindAsync(id));
        }




        [HttpGet("LatesExercise")]
        public async Task<ActionResult<List<Exercise>>> LatesExercise()
        {

            return Ok(await _context.TblExercises.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        [HttpPost]
        public async Task<ActionResult<Exercise>> AddArticles([FromForm] Exercise Exercise)
        {



            await _context.TblExercises.AddAsync(Exercise);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


            return Ok(Exercise);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Exercise>> DeleteExercise(int id)
        {
            Exercise item = _context.TblExercises.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            try
            {
                _context.TblExercises.Remove(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }

            return Ok();

        }

        [HttpDelete("{Delete}")]


        public async Task<ActionResult<List<Exercise>>> DeleteMultiExercise([FromForm] int[] ids)
        {
            var plist = new List<Exercise>();

            foreach (int id in ids)
            {
                var Exercise = _context.TblExercises.Find(id);

                if (Exercise == null)
                {
                    return NotFound();
                }
                else
                {
                    plist.Add(Exercise);

                }

            }
            try
            {
                _context.TblExercises.RemoveRange(plist);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });

            }

            return Ok(plist);

        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Exercise>> EditExercise(int id, Exercise Exercise)
        {
            if (_context.TblExercises.Find(id) == null)
            {
                return BadRequest();
            }


            //  _context.Product.Update(product);
            _context.Entry(Exercise).State = EntityState.Modified;

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

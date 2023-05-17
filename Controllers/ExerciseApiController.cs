using System.Security.Claims;

namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseApiController : ControllerBase
    {
        private readonly LiaqatiDBContext _context;
        private readonly IRepoExercise _repoExercise;
        private readonly IRepoFavorite _IRepoFavorite;
        public ExerciseApiController(LiaqatiDBContext context, IRepoExercise repoExercise, IRepoFavorite iRepoFavorite)
        {
            _context = context;
            _repoExercise = repoExercise;
            _IRepoFavorite = iRepoFavorite;
        }

        [HttpGet("AllExercise")]
        public async Task<ActionResult<List<Exercise>>> GetAllExercise()
        {
            return Ok(await _context.TblExercises.ToArrayAsync());
        }
        [HttpGet("GetExerciseById/{id}")]
        public async Task<ActionResult<List<Exercise>>> GetExerciseById(int id)
        {

            return Ok(await _context.TblExercises.FindAsync(id));
        }

        [HttpGet("LatesExercise")]
        public async Task<ActionResult<List<Exercise>>> LatesExercise()
        {

            return Ok(await _context.TblExercises.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        [HttpPost("AddExercise")]
        public async Task<ActionResult<Exercise>> AddExercise([FromForm] Exercise Exercise)
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

        [HttpDelete("DeleteExercise/{id}")]

        public async Task<ActionResult<Exercise>> DeleteExercise(int id)
        {
            Exercise? item = await _context.TblExercises.FindAsync(id);

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

        [HttpDelete("{DeleteToList}")]
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


        [HttpPut("EditExercise/{id}")]

        public async Task<ActionResult<Exercise>> EditExercise(int id, Exercise Exercise)
        {
            if (_context.TblExercises.Find(id) == null)
            {
                return BadRequest();
            }
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

        [HttpPost]
        [Route("searchforExercise")]
        public async Task<ActionResult> Search([FromBody] ExerciseQueryParamters exqParameters)
        {
            return Ok(await _repoExercise.SearchExercies(exqParameters));
        }
        [HttpGet("AddFavoritesExercises/{id}")]
        public async Task<ActionResult<string>> AddFavorites(string id)
        {
            string IsAdd = "";
            List<Favorite> Favorites = new();
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null && id is not null)
            {

                var lstoffav = await _IRepoFavorite.GetByUserIDAsync(userid);
                if (lstoffav is not null)
                {
                    Favorites = lstoffav.Where(p => p.ExerciseId == id).ToList();
                }
                if (!Favorites.Any())
                {

                    Favorite favorite = new Favorite()
                    {
                        ExerciseId = id,
                        Type = "تمارين",
                        Id = CommonMethods.Id_Guid(),
                        UserId = userid
                    };

                    await _IRepoFavorite.AddEntityAsync(favorite);
                    IsAdd = "true";
                }
                else
                {
                    await _IRepoFavorite.DeleteByExerIdAsync(id);
                    IsAdd = "false";
                }

            }
            else
            {
                IsAdd = "null";
            }





            return Ok(IsAdd);
        }


    }
}

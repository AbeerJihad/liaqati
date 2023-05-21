using liaqati_master.Services.Repositories;
using System.Security.Claims;

namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthyApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;
        private readonly IRepoHealthyRecipe _repoHealthyRecipe;
        private readonly IRepoFavorite _IRepoFavorite;


        public HealthyApiController(LiaqatiDBContext context, IRepoHealthyRecipe repoHealthyRecipe, IRepoFavorite iRepoFavorite)
        {
            _context = context;
            _repoHealthyRecipe = repoHealthyRecipe;
            _IRepoFavorite = iRepoFavorite;
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
            var item = _context.TblHealthyRecipe.Find(id);

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




        [HttpGet("AddFavoritesToHealthy/{id}")]
        public async Task<ActionResult<string>> AddFavoritesToHealthy(string id)
        {
            string IsAdd = "";
            List<Favorite> Favorites = new();

            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null && id is not null)
            {

                var lstOfFav = await _IRepoFavorite.GetByUserIDAsync(userid);

                if (lstOfFav is not null)
                {
                    Favorites = lstOfFav.Where(p => p.HealthyRecipeId == id).ToList();
                }
                if (!Favorites.Any())
                {
                    Favorite favorite = new()
                    {
                        HealthyRecipeId = id,
                        Type = "وصفات",
                        Id = CommonMethods.Id_Guid(),
                        UserId = userid
                    };
                    try
                    {
                        await _IRepoFavorite.AddEntityAsync(favorite);

                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                    IsAdd = "true";
                }
                else
                {
                    try
                    {
                        await _IRepoFavorite.DeleteByHealIdAsync(id);
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }

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

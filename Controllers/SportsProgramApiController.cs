using System.Security.Claims;

namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsProgramApiController : ControllerBase
    {

        readonly LiaqatiDBContext _context;
        readonly IRepoProgram _repoprogram;
        readonly IRepoFavorite _IRepoFavorite;
        readonly IHttpContextAccessor _HttpContextAccessor;

        public SportsProgramApiController(LiaqatiDBContext context, IRepoProgram repoprogram, IRepoFavorite iRepoFavorite, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _repoprogram = repoprogram;
            _IRepoFavorite = iRepoFavorite;
            _HttpContextAccessor = httpContextAccessor;
        }
        [HttpGet("AllSportsProgram")]
        public async Task<ActionResult<List<SportsProgram>>> GetAllSportsProgram()
        {
            return Ok(await _context.TblSportsProgram.ToArrayAsync());
        }

        [HttpGet("GetSportsProgramById/{id}")]
        public async Task<ActionResult<List<SportsProgram>>> GetSportsProgramById(int id)
        {

            return Ok(await _context.TblSportsProgram.FindAsync(id));
        }

        [HttpGet("LatesSportsProgram")]
        public async Task<ActionResult<List<SportsProgram>>> LatesSportsProgram()
        {

            return Ok(await _context.TblSportsProgram.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        [HttpPost("AddSportsProgram")]
        public async Task<ActionResult<SportsProgram>> AddSportsProgram([FromForm] SportsProgram SportsProgram)
        {
            await _context.TblSportsProgram.AddAsync(SportsProgram);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


            return Ok(SportsProgram);

        }

        [HttpDelete("DeleteSportsProgram/{id}")]

        public async Task<ActionResult<SportsProgram>> DeleteSportsProgram(int id)
        {
            SportsProgram? item = _context.TblSportsProgram.Find(id);

            if (item == null)
            {
                return NotFound();
            }




            try
            {
                _context.TblSportsProgram.Remove(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }

            return Ok();

        }

        [HttpDelete("{DeleteToList}")]


        public async Task<ActionResult<List<SportsProgram>>> DeleteMultiSportsProgram([FromForm] int[] ids)
        {
            var plist = new List<SportsProgram>();

            foreach (int id in ids)
            {
                var SportsProgram = _context.TblSportsProgram.Find(id);

                if (SportsProgram == null)
                {
                    return NotFound();
                }
                else
                {
                    plist.Add(SportsProgram);

                }

            }
            try
            {
                _context.TblSportsProgram.RemoveRange(plist);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });

            }

            return Ok(plist);

        }


        [HttpPut("EditSportsProgram/{id}")]

        public async Task<ActionResult<SportsProgram>> EditSportsProgram(int id, SportsProgram SportsProgram)
        {
            if (_context.TblSportsProgram.Find(id) == null)
            {
                return BadRequest();
            }


            //  _context.Product.Update(product);
            _context.Entry(SportsProgram).State = EntityState.Modified;

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
        [Route("SearchForSportsProgram")]
        public async Task<ActionResult> SearchForSportsProgram([FromBody] SportProgramQueryParamters exqParameters)
        {
            return Ok(await _repoprogram.SearchSportsProgram(exqParameters));
        }

        [HttpGet("AddFavoritesSportsProgram/{id}")]
        public async Task<ActionResult<string>> AddFavorites(string id)
        {
            string IsAdd = "";
            List<Favorite> Favorites = new();
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null && id is not null)
            {
                var listOFfVA = await _IRepoFavorite.GetByUserIDAsync(userid);
                if (listOFfVA is not null)
                {
                    Favorites = listOFfVA.Where(p => p.ServicesId == id).ToList();
                }
                if (!Favorites.Any())
                {
                    Favorite favorite = new Favorite()
                    {
                        ServicesId = id,
                        Type = "نظام رياضي",
                        Id = CommonMethods.Id_Guid(),
                        UserId = userid
                    };
                    await _IRepoFavorite.AddEntityAsync(favorite);
                    IsAdd = "true";
                }
                else
                {
                    await _IRepoFavorite.DeleteBySerIdAsync(id);
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

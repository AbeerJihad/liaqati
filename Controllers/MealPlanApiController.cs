using System.Security.Claims;

namespace ProgectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealPlanApiController : ControllerBase
    {
        private readonly LiaqatiDBContext _context;
        private readonly IRepoMealPlans _IRepoMealPlans;
        private readonly IRepoFavorite _IRepoFavorite;

        public MealPlanApiController(LiaqatiDBContext context, IRepoMealPlans iRepoMealPlans, IRepoFavorite iRepoFavorite)
        {
            _context = context;
            _IRepoMealPlans = iRepoMealPlans;
            _IRepoFavorite = iRepoFavorite;
        }

        [HttpGet("AllMealPlan")]
        public async Task<ActionResult<List<MealPlans>>> GetAllMealPlan()
        {
            return Ok(await _context.TblMealPlans.ToArrayAsync());
        }

        [HttpGet("GetMealPlanById/{id}")]
        public async Task<ActionResult<List<MealPlans>>> GetMealPlanById(int id)
        {

            return Ok(await _context.TblMealPlans.FindAsync(id));
        }

        [HttpGet("LatesMealPlans")]
        public async Task<ActionResult<List<MealPlans>>> LatesMealPlans()
        {

            return Ok(await _context.TblMealPlans.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        [HttpPost("AddMealPlans")]
        public async Task<ActionResult<MealPlans>> AddMealPlans([FromForm] MealPlans MealPlans)
        {



            await _context.TblMealPlans.AddAsync(MealPlans);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


            return Ok(MealPlans);

        }

        [HttpDelete("DeleteMealPlans/{id}")]
        public async Task<ActionResult<MealPlans>> DeleteMealPlans(string id)
        {
            var item = _context.TblMealPlans.Find(id);

            if (item == null)
            {
                return NotFound();
            }
            try
            {
                _context.TblMealPlans.Remove(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }
            return Ok();

        }

        [HttpDelete("{Delete}")]
        public async Task<ActionResult<List<MealPlans>>> DeleteMultiMealPlans([FromForm] int[] ids)
        {
            var plist = new List<MealPlans>();

            foreach (int id in ids)
            {
                var MealPlans = _context.TblMealPlans.Find(id);

                if (MealPlans == null)
                {
                    return NotFound();
                }
                else
                {
                    plist.Add(MealPlans);

                }

            }
            try
            {
                _context.TblMealPlans.RemoveRange(plist);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });

            }

            return Ok(plist);

        }

        [HttpPut("Edit/{id}")]
        public async Task<ActionResult<MealPlans>> EditMealPlans(int id, MealPlans MealPlans)
        {
            if (_context.TblMealPlans.Find(id) == null)
            {
                return BadRequest();
            }


            //  _context.Product.Update(product);
            _context.Entry(MealPlans).State = EntityState.Modified;

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

        [Route("search")]
        public async Task<ActionResult> SearchForMealPlans([FromBody] MealPlansQueryParamters Parameters)
        {
            return Ok(await _IRepoMealPlans.SearchMealPlan(Parameters));

        }
        [HttpGet("CountExersie")]
        public async Task<ActionResult<VmMealsProgramDetails>> CountExersie(string id, int week, int day)
        {
            var list = _IRepoMealPlans.GetMultiMeal_Healthy(id, week, day);
            var Count = list.Count;
            VmMealsProgramDetails Exer = new() { list = list, Count = Count };

            return Ok(Exer);
        }
        [HttpGet("AddFavoritesMealPlan/{id}")]
        public async Task<ActionResult<string>> AddFavorites(string id)
        {
            string IsAdd = "";
            List<Favorite> Favorites = new();
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null && id is not null)
            {

                var lstOfFav = await _IRepoFavorite.GetByUserIDAsync(userid);
                if (lstOfFav is not null)
                {
                    Favorites = lstOfFav.Where(p => p.ServicesId == id).ToList();
                }
                if (!Favorites.Any())
                {
                    Favorite favorite = new()
                    {
                        ServicesId = id,
                        Type = "نظام غذائي",
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






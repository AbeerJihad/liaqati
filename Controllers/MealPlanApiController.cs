using System.Security.Claims;

namespace ProgectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealPlanApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;
        readonly IRepoMealPlans _IRepoMealPlans;
        readonly IRepoFavorite _IRepoFavorite;
        readonly IHttpContextAccessor _HttpContextAccessor;

        public MealPlanApiController(LiaqatiDBContext context, IRepoMealPlans iRepoMealPlans, IRepoFavorite iRepoFavorite, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _IRepoMealPlans = iRepoMealPlans;
            _IRepoFavorite = iRepoFavorite;
            _HttpContextAccessor = httpContextAccessor;
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
            IQueryable<MealPlanVM> products = (await _IRepoMealPlans.GetAllAsync()).Select(p =>
               new MealPlanVM()
               {
                   CategoryName = p.Services?.Category?.Name,
                   Id = p.Id,
                   Images = p.Services?.Files?.Select(p => p.Path)?.ToList(),
                   CategoryId = p.Services?.CategoryId,
                   Length = p.Length,
                   DietaryType = p.DietaryType,
                   MealType = p.MealType,
                   Price = p.Services?.Price,
                   Title = p.Services?.Title,
                   IsFavorite = 0,
                   shortDescription = p.Services?.ShortDescription,
               }).AsQueryable();

            List<Favorite>? list = new();
            List<MealPlanVM>? products2 = new();
            List<string?>? list2 = new();
            if (_HttpContextAccessor.HttpContext is not null)
            {
                var user = _HttpContextAccessor.HttpContext.User;
                products2 = products.ToList();

                if (user is null)
                {

                    foreach (var item in products2)
                    {
                        item.IsFavorite = 0;
                    }
                }
                else
                {
                    list = await _IRepoFavorite.GetByUserIDAsync(user.FindFirstValue(ClaimTypes.NameIdentifier));
                    if (list is not null)
                    {
                        list2 = list.Where(p => p.Type == "نظام غذائي").Select(s => s.ServicesId).ToList();
                    }
                    foreach (var item in products2)
                    {
                        if (list2.Contains(item.Id))
                            item.IsFavorite = 2;
                        else if (!list2.Contains(item.Id))
                            item.IsFavorite = 1;
                    }
                }
                products = products2.AsQueryable();
            }

            if (Parameters.CategoryId != null)
            {
                products = products.Where(p => p.CategoryId == Parameters.CategoryId);
            }
            if (Parameters.MinPrice != null)
            {
                products = products.Where(p => p.Price >= Parameters.MinPrice);
            }
            if (Parameters.MaxPrice != null)
            {
                products = products.Where(p => p.Price <= Parameters.MaxPrice);
            }
            if (!string.IsNullOrEmpty(Parameters.SearchTearm))
            {
                products = products.Where(p => p.Title != null && p.Title.ToLower().Contains(Parameters.SearchTearm.ToLower()));
            }
            QueryPageResult<MealPlanVM> queryPageResult = CommonMethods.GetPageResult(products, Parameters);
            return Ok(queryPageResult);

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






namespace ProgectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealPlanApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;
        readonly IRepoMealPlans _IRepoMealPlans;
        readonly UnitOfWork _unitOfWork;



        public MealPlanApiController(LiaqatiDBContext context, UnitOfWork unitOfWork, IRepoMealPlans iRepoMealPlans)
        {
            _context = context;
            _unitOfWork = unitOfWork;
            _IRepoMealPlans = iRepoMealPlans;
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

        [HttpPost]
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




        [HttpGet]
        [Route("search")]
        public async Task<ActionResult> SearchForMealPlans([FromQuery] MealPlansQueryParamters Parameters)
        {
            IQueryable<MealPlans> products = (await _IRepoMealPlans.GetAllAsync()).AsQueryable();
            if (Parameters.CategoryId != null)
            {
                products = products.Where(p => p.Services.CategoryId == Parameters.CategoryId);
            }
            if (Parameters.MinPrice != null)
            {
                products = products.Where(p => p.Services.Price >= Parameters.MinPrice);
            }
            if (Parameters.MaxPrice != null)
            {
                products = products.Where(p => p.Services.Price <= Parameters.MaxPrice);
            }
            if (!string.IsNullOrEmpty(Parameters.SearchTearm))
            {
                products = products.Where(p => p.Services.Title.ToLower().Contains(Parameters.SearchTearm.ToLower()));
            }
            QueryPageResult<MealPlans> queryPageResult = CommonMethods.GetPageResult(products, Parameters);
            return Ok(queryPageResult);

        }



    }
}






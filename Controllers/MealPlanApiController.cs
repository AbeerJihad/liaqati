using Microsoft.AspNetCore.Mvc;

namespace ProgectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealPlanApiController : ControllerBase
    {
        private readonly LiaqatiDBContext _context;
        public MealPlanApiController(LiaqatiDBContext context)
        {
            _context = context;
        }

        [HttpGet("AllMealPlan")]
        public async Task<ActionResult<List<MealPlans>>> GetAllMealPlan()
        {

            return Ok(await _context.TblMealPlans.ToArrayAsync());
        }

        [HttpGet("{id}")]
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

        [HttpDelete("{id}")]
        public async Task<ActionResult<MealPlans>> DeleteMealPlans(int id)
        {
            MealPlans item = _context.TblMealPlans.Find(id);

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



        [HttpPut("{id}")]
        public async Task<ActionResult<MealPlans>> EditArticles(int id, MealPlans MealPlans)
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





    }
}






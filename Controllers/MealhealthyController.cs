namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    // [ApiController]
    public class MealhealthyController : ControllerBase
    {
        readonly LiaqatiDBContext _context;


        public MealhealthyController(LiaqatiDBContext context)
        {
            _context = context;

        }

        [HttpGet("AllMealhealthy")]
        public async Task<ActionResult<List<Meal_Healthy>>> GetAllMealhealthy()
        {

            return Ok(await _context.TblMeal_Healthy.ToArrayAsync());
        }


        [HttpGet("AllMealhealthies/{id}")]
        public async Task<ActionResult<List<Meal_Healthy>>> GetAllMealhealthyByMealId(string id)
        {

            IEnumerable<Meal_Healthy> list = _context.TblMeal_Healthy.ToList().Where(p => p.MealPlansId == id);

            return Ok(list);
        }





        [HttpPost("AddMealhealthy")]
        public async Task<ActionResult<Meal_Healthy>> AddMealhealthy([FromBody] vmMeal_Healthy vmMeal_Healthy)
        {

            if (vmMeal_Healthy == null)
            {

                return NotFound();


            }

            Meal_Healthy Meal_Healthy = new Meal_Healthy()
            {
                Id = vmMeal_Healthy.Id,
                HealthyRecdpeId = vmMeal_Healthy.HealthyRecdpeId,
                MealPlansId = vmMeal_Healthy.MealPlansId,
                Day = vmMeal_Healthy.Day,
                Week = vmMeal_Healthy.Week

            };



            await _context.TblMeal_Healthy.AddAsync(Meal_Healthy);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


            return Ok(Meal_Healthy);

        }







    }
}

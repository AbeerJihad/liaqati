using liaqati_master.Services.Repositories;
using liaqati_master.ViewModels;

namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;
         readonly IRepoProgram _repoprogram;


        public NotificationApiController(LiaqatiDBContext context , IRepoProgram repoprogram)
        {
            _context = context;
            _repoprogram = repoprogram;

        }

        [HttpGet("AllNotification")]
        public async Task<ActionResult<List<Notification>>> GetAllNotification()
        {

            return Ok(await _context.TblNotification.ToArrayAsync());
        }

        [HttpGet("GetNotificationById/{id}")]

        public async Task<ActionResult<List<Notification>>> GetNotificationById(string id)
        {

            return Ok(await _context.TblNotification.FindAsync(id));
        }


        [HttpGet("LatesNotification")]
        public async Task<ActionResult<List<Notification>>> LatesNotification()
        {

            return Ok(await _context.TblNotification.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        ///
        [HttpPost("AddNotification")]
        public async Task<ActionResult<Notification>> AddOrder([FromForm] Notification Notification)
        {
            await _context.TblNotification.AddAsync(Notification);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


            return Ok(Notification);

        }

        [HttpDelete("DeleteNotification/{id}")]

        public async Task<ActionResult<Notification>> DeleteNotification(string id)
        {
            Notification item = _context.TblNotification.Find(id);

            if (item == null)
            {
                return NotFound();
            }




            try
            {
                _context.TblNotification.Remove(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }

            return Ok();

        }

        [HttpDelete("{DeleteToList}")]


        public async Task<ActionResult<List<Notification>>> DeleteMultiNotification([FromForm] string[] ids)
        {
            var plist = new List<Notification>();

            foreach (string id in ids)
            {
                var Notification = _context.TblNotification.Find(id);

                if (Notification == null)
                {
                    return NotFound();
                }
                else
                {
                    plist.Add(Notification);

                }

            }
            try
            {
                _context.TblNotification.RemoveRange(plist);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });

            }

            return Ok(plist);

        }


    

        //[HttpPost]
        //[Route("SearchForOrder")]
        //public async Task<ActionResult> SearchForOrder([FromBody] ProgramQueryParamters exqParameters)
        //{
        //    return Ok(await _repoprogram.SearchSportsProgram(exqParameters));





        //}







    }
}

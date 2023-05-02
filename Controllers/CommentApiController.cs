using liaqati_master.Services.Repositories;
using liaqati_master.ViewModels;

namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;
         readonly IRepoProgram _repoprogram;


        public CommentApiController(LiaqatiDBContext context , IRepoProgram repoprogram)
        {
            _context = context;
            _repoprogram = repoprogram;

        }
        
        [HttpGet("AllComment")]
        public async Task<ActionResult<List<Comments>>> GetAllOrder()
        {

            return Ok(await _context.TblComment.ToArrayAsync());
        }

        [HttpGet("GetCommentsById/{id}")]

        public async Task<ActionResult<List<Comments>>> GetCommentsById(string id)
        {

            return Ok(await _context.TblComment.FindAsync(id));
        }


        [HttpGet("LatesComments")]
        public async Task<ActionResult<List<Comments>>> LatesComments()
        {

            return Ok(await _context.TblComment.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        ///
        [HttpPost("AddComments")]
        public async Task<ActionResult<Comments>> AddComments([FromForm] Comments Comments)
        {
            await _context.TblComment.AddAsync(Comments);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


            return Ok(Comments);

        }

        [HttpDelete("DeleteComments/{id}")]

        public async Task<ActionResult<Comments>> DeleteComments(string id)
        {
            Comments item = _context.TblComment.Find(id);

            if (item == null)
            {
                return NotFound();
            }




            try
            {
                _context.TblComment.Remove(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }

            return Ok();

        }

        [HttpDelete("{DeleteToList}")]


        public async Task<ActionResult<List<Comments>>> DeleteMultiComments([FromForm] string[] ids)
        {
            var plist = new List<Comments>();

            foreach (string id in ids)
            {
                var Comments = _context.TblComment.Find(id);

                if (Comments == null)
                {
                    return NotFound();
                }
                else
                {
                    plist.Add(Comments);

                }

            }
            try
            {
                _context.TblComment.RemoveRange(plist);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });

            }

            return Ok(plist);

        }


        [HttpPut("EditComments/{id}")]

        public async Task<ActionResult<Comments>> EditComments(string id, Comments Comments)
        {
            if (_context.TblComment.Find(id) == null)
            {
                return BadRequest();
            }


            //  _context.Product.Update(product);
            _context.Entry(Comments).State = EntityState.Modified;

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


        //[HttpPost]
        //[Route("SearchForOrder")]
        //public async Task<ActionResult> SearchForOrder([FromBody] ProgramQueryParamters exqParameters)
        //{
        //    return Ok(await _repoprogram.SearchSportsProgram(exqParameters));





        //}







    }
}

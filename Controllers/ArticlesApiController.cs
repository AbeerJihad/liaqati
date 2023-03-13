using Microsoft.AspNetCore.Mvc;

namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;


        public ArticlesApiController(LiaqatiDBContext context)
        {
            _context = context;

        }

        [HttpGet("AllArticles")]
        public async Task<ActionResult<List<Articles>>> GetAllArticles()
        {

            return Ok(await _context.TblArticles.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Articles>>> GetArticlesById(int id)
        {

            return Ok(await _context.TblArticles.FindAsync(id));
        }




        [HttpGet("LatesArticles")]
        public async Task<ActionResult<List<Articles>>> LatesArticles()
        {

            return Ok(await _context.TblArticles.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        [HttpPost]
        public async Task<ActionResult<Articles>> AddArticles([FromForm] Articles Articles)
        {



            await _context.TblArticles.AddAsync(Articles);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


            return Ok(Articles);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MealPlans>> DeleteArticles(int id)
        {
            Articles item = _context.TblArticles.Find(id);

            if (item == null)
            {
                return NotFound();
            }




            try
            {
                _context.TblArticles.Remove(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }

            return Ok();

        }

        [HttpDelete("{Delete}")]


        public async Task<ActionResult<List<Articles>>> DeleteMultiArticles([FromForm] int[] ids)
        {
            var plist = new List<Articles>();

            foreach (int id in ids)
            {
                var Articles = _context.TblArticles.Find(id);

                if (Articles == null)
                {
                    return NotFound();
                }
                else
                {
                    plist.Add(Articles);

                }

            }
            try
            {
                _context.TblArticles.RemoveRange(plist);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });

            }

            return Ok(plist);

        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Articles>> EditArticles(int id, Articles Articles)
        {
            if (_context.TblArticles.Find(id) == null)
            {
                return BadRequest();
            }


            //  _context.Product.Update(product);
            _context.Entry(Articles).State = EntityState.Modified;

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

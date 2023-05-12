using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationApiController : ControllerBase
    {

        readonly LiaqatiDBContext _context;
        private readonly IRepoConsultation _repoConsultation;

        public ConsultationApiController(LiaqatiDBContext context, IRepoConsultation repoConsultation)
        {
            _context = context;
            _repoConsultation = repoConsultation;
        }

        [HttpGet("AllConsultation")]
        public async Task<ActionResult<List<Consultation>>> GetAllConsultation()
        {

            return Ok(await _context.TblConsultation.ToArrayAsync());
        }

        [HttpGet("GetConsultationById/{id}")]

        public async Task<ActionResult<List<Consultation>>> GetConsultationById(string id)
        {

            return Ok(await _context.TblConsultation.FindAsync(id));
        }




        [HttpGet("LatesConsultation")]
        public async Task<ActionResult<List<Consultation>>> ConsultationExercise()
        {

            return Ok(await _context.TblConsultation.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        [HttpPost]
        public async Task<ActionResult<Consultation>> AddArticles([FromForm] Consultation Consultation)
        {



            await _context.TblConsultation.AddAsync(Consultation);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


            return Ok(Consultation);

        }

        [HttpDelete("DeleteConsultation/{id}")]
        public async Task<ActionResult<Consultation>> DeleteConsultation(string id)
        {
            Consultation item = _context.TblConsultation.Find(id);

            if (item == null)
            {
                return NotFound();
            }




            try
            {
                _context.TblConsultation.Remove(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });
            }

            return Ok();

        }

        [HttpDelete("{DeleteToList}")]
        public async Task<ActionResult<List<Consultation>>> DeleteMultiExercise([FromForm] string[] ids)
        {
            var plist = new List<Consultation>();

            foreach (string id in ids)
            {
                var Consultation = _context.TblConsultation.Find(id);

                if (Consultation == null)
                {
                    return NotFound();
                }
                else
                {
                    plist.Add(Consultation);

                }

            }
            try
            {
                _context.TblConsultation.RemoveRange(plist);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message });

            }

            return Ok(plist);

        }


        [HttpPut("EditConsultation/{id}")]
        public async Task<ActionResult<Consultation>> EditExercise(int id, Consultation Consultation)
        {
            if (_context.TblConsultation.Find(id) == null)
            {
                return BadRequest();
            }


            _context.Entry(Consultation).State = EntityState.Modified;

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
        [Route("searchforCons")]
        public async Task<ActionResult> Search([FromBody] ConsultationQueryParamters exqParameters)
        {
            return Ok(await _repoConsultation.Searchconsult(exqParameters));
        }

    }


}

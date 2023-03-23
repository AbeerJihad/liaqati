using liaqati_master.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ProgectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsProgramApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;


        public SportsProgramApiController(LiaqatiDBContext context)
        {
            _context = context;
           
        }

        [HttpGet("AllSportsProgram")]
        public async Task<ActionResult<List<SportsProgram>>> GetAllSportsProgram()
        {

            return Ok(await  _context.TblSportsProgram.ToArrayAsync());
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

        ///
        [HttpPost]
        public async Task<ActionResult<SportsProgram>> AddSportsProgram([FromForm] VmSportProgram VmSportsProgram)
        {

            SportsProgram SportsProgram = new SportsProgram()
            {
                Id = VmSportsProgram.Id,
                TrainingType = VmSportsProgram.TrainingType,
                Length = VmSportsProgram.Length,
                Equipment = VmSportsProgram.Equipment,
                BodyFocus = VmSportsProgram.BodyFocus,
                Difficulty = VmSportsProgram.Difficulty,
                services = new Service() { Id = VmSportsProgram.Id, Title = VmSportsProgram.Title, Price = VmSportsProgram.Price }


            };
            try
            {
                await _context.TblSportsProgram.AddAsync(SportsProgram);

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
            SportsProgram item = _context.TblSportsProgram.Find(id);

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










    }
}

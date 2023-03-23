using liaqati_master.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace liaqati_master.Controllers
{
   [Route("api/[controller]")]
   // [ApiController]
    public class ProgramExerciesController : ControllerBase
    {
        readonly LiaqatiDBContext _context;


        public ProgramExerciesController(LiaqatiDBContext context)
        {
            _context = context;

        }

        [HttpGet("AllProgramExercies")]
        public async Task<ActionResult<List<Exercies_program>>> GetAllProgramExercies()
        {

            return Ok(await _context.TblExercies_program.ToArrayAsync());
        }
        [HttpGet("AllProgramExercies/{id}")]
        public async  Task<ActionResult<List<Exercies_program>>> GetAllProgramExerciesByProgramId(string id)
        {

        IEnumerable<Exercies_program> list = _context.TblExercies_program.ToList().Where(p => p.sportsProgramId == id);

            return Ok(list);
        }





        [HttpPost("AddProgramExercies")]
        public async Task<ActionResult<Exercies_program>> AddProgramExercies([FromBody] VmProgamExercies VmExercies_program)
        {
            
            if(VmExercies_program ==null) { 

                return NotFound();
          

                }

            Exercies_program Exercies_program = new Exercies_program()
            {
                Id = VmExercies_program.Id,
                exerciseId = VmExercies_program.exerciseId,
                sportsProgramId = VmExercies_program.sportsProgramId,
                Day = VmExercies_program.Day,
                Week = VmExercies_program.Week

            };



            await _context.TblExercies_program.AddAsync(Exercies_program);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


            return Ok(Exercies_program);

        }







    }
}

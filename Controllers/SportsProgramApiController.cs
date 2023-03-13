﻿using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<List<AthleticProgram>>> GetAllSportsProgram()
        {

            return Ok(await _context.TblSportsProgram.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<AthleticProgram>>> GetSportsProgramById(int id)
        {

            return Ok(await _context.TblSportsProgram.FindAsync(id));
        }


        [HttpGet("LatesSportsProgram")]
        public async Task<ActionResult<List<AthleticProgram>>> LatesSportsProgram()
        {

            return Ok(await _context.TblSportsProgram.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        ///
        [HttpPost]
        public async Task<ActionResult<AthleticProgram>> AddSportsProgram([FromForm] AthleticProgram SportsProgram)
        {
            await _context.TblSportsProgram.AddAsync(SportsProgram);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


            return Ok(SportsProgram);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<AthleticProgram>> DeleteSportsProgram(int id)
        {
            AthleticProgram? item = _context.TblSportsProgram.Find(id);

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

        [HttpDelete("{Delete}")]


        public async Task<ActionResult<List<AthleticProgram>>> DeleteMultiSportsProgram([FromForm] int[] ids)
        {
            var plist = new List<AthleticProgram>();

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


        [HttpPut("{id}")]
        public async Task<ActionResult<AthleticProgram>> EditSportsProgram(int id, AthleticProgram SportsProgram)
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

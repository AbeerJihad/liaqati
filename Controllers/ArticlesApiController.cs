﻿using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<List<Article>>> GetAllArticles()
        {

            return Ok(await _context.TblArticles.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Article>>> GetArticlesById(int id)
        {

            return Ok(await _context.TblArticles.FindAsync(id));
        }




        [HttpGet("LatesArticles")]
        public async Task<ActionResult<List<Article>>> LatesArticles()
        {

            return Ok(await _context.TblArticles.OrderByDescending(x => x.Id).ToArrayAsync());
        }

        [HttpPost]
        public async Task<ActionResult<Article>> AddArticles([FromForm] Article Articles)
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
            Article item = _context.TblArticles.Find(id);

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


        public async Task<ActionResult<List<Article>>> DeleteMultiArticles([FromForm] int[] ids)
        {
            var plist = new List<Article>();

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
        public async Task<ActionResult<Article>> EditArticles(int id, Article Articles)
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

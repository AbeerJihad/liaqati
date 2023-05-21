﻿namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;
        readonly IRepoArticles _repository;
        private readonly IRepoFavorite _IRepoFavorite;



        public ArticlesApiController(LiaqatiDBContext context, IRepoArticles repository, IRepoFavorite iRepoFavorite)
        {
            _context = context;
            _repository = repository;
            _IRepoFavorite = iRepoFavorite;
        }

        [HttpGet("AllArticles")]
        public async Task<ActionResult<List<Article>>> GetAllArticles()
        {

            return Ok(await _context.TblArticles.ToArrayAsync());
        }

        [HttpGet("GetArticlesById/{id}")]
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

        [HttpDelete("DeleteArticles/{id}")]

        public async Task<ActionResult<MealPlans>> DeleteArticles(int id)
        {
            Article? item = _context.TblArticles.Find(id);

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

        [HttpDelete("DeleteToList")]
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


        [HttpPut("EditArticles/{id}")]

        public async Task<ActionResult<Article>> EditArticles(int id, Article Articles)
        {
            if (_context.TblArticles.Find(id) == null)
            {
                return BadRequest();
            }


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

        [HttpGet("GetArticlesWithLoadMore")]
        public async Task<ActionResult<List<Article>>> GetArticlesWithLoadMore(int page, int size = 4)
        {

            if (_context.TblArticles == null)
            {
                return NotFound();
            }

            return Ok((await _repository.GetAllAsync()).Skip((page - 1) * size).Take(size));
        }




        [HttpGet("AddFavoritesToArticles/{id}")]
        public async Task<ActionResult<string>> AddFavoritesToArticles(string id)
        {
            string IsAdd = "";
            List<Favorite> Favorites = new();

            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null && id is not null)
            {

                var lstOfFav = await _IRepoFavorite.GetByUserIDAsync(userid);

                if (lstOfFav is not null)
                {
                    Favorites = lstOfFav.Where(p => p.ArticleId == id).ToList();
                }
                if (!Favorites.Any())
                {
                    Favorite favorite = new()
                    {
                        ArticleId = id,
                        Type = "مقالات",
                        Id = CommonMethods.Id_Guid(),
                        UserId = userid
                    };
                    try
                    {
                        await _IRepoFavorite.AddEntityAsync(favorite);

                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                    IsAdd = "true";
                }
                else
                {
                    try
                    {
                        await _IRepoFavorite.DeleteByArticalIdAsync(id);
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }

                    IsAdd = "false";
                }
            }
            else
            {
                IsAdd = "null";
            }
            return Ok(IsAdd);
        }







    }
}

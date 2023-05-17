using liaqati_master.Models;
using liaqati_master.Services.Repositories;
using liaqati_master.ViewModels;
using System.Security.Claims;

namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritesApiController : ControllerBase
    {
        readonly IRepoFavorite _repoFavorite;

        public FavoritesApiController(IRepoFavorite repoFavorite)
        {
            _repoFavorite = repoFavorite;
         

        }

        [HttpGet("AddFavorites/{id}")]
        public async Task<ActionResult<string>> AddFavorites(string id)
        {

            string IsAdd="";
            List<Favorite> Favorites;


        var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null && id is not null)
            {
                Favorites = ((await _repoFavorite.GetByUserIDAsync(userid)).Where(p => p.ServicesId == id).ToList());

                if (!Favorites.Any())
                {

                    Favorite favorite = new Favorite()
                    {
                        ServicesId = id, Type ="منتجات",Id= CommonMethods.Id_Guid(),UserId= userid
                    };

                    await _repoFavorite.AddEntityAsync(favorite);
                    IsAdd = "true";


                }
                else
                {
                    await _repoFavorite.GetAllAsync();


                    await _repoFavorite.DeleteBySerIdAsync(id);
                    await _repoFavorite.DeleteByExerIdAsync(id);
                    await _repoFavorite.DeleteByHealIdAsync(id);
                    await _repoFavorite.DeleteByArticalIdAsync(id);

                   await  _repoFavorite.GetAllAsync();
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

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartApiController : Controller
    {


        readonly IRepoCart _repoCart;

        public CartApiController(IRepoCart repoCart)
        {
            _repoCart = repoCart;
        }

        public IActionResult Index()
        {
            return View();
        }




        [HttpGet("AddToCart/{id}")]
        public async Task<ActionResult<int>> AddToCart(string id)
        {
            return Ok(await _repoCart.AddToCart(id));
        }

        [HttpGet("CountCart")]
        public async Task<ActionResult<int>> CountCart()
        {
            int i = await _repoCart.GetCartItemCount();
            return Ok(i);
        }



        




    }
}

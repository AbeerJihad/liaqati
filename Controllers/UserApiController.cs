namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    //  [ApiController]
    public class UserApiController : ControllerBase
    {
        readonly LiaqatiDBContext _context;
        private readonly IRepoUser _repoUser;
        private readonly UserManager<User> _userManager;

        public UserApiController(LiaqatiDBContext context, IRepoUser repoUser, UserManager<User> userManager)
        {
            _context = context;
            _repoUser = repoUser;
            _userManager = userManager;
        }

        [HttpGet("AllExperts")]
        public async Task<IEnumerable<User>> GetAllTrainerAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return (IEnumerable<User>)await _userManager.GetUsersInRoleAsync("Trainer");
        }







        [HttpPost]
        [Route("searchforExperts")]
        public async Task<ActionResult> SearchForExperts([FromBody] UserQueryParamters exqParameters)
        {
            return Ok(await _repoUser.SearchUser(exqParameters));
        }
    }
}

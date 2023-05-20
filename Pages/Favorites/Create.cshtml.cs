namespace liaqati_master.Areas.Admin.Pages.Favorites
{


    public class CreateModel : PageModel
    {
        readonly IRepoFavorite _repoFavorite;

        public CreateModel(IRepoFavorite repoFavorite)
        {
            _repoFavorite = repoFavorite;

        }

        [BindProperty(SupportsGet = true)]
        public Favorite favorite { get; set; }



        [BindProperty(SupportsGet = true)]
        public string returnUrl { get; set; }

        public void OnGet()
        {
        }


        public async Task<IActionResult> OnPost()
        {
            //if(ModelState.IsValid)
            //{
            //    return NotFound();
            //}



            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);


            if (userid is null)
            {
                RedirectToPage("./identity/account/login"); ;
            }



            favorite.Id = CommonMethods.Id_Guid();
            favorite.UserId = userid;



            await _repoFavorite.AddEntityAsync(favorite);

            returnUrl ??= Url.Content("~/");





            return LocalRedirect(returnUrl);
        }



    }
}

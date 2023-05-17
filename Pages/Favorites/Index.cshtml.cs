using System.Security.Claims;

namespace liaqati_master.Pages.Favorites
{
    public class IndexModel : PageModel
    {

        readonly IRepoFavorite _repoFavorite;
        readonly IRepoService _repoService;
        readonly IRepoProducts _repoProduct;
        readonly IRepoHealthyRecipe _repoHealthyRecipe;
        readonly IRepoExercise _repoExercise;
        readonly IRepoArticles _repoArticles;



        public IndexModel(IRepoFavorite repoFavorite, IRepoService repoService, IRepoProducts repoProduct,
            IRepoHealthyRecipe repoHealthyRecipe, IRepoExercise repoExercise, IRepoArticles repoArticles

            )
        {
            _repoFavorite = repoFavorite;
            _repoService = repoService;
            _repoProduct = repoProduct;
            _repoExercise = repoExercise;
            _repoHealthyRecipe = repoHealthyRecipe;
            _repoArticles = repoArticles;
        }

        [BindProperty(SupportsGet = true)]
        public List<VmFavorite> Services { get; set; }



        [BindProperty(SupportsGet = true)]
        public List<ProductVM> Products { get; set; }



        [BindProperty(SupportsGet = true)]
        public string returnUrl { get; set; }



        public QueryPageResult<VmFavorite> QueryPageResult { get; set; }

        [BindProperty(SupportsGet = true)]
        public FavoritesQueryParamters Parameters { get; set; }

        public async Task<IActionResult> OnGet(string ids)
        {
            //if (ids == null)
            //{
            //    return RedirectToPage("/Errors/404");
            //}




            // id = "98127abb-de9d-40db-82a3-809f85a6866d";
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);


            if (id is null)
            {
                RedirectToPage("./identity/account/login"); ;
            }
            Products = ((await _repoProduct.GetAllAsync()).Select(p =>
            new ProductVM()
            {
                CategoryName = p.Services?.Category?.Name,
                Id = p.Id,
                Images = p.Services?.Files?.Select(p => p.Path)?.ToList(),
                CategoryId = p.Services?.CategoryId,
                Discount = p.Discount,
                PercentageRate = p.Services?.RatePercentage,
                Price = p.Services?.Price,
                Title = p.Services?.Title

            }).Take(4)).ToList();

            List<Favorite>? list = await _repoFavorite.GetByUserIDAsync(id);


            if (list is not null)
            {

                foreach (Favorite item in list)
                {

                    Service? servies = await _repoService.GetByIDAsync(item.ServicesId);

                    if (servies is not null)
                    {
                        Services.Add(new VmFavorite() { Id = servies.Id, Price = servies.Price, imgUrl = "", Title = servies.Title });
                    }


                    HealthyRecipe? HealthyRecipe = await _repoHealthyRecipe.GetByIDAsync(item.HealthyRecipeId);

                    if (HealthyRecipe is not null)
                    {
                        Services.Add(new VmFavorite() { Id = HealthyRecipe.Id, Title = HealthyRecipe.Title, imgUrl = HealthyRecipe.Image, Price = HealthyRecipe.Price });
                    }

                    Exercise? Exercise = await _repoExercise.GetByIDAsync(item.ExerciseId);

                    if (Exercise is not null)
                    {
                        Services.Add(new VmFavorite() { Id = Exercise.Id, Title = Exercise.Title, imgUrl = Exercise.Image, Price = Exercise.Price });
                    }


                    Article? Article = await _repoArticles.GetByIDAsync(item.ArticleId);

                    if (Article is not null)
                    {
                        Services.Add(new VmFavorite() { Id = Article.Id, Title = Article.Title, imgUrl = Article.Image, Price = 0 });
                    }




                    if (!string.IsNullOrEmpty(Parameters.SearchTearm))
                    {
                        Services = Services.Where(p => p.Title != null && p.Title.ToLower().Contains(Parameters.SearchTearm.ToLower()) || p.Title!.ToLower().Contains(Parameters.SearchTearm.ToLower())).ToList();

                    }

                    QueryPageResult = CommonMethods.GetPageResult(Services.AsQueryable(), Parameters);



                }




            }

            return Page();
        }




        public async Task<IActionResult> OnPostRemoveFavorite(string id)
        {
            if (id is null)
            {
                return NotFound();
            }

            await _repoFavorite.DeleteBySerIdAsync(id);
            await _repoFavorite.DeleteByExerIdAsync(id);
            await _repoFavorite.DeleteByHealIdAsync(id);
            await _repoFavorite.DeleteByArticalIdAsync(id);




            returnUrl ??= Url.Content("~/");


            return LocalRedirect(returnUrl);
        }



    }
}

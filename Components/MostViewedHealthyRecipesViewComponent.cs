namespace liaqati_master.Components
{
    public class MostViewedHealthyRecipesViewComponent : ViewComponent
    {
        private readonly IRepoHealthyRecipe _repoHealthyRecipe;
        private readonly SignInManager<User> _signInManager;
        readonly IRepoFavorite _IRepoFavorite;


        public MostViewedHealthyRecipesViewComponent(IRepoHealthyRecipe repoHealthyRecipe, SignInManager<User> signInManager, IRepoFavorite iRepoFavorite)
        {

            _repoHealthyRecipe = repoHealthyRecipe;
            _signInManager = signInManager;
            _IRepoFavorite = iRepoFavorite;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userid = ((ClaimsPrincipal)User).FindFirstValue(ClaimTypes.NameIdentifier);
            List<HealthyRecipe>? ListOfHealthyRecipe = (await _repoHealthyRecipe.GetAllAsync()).OrderByDescending(h => h.ViewsNumber).Take(4).ToList();

            List<VmHealthyRecipe>? list = new();

            foreach (HealthyRecipe p in ListOfHealthyRecipe)
            {
                VmHealthyRecipe healthy = new VmHealthyRecipe();
                if (_signInManager.IsSignedIn((ClaimsPrincipal)User))
                {

                    List<Favorite>? favorites = await _IRepoFavorite.GetByUserIDAsync(userid);
                    if (favorites is not null && favorites.Count > 0)
                    {


                        Favorite? favorite = favorites.Where(p => p.HealthyRecipeId != null && p.HealthyRecipeId == p.Id).FirstOrDefault();
                        if (favorite is null)
                        {

                            healthy.IsFavorite = 1;
                        }
                        else
                        {
                            healthy.IsFavorite = 2;
                        }
                    }

                }


                else if (!_signInManager.IsSignedIn((ClaimsPrincipal)User))
                {
                    healthy.IsFavorite = 0;
                }



                healthy.Id = p.Id;
                healthy.Image = p.Image ?? "";
                healthy.Price = p.Price;
                healthy.Title = p.Title;
                healthy.Description = p.Description;
                healthy.Calories = p.Calories;
                healthy.PrepTime = p.PrepTime;
                healthy.RatePercentage = p.RatePercentage;
                healthy.ShortDescription = p.ShortDescription;
                healthy.MealType = p.MealType ?? "";
                healthy.DietaryType = p.DietaryType ?? "";
                healthy.Rate = p.Rate;
                healthy.CreatedDate = p.CreatedDate;





                list.Add(healthy);














            }





            return View(list);
        }

    }
}

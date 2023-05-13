using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;

namespace liaqati_master.Pages.Home
{
    public class Index2Model : PageModel
    {
        readonly IRepoArticles _repoArticles;
        readonly IRepoUser _repoUser;
        readonly IRepoMealPlans _repoMealPlans;
        readonly IRepoProducts _repoProducts;
        readonly IRepoHealthyRecipe _repoHealthyRecipe;
        readonly IRepoProgram _repoProgram;
        private readonly UserManager<User> _userManager;
        public Index2Model(
                        IRepoArticles repoArticles , IRepoUser repoUser ,
                        IRepoMealPlans repoMealPlans, IRepoProducts repoProducts,
                        IRepoHealthyRecipe repoHealthyRecipe , IRepoProgram repoProgram ,
                         UserManager<User> userManager
                         )
        {
            _repoArticles= repoArticles;
            _repoUser= repoUser;
            _repoMealPlans = repoMealPlans;
            _repoProducts = repoProducts;
            _repoHealthyRecipe = repoHealthyRecipe;
            _repoProgram =repoProgram;
            _userManager= userManager;


        }


        public List<Article> articles { get; set; }


        public List<User> Users { get; set; }
        public List<User> Customers { get; set; }

        public List<MealPlans> MealPlans { get; set; }

        public List<Product> products { get; set; }

        public List<HealthyRecipe> HealthyRecipes { get; set; }

        public List<SportsProgram> Programs { get; set; }





        public async Task<IActionResult> OnGet()
        {


           articles =  ((await _repoArticles.GetAllAsync()).Skip(0).Take(3)).ToList();





            Users = ((await _userManager.GetUsersInRoleAsync("Trainer")).Skip(0).Take(3)).ToList();      /*.Except(await _userManager.GetUsersInRoleAsync("Admin"))*/
            Customers = ((await _userManager.GetUsersInRoleAsync("Customer")).Skip(0).Take(3)).ToList();      /*.Except(await _userManager.GetUsersInRoleAsync("Admin"))*/



            //products =(List<Product>) await _repoProducts.GetAllAsync();

            // HealthyRecipes = (List<HealthyRecipe>) await _repoHealthyRecipe.GetAllAsync();
            // MealPlans =(List<MealPlans>) await _repoMealPlans.GetAllAsync();
            // Programs = (List<SportsProgram>) await _repoProgram.GetAllProgram();






            return Page();




        }
    }
}

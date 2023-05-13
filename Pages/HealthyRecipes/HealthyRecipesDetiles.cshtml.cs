using liaqati_master.Services;
using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.HealthyRecipes
{
    public class HealthyRecipesDetilesModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IRepoHealthyRecipe _repoHealthy;
        private readonly IRepoFiles _repoFiles;


        public HealthyRecipe helth = new HealthyRecipe();

        public HealthyRecipesDetilesModel(UnitOfWork unitOfWork, IRepoHealthyRecipe repoHealthy, IRepoFiles repoFiles)
        {
            _unitOfWork = unitOfWork;
            _repoHealthy = repoHealthy;
            _repoFiles = repoFiles;
        }

        public string Message { get; set; }
        public List<Files>? file { get; set; }

        public string[] Ingredent { get; set; }
        public string[] PreparationMethod { get; set; }

        public async Task OnGetAsync(string? id)
        {
            id = "61";
            if (id != null)
            {
                helth = await _repoHealthy.GetByIDAsync(id);

                Ingredent = helth.Ingredients.Split('\n');
                PreparationMethod = helth.PreparationMethod.Split(',');





             //   string [] Ingredent = helth..Split(',');


               file = (await _repoFiles.GetByHealthyRecipesIDAsync(id));
              
                if (helth == null)
                {
                    Message = "NotFound";
                }
              

            }


        }

    }
}

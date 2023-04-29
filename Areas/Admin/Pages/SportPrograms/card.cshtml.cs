namespace liaqati_master.Pages.Programs
{
    public class CardModel : PageModel
    {
        private readonly IRepoProgram _repoProgram;

        public CardModel(IRepoProgram repoProgram)
        {
            _repoProgram = repoProgram;
        }

        public IList<SportsProgram> Programs { get; set; }
        public async Task OnGetAsync()
        {
            if (_repoProgram != null)
            {

                Programs = await _repoProgram.GetAllProgram();
            }
        }


        //public async Task<IActionResult> OnPostAsync(string id)
        //{
        //    return Page();
        //}





    }
}

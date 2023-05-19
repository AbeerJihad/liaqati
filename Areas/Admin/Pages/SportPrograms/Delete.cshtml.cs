#nullable disable
namespace liaqati_master.Areas.Admin.Pages.Programs
{
    public class DeleteProgramModel : PageModel
    {
        private readonly LiaqatiDBContext _context;
        private readonly IRepoProgram _IRepoProgram;

        public DeleteProgramModel(LiaqatiDBContext context, IRepoProgram iRepoProgram)
        {
            _context = context;
            _IRepoProgram = iRepoProgram;
        }

        [BindProperty]
        public SportsProgram SportsProgram { get; set; }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var program = await _IRepoProgram.GetProgram(id);

            if (program == null)
            {
                return NotFound();
            }
            else
            {
                SportsProgram = program;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var program = await _IRepoProgram.GetProgram(id);
            if (program != null)
            {
                SportsProgram = program;
                await _IRepoProgram.DeleteProgram(id);
            }
            return RedirectToPage("./Index");
        }
    }
}

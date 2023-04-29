namespace liaqati_master.Services.Repositories
{
    public interface IRepoProgram
    {
        public Task<bool> AddProgram(SportsProgram SportsProgram);
        public Task<bool> UpdateProgram(SportsProgram SportsProgram);
        public Task<bool> DeleteProgram(string? id);
        public Task<SportsProgram> GetProgram(string? id);
        public Task<List<SportsProgram>> GetAllProgram();
        //  public Task<QueryPageResult<SportsProgram>> SearchSportsProgram(ProgramQueryParamters exqParameters);
    }



    public class ProgramMang : IRepoProgram
    {
        private readonly LiaqatiDBContext _context;

        public ProgramMang(LiaqatiDBContext context)
        {
            _context = context;
        }
        public async Task<bool> AddProgram(SportsProgram SportsProgram)
        {
            await _context.TblSportsProgram.AddAsync(SportsProgram);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteProgram(string? id)
        {
            List<SportsProgram> SportsProgram = _context.TblSportsProgram.Include(x => x.Services).Include(p => p.Exercies_Programs).ToList();
            SportsProgram? sport = SportsProgram.FirstOrDefault(p => p.Equals(id));
            if (sport == null) { return false; }
            _context.TblSportsProgram.Remove(sport);
            await _context.SaveChangesAsync();

            return true;
        }



        public async Task<List<SportsProgram>> GetAllProgram()
        {
            List<SportsProgram> SportsProgram = _context.TblSportsProgram.Include(x => x.Services).Include(p => p.Exercies_Programs).ToList();

            return SportsProgram;
        }
        public async Task<SportsProgram> GetProgram(string? id)
        {
            List<SportsProgram> SportsProgram = _context.TblSportsProgram.Include(x => x.Services).Include(p => p.Exercies_Programs).ToList();

            SportsProgram? sport = SportsProgram.FirstOrDefault(p => p.Id.Equals(id));

            await _context.SaveChangesAsync();

            return sport;
        }

        public async Task<bool> UpdateProgram(SportsProgram SportsProgram)
        {
            _context.TblSportsProgram.Update(SportsProgram);
            await _context.SaveChangesAsync();
            return true;
        }


        //public async Task<QueryPageResult<SportsProgram>> SearchSportsProgram(ProgramQueryParamters exqParameters)
        //{
        //    IQueryable<SportsProgram> SportsProgram = (await GetAllProgram()).AsQueryable();



        //    if (!string.IsNullOrEmpty(exqParameters.Name))
        //    {
        //        SportsProgram = SportsProgram.Where(p =>
        //            p.Services.Title.ToLower().Contains(exqParameters.Name.ToLower()) ||
        //            p.Services.Title.ToLower().Contains(exqParameters.Name.ToLower())
        //        );
        //    }

        //    if (!string.IsNullOrEmpty(exqParameters.Specialization))
        //    {
        //        SportsProgram = SportsProgram.Where(p =>
        //            p.Services.Title!.ToLower().Trim() == exqParameters.Specialization.ToLower().Trim()
        //        );
        //    }






        //    //if (!string.IsNullOrEmpty(exqParameters.SortBy))
        //    //{
        //    //    if (exqParameters.SortBy.Equals("Fname", StringComparison.OrdinalIgnoreCase))
        //    //    {
        //    //        // if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
        //    //        Trainer = Trainer.OrderByDescending(p => p.Fname);
        //    //        //else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
        //    //        //    Trainer = Trainer.OrderByDescending(p => p.RateId);

        //    //    }
        //    //    if (exqParameters.SortBy.Equals("Exp_Years", StringComparison.OrdinalIgnoreCase))
        //    //    {
        //    //        // if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
        //    //        Trainer = Trainer.OrderByDescending(p => p.Exp_Years);
        //    //        //else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
        //    //        //    Trainer = Trainer.OrderByDescending(p => p.RateId);

        //    //    }
        //    //}



        //    QueryPageResult<SportsProgram> qpres = CommonMethods.GetPageResult(SportsProgram, exqParameters);


        //    return qpres;
        //}








    }


}

namespace liaqati_master.Services.RepoCrud
{
    public interface IRepoProgram
    {
        public Task<bool> AddProgram(SportsProgram SportsProgram);
        public Task<bool> UpdateProgram(SportsProgram SportsProgram);
        public Task<bool> DeleteProgram(string? id);
        public Task<SportsProgram> GetProgram(string? id);
        public Task<List<SportsProgram>> GetAllProgram();

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
    }


}

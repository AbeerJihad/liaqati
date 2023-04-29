namespace liaqati_master.Services.Repositories
{
    public interface IRepoProgramExercies
    {

        public Task<List<Exercies_program>> GetAllExercies_program();


        public List<Exercies_program> GetMultiExercies_program(string id, int week, int day);


        public Task<bool> AddExercies_program(Exercies_program Exercies_program);
        public Task<bool> UpdateExercies_program(Exercies_program Exercies_program);
        public Task<bool> DeleteExercies_program(string? id);
        public Task<Exercies_program> GetExercies_program(string? id);





    }



    public class ProgramExerciesMang : IRepoProgramExercies
    {
        public readonly LiaqatiDBContext _context;

        public ProgramExerciesMang(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<bool> AddExercies_program(Exercies_program Exercies_program)
        {
            await _context.TblExercies_program.AddAsync(Exercies_program);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<bool> DeleteExercies_program(string? id)
        {
            List<Exercies_program> Exercies_program = _context.TblExercies_program.ToList();
            Exercies_program? sport = Exercies_program.FirstOrDefault(p => p.Equals(id));
            if (sport == null) { return false; }
            _context.TblExercies_program.Remove(sport);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<Exercies_program>> GetAllExercies_program()
        {
            List<Exercies_program> list = _context.TblExercies_program.Include(x => x.Exercise).Include(p => p.SportsProgram).ToList();

            return list;
        }

        public async Task<Exercies_program> GetExercies_program(string? id)
        {
            List<Exercies_program> Exercies_program = _context.TblExercies_program.ToList();

            Exercies_program? sport = Exercies_program.FirstOrDefault(p => p.Id.Equals(id));

            await _context.SaveChangesAsync();

            return sport;
        }

        public List<Exercies_program> GetMultiExercies_program(string id, int week, int day)
        {

            List<Exercies_program> list = _context.TblExercies_program.ToList();
            List<Exercies_program> list2 = new List<Exercies_program>();


            foreach (Exercies_program program in list)
            {

                if (program.SportsProgramId == id && program.Day == day && program.Week == week)
                {
                    list2.Add(program);
                }

            }




            return list2;
        }

        public async Task<bool> UpdateExercies_program(Exercies_program Exercies_program)
        {
            _context.TblExercies_program.Update(Exercies_program);
            await _context.SaveChangesAsync();
            return true;
        }
    }


}

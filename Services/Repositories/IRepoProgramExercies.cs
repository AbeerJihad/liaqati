namespace liaqati_master.Services.Repositories
{
    public interface IRepoProgramExercies
    {

        public Task<List<Exercies_program>> GetAllExercies_program();


        public List<Exercies_program> GetMultiExercies_program(string id, int week, int day);


    }



    public class ProgramExerciesMang : IRepoProgramExercies
    {
        public readonly LiaqatiDBContext _context;

        public ProgramExerciesMang(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<List<Exercies_program>> GetAllExercies_program()
        {
            List<Exercies_program> list = _context.TblExercies_program.Include(x => x.Exercise).Include(p => p.SportsProgram).ToList();

            return list;
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
    }


}

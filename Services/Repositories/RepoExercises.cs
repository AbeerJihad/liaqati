namespace liaqati_master.Services.Repositories
{
    public interface RepoExercises
    {

        public Task<Exercise> GetExercises(string? id);


    }



    public class ExercisesMang : RepoExercises
    {
        public readonly LiaqatiDBContext _context;

        public ExercisesMang(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Exercise> GetExercises(string? id)
        {
            Exercise Exercise = _context.TblExercises.ToList().Where(p => p.Id.Equals(id)).ToList()[0];


            await _context.SaveChangesAsync();


            return Exercise;
        }







    }


}

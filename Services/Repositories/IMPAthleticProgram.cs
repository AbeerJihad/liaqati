using liaqati_master.Data;
using liaqati_master.Models;

namespace liaqati_master.Services.Repositories
{
    public class IMPAthleticProgram : IRepository<SportsProgram>
    {
        private readonly LiaqatiDBContext _context;
        public IMPAthleticProgram(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<SportsProgram> AddEntity(SportsProgram Entity)
        {
            await _context.TblSportsProgram.AddAsync(Entity);
            try
            {

                await _context.SaveChangesAsync();

                return Entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<SportsProgram> DeleteEntity(SportsProgram Entity)
        {
            _context.TblSportsProgram.Remove(Entity);
            try
            {

                await _context.SaveChangesAsync();

                return Entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<SportsProgram> DeleteEntity(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SportsProgram> GetAll()
        {
            throw new NotImplementedException();
        }

        public SportsProgram GetStudentByID(int EntityId)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public Task<SportsProgram> UpdateEntity(SportsProgram Entity)
        {
            throw new NotImplementedException();
        }
    }
}

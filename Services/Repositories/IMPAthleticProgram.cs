using liaqati_master.Data;
using liaqati_master.Models;

namespace liaqati_master.Services.Repositories
{
    public class IMPAthleticProgram : IRepository<AthleticProgram>
    {
        private readonly LiaqatiDBContext _context;
        public IMPAthleticProgram(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<AthleticProgram> AddEntity(AthleticProgram Entity)
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

        public async Task<AthleticProgram> DeleteEntity(AthleticProgram Entity)
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

        public Task<AthleticProgram> DeleteEntity(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AthleticProgram> GetAll()
        {
            throw new NotImplementedException();
        }

        public AthleticProgram GetStudentByID(int EntityId)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public Task<AthleticProgram> UpdateEntity(AthleticProgram Entity)
        {
            throw new NotImplementedException();
        }
    }
}

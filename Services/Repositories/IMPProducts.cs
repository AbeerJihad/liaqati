using liaqati_master.Model;

namespace liaqati_master.Services.Repositories
{
    public class IMPProducts : IRepository<Products>
    {
        private readonly LiaqatiDBContext _context;
        public IMPProducts(LiaqatiDBContext context)
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

        public Task<Products> AddEntity(Products Entity)
        {
            throw new NotImplementedException();
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

        public Task<ProductQueryParamters> ProductQueryParamters { get; set; }
        public Task<SportsProgram> DeleteEntity(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Products> DeleteEntity(Products Entity)
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

        public Task<Products> UpdateEntity(Products Entity)
        {
            throw new NotImplementedException();
        }

        Task<Products> IRepository<Products>.DeleteEntity(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Products> IRepository<Products>.GetAll()
        {
            throw new NotImplementedException();
        }

        Products IRepository<Products>.GetStudentByID(int EntityId)
        {
            throw new NotImplementedException();
        }
    }
}

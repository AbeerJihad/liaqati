using liaqati_master.ViewModels;
using Microsoft.Office.Interop.Excel;

namespace liaqati_master.Services.Repositories
{
    public class IMPProducts : IRepository<Product>
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


        public Task<Product> AddEntity(Product Entity)
        {
            throw new NotImplementedException();
        }
        public async Task ReadFromExcel()
        {

            Application application = new();


            Workbook wb = new();
            Worksheet worksheet = new();


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

        public Task<Product> DeleteEntity(Product Entity)
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

        public Task<Product> UpdateEntity(Product Entity)
        {
            throw new NotImplementedException();
        }

        Task<Product> IRepository<Product>.DeleteEntity(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IRepository<Product>.GetAll()
        {
            throw new NotImplementedException();
        }

        Product IRepository<Product>.GetStudentByID(int EntityId)
        {
            throw new NotImplementedException();
        }
    }
}

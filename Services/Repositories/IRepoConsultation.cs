namespace liaqati_master.Services.Repositories
{
    public class IRepoConsultation
    {
        private readonly LiaqatiDBContext _context;

        public IRepoConsultation(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Consultation> AddEntityAsync(Consultation Entity)
        {
            await _context.TblConsultation.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Consultation> DeleteEntityAsync(Consultation Entity)
        {
            if (Entity != null)
            {
                _context.TblConsultation.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Consultation();
            }
        }

        public async Task<Consultation> DeleteEntityAsync(string Id)
        {
            var cons = await _context.TblConsultation.FindAsync(Id);
            if (cons != null)
            {
                _context.TblConsultation.Remove(cons);
                await SaveAsync();
                return cons;
            }
            else
            {
                return new Consultation();
            }
        }

        public async Task<IEnumerable<Consultation>> GetAllAsync()
        {
            return await _context.TblConsultation.ToListAsync();
        }

        public async Task<Consultation?> GetByIDAsync(string EntityId)
        {
            return await _context.TblConsultation.FirstOrDefaultAsync(a => a.Id == EntityId);
        }
        public async Task<Replyconsultation?> GetReplyAsync(string Id)
        {
            return await _context.TblReplyconsultation.FirstOrDefaultAsync(a => a.consId == Id);
        }
        public async Task<List<Replyconsultation>> GetAllReplyAsync(string Id)
        {
            return await _context.TblReplyconsultation.Where(r => r.consId == Id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public async Task<Consultation> UpdateEntityAsync(Consultation Entity)
        {
            Consultation? consulat = await _context.TblConsultation.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (consulat != null)
            {
                _context.TblConsultation.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Consultation();
            }
        }

        public async Task<QueryPageResult<Consultation>> Searchconsult(ConsultationQueryParamters Parameters)
        {
            IQueryable<Consultation> con = (await GetAllAsync()).AsQueryable();

            if (Parameters.CategoryId != null)
            {
                con = con.Where(p => p.CategoryId == Parameters.CategoryId);
            }

            if (!string.IsNullOrEmpty(Parameters.SearchTearm))
            {
                con = con.Where(p => p.Title != null &&
                    p.Title.ToLower().Contains(Parameters.SearchTearm.ToLower())
                 );
            }

            if (!string.IsNullOrEmpty(Parameters.Tilte))
            {
                con = con.Where(p => p.Title != null && p.Title.ToLower() == Parameters.Tilte.ToLower());
            }


            if (!string.IsNullOrEmpty(Parameters.SortBy))
            {

                if (Parameters.SortBy.Equals("newst", StringComparison.OrdinalIgnoreCase))
                {
                    con = con.OrderBy(p => p.CreatedDate);

                }
                else if (Parameters.SortBy.Equals("oldest", StringComparison.OrdinalIgnoreCase))
                {
                    con = con.OrderByDescending(p => p.CreatedDate);

                }
            }

            QueryPageResult<Consultation> queryPageResult = CommonMethods.GetPageResult(con, Parameters);

            return queryPageResult;

        }


    }
}

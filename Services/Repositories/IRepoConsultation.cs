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
                var healthyRecipe = await _context.TblConsultation.FindAsync(Id);
                if (healthyRecipe != null)
                {
                    _context.TblConsultation.Remove(healthyRecipe);
                    await SaveAsync();
                    return healthyRecipe;
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

        public async Task SaveAsync()
            {
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public async Task<Consultation> UpdateEntityAsync(Consultation Entity)
            {
                Consultation? healthyRecipe = await _context.TblConsultation.FirstOrDefaultAsync(a => a.Id == Entity.Id);
                if (healthyRecipe != null)
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

        public async Task<QueryPageResult<Consultation>> SearchProduct(ConsultationQueryParamters Parameters)
        {
            IQueryable<Consultation> products = (await GetAllAsync()).AsQueryable();

            if (Parameters.CategoryId != null)
            {
                products = products.Where(p => p.CategoryId == Parameters.CategoryId);
            }

            if (!string.IsNullOrEmpty(Parameters.SearchTearm))
            {
                products = products.Where(p =>
                    p.Title.ToLower().Contains(Parameters.SearchTearm.ToLower())
                 );
            }

            if (!string.IsNullOrEmpty(Parameters.Tilte))
            {
                products = products.Where(p => p.Title.ToLower() == Parameters.Tilte.ToLower());
            }


            QueryPageResult<Consultation> queryPageResult = CommonMethods.GetPageResult(products, Parameters);

            return queryPageResult;

        }


    }
    }

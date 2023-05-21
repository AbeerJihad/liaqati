namespace liaqati_master.Services.Repositories
{
    public class IRepoOrder_Details
    {
        private readonly LiaqatiDBContext _context;

        public IRepoOrder_Details(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Order_Details> AddEntityAsync(Order_Details Entity)
        {
            await _context.TblOrder_Details.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Order_Details> DeleteEntityAsync(Order_Details Entity)
        {
            if (Entity != null)
            {
                _context.TblOrder_Details.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Order_Details();
            }
        }

        public async Task<Order_Details> DeleteEntityAsync(string Id)
        {
            var order_Details = await _context.TblOrder_Details.FindAsync(Id);
            if (order_Details != null)
            {
                _context.TblOrder_Details.Remove(order_Details);
                await SaveAsync();
                return order_Details;
            }
            else
            {
                return new Order_Details();
            }
        }

        public async Task<IEnumerable<Order_Details>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblOrder_Details.ToListAsync();
        }

        public async Task<Order_Details?> GetByIDAsync(string EntityId)
        {
            return await _context.TblOrder_Details.FirstOrDefaultAsync(a => a.Id == EntityId);
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

        public async Task<Order_Details> UpdateEntityAsync(Order_Details Entity)
        {
            Order_Details? order_Details = await _context.TblOrder_Details.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (order_Details != null)
            {
                _context.TblOrder_Details.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Order_Details();
            }
        }
        public async Task<QueryPageResult<Order_Details>> SearchOrder(OrdersDetailsQueryParamters Parameters)
        {
            IQueryable<Order_Details> orders = (await GetAllAsync()).AsQueryable();

            if (Parameters.UserId != null)
            {
                Parameters.CurPage = 1;

                orders = orders.Where(o => o.Service != null && o.Service.UserId == Parameters.UserId);
            }
            if (Parameters.FromDateOrder != null && Parameters.ToDateOrder != null)
            {
                Parameters.CurPage = 1;

                orders = orders.Where(x => x.Order != null && x.Order.OrderDate >= Parameters.FromDateOrder && x.Order.OrderDate <= Parameters.ToDateOrder);
            }
            else if (Parameters.FromDateOrder != null)
            {
                Parameters.CurPage = 1;

                orders = orders.Where(x => x.Order != null && x.Order.OrderDate >= Parameters.FromDateOrder);
            }
            else if (Parameters.ToDateOrder != null)
            {
                Parameters.CurPage = 1;

                orders = orders.Where(x => x.Order != null && x.Order.OrderDate <= Parameters.ToDateOrder);
            }


            QueryPageResult<Order_Details> queryPageResult = CommonMethods.GetPageResult(orders, Parameters);
            return queryPageResult;

        }
    }
}

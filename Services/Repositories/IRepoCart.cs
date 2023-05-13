namespace liaqati_master.Services.Repositories
{
    public class IRepoCart : IDisposable
    {

        private readonly LiaqatiDBContext _db;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public IRepoCart(LiaqatiDBContext db, UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<int> AddToCart(string id)
        {
            string UserId = GetUserId();
            if (string.IsNullOrEmpty(UserId))
                throw new Exception("user is not logged-in");
            var cartItem = _db.TblCartItem.SingleOrDefault(c => c.UserId == UserId && c.ServiceId == id);
            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    Id = Guid.NewGuid().ToString(),
                    ServiceId = id,
                    UserId = UserId,
                    Service = _db.TblServices.SingleOrDefault(p => p.Id == id),
                    Quantity = 1,
                    DateCreated = DateTime.Now
                };
                _db.TblCartItem.Add(cartItem);
            }
            else
            {
                cartItem.Quantity++;
            }
            _db.SaveChanges();

            var cartItemCount = await GetCartItemCount(UserId);
            return cartItemCount;
        }
        public async Task<int> RemoveItem(string ServiceId)
        {
            string userId = GetUserId();
            try
            {
                if (string.IsNullOrEmpty(userId))
                    throw new Exception("user is not logged-in");
                var cartItem = _db.TblCartItem
                                  .FirstOrDefault(a => a.UserId == userId && a.ServiceId == ServiceId);
                if (cartItem is null)
                    throw new Exception("Not items in cart");
                else if (cartItem.Quantity == 1)
                    _db.TblCartItem.Remove(cartItem);
                else
                    cartItem.Quantity--;
                _db.SaveChanges();
            }
            catch (Exception)
            {

            }
            var cartItemCount = await GetCartItemCount(userId);
            return cartItemCount;
        }
        public async Task<int> RemoveItemFromCart(string ServiceId)
        {
            string userId = GetUserId();
            try
            {
                if (string.IsNullOrEmpty(userId))
                    throw new Exception("user is not logged-in");
                var cartItem = _db.TblCartItem
                                  .FirstOrDefault(a => a.UserId == userId && a.ServiceId == ServiceId);
                if (cartItem is null)
                    throw new Exception("Not items in cart");
                else
                    _db.TblCartItem.Remove(cartItem);

                _db.SaveChanges();
            }
            catch (Exception)
            {

            }
            var cartItemCount = await GetCartItemCount(userId);
            return cartItemCount;
        }

        public async Task<int> GetCartItemCount(string userId = "")
        {
            if (!string.IsNullOrEmpty(userId))
            {
                userId = GetUserId();
            }
            return await _db.TblCartItem.Where(c => c.UserId == userId).CountAsync();
            ;
        }
        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
            }
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            string UserId = GetUserId();
            if (string.IsNullOrEmpty(UserId))
                throw new Exception("user is not logged-in");
            return await _db.TblCartItem.Where(c => c.UserId == UserId).ToListAsync();
        }
        private string GetUserId()
        {
            var principal = _httpContextAccessor.HttpContext?.User;
            string userId = _userManager.GetUserId(principal);
            return userId;
        }
    }

}

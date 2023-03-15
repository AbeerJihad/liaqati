namespace liaqati_master.Services
{
    public class UnitOfWork : IDisposable
    {
        public readonly LiaqatiDBContext context;

        private GenericRepository<User> userRepository;
        private GenericRepository<Order> orderRepository;
        private GenericRepository<Achievements> achievementsRepository;
        private GenericRepository<ContactUs> contactUsRepository;
        private GenericRepository<Notification> notificationRepository;
        private GenericRepository<ChatUser> chatUserRepository;
        private GenericRepository<Chat> chatRepository;
        private GenericRepository<Message> messageRepository;
        private GenericRepository<Order_Details> order_DetailsRepository;
        private GenericRepository<Rate> rateRepository;
        private GenericRepository<Coupon> couponRepository;
        private GenericRepository<Coupon_redemption> coupon_redemptionRepository;
        private GenericRepository<AthleticProgram> sportsProgramRepository;
        private GenericRepository<Article> articleRepository;

        public UnitOfWork(LiaqatiDBContext context)
        {
            this.context = context;
        }

        public GenericRepository<User> UserRepository
        {
            get
            {

                userRepository ??= new GenericRepository<User>(context);
                return userRepository;
            }
        }
        public GenericRepository<Article> ArticleRepository
        {
            get
            {

                articleRepository ??= new GenericRepository<Article>(context);
                return articleRepository;
            }
        }

        public GenericRepository<Order> OrderRepository
        {
            get
            {

                orderRepository ??= new GenericRepository<Order>(context);
                return orderRepository;
            }
        }

        public GenericRepository<Achievements> AchievementsRepository
        {
            get
            {

                achievementsRepository ??= new GenericRepository<Achievements>(context);
                return achievementsRepository;
            }
        }
        public GenericRepository<ContactUs> ContactUsRepository
        {
            get
            {

                contactUsRepository ??= new GenericRepository<ContactUs>(context);
                return contactUsRepository;
            }
        }

        public GenericRepository<Notification> NotificationRepository
        {
            get
            {

                notificationRepository ??= new GenericRepository<Notification>(context);
                return notificationRepository;
            }
        }

        public GenericRepository<ChatUser> ChatUserRepository
        {
            get
            {

                chatUserRepository ??= new GenericRepository<ChatUser>(context);
                return chatUserRepository;
            }
        }

        public GenericRepository<Chat> ChatRepository
        {
            get
            {


                chatRepository ??= new GenericRepository<Chat>(context);
                return chatRepository;
            }
        }

        public GenericRepository<Message> MessageRepository
        {
            get
            {

                messageRepository ??= new GenericRepository<Message>(context);
                return messageRepository;
            }
        }

        public GenericRepository<Order_Details> Order_DetailsRepository
        {
            get
            {

                order_DetailsRepository ??= new GenericRepository<Order_Details>(context);
                return order_DetailsRepository;
            }
        }

        public GenericRepository<Rate> RateRepository
        {
            get
            {

                rateRepository ??= new GenericRepository<Rate>(context);
                return rateRepository;
            }
        }


        public GenericRepository<Coupon> CouponRepository
        {
            get
            {

                couponRepository ??= new GenericRepository<Coupon>(context);
                return couponRepository;
            }
        }
        public GenericRepository<Coupon_redemption> Coupon_redemptionRepository
        {
            get
            {

                coupon_redemptionRepository ??= new GenericRepository<Coupon_redemption>(context);
                return coupon_redemptionRepository;
            }
        }

        public GenericRepository<AthleticProgram> SportsProgramRepository
        {
            get
            {

                this.sportsProgramRepository ??= new GenericRepository<AthleticProgram>(context);
                return sportsProgramRepository;
            }
        }








        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;


        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}

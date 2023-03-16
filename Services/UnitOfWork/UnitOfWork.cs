using liaqati_master.Data;
using liaqati_master.Models;

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
        private GenericRepository<SportsProgram> sportsProgramRepository;
        private GenericRepository<MealPlans> mealPlansRepository;
        private GenericRepository<Service> serviceRepository;
        private GenericRepository<Category> categoryRepository;
        private GenericRepository<Products> productsRepository;
        private GenericRepository<HealthyRecipes> healthyRecipesRepository;
        private GenericRepository<Exercise> exerciseRepository;

        public UnitOfWork(LiaqatiDBContext context)
        {
            this.context = context;
        }

        public GenericRepository<Products> ProductsRepository
        {
            get
            {

                productsRepository ??= new GenericRepository<Products>(context);
                return productsRepository;
            }
        }

        public GenericRepository<Exercise> ExerciseRepository
        {
            get
            {

                exerciseRepository ??= new GenericRepository<Exercise>(context);
                return exerciseRepository;
            }
        }



        public GenericRepository<HealthyRecipes> HealthyRecipesRepository
        {
            get
            {

                healthyRecipesRepository ??= new GenericRepository<HealthyRecipes>(context);
                return healthyRecipesRepository;
            }
        }


        public GenericRepository<MealPlans> MealPlansRepository
        {
            get
            {

                mealPlansRepository ??= new GenericRepository<MealPlans>(context);
                return mealPlansRepository;
            }
        }

        public GenericRepository<Service> ServiceRepository
        {
            get
            {

                serviceRepository ??= new GenericRepository<Service>(context);
                return serviceRepository;
            }
        }

        public GenericRepository<Category> CategoryRepository
        {
            get
            {

                categoryRepository ??= new GenericRepository<Category>(context);
                return categoryRepository;
            }
        }


        public GenericRepository<User> UserRepository
        {
            get
            {

                userRepository ??= new GenericRepository<User>(context);
                return userRepository;
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

        public GenericRepository<SportsProgram> SportsProgramRepository
        {
            get
            {

                this.sportsProgramRepository ??= new GenericRepository<SportsProgram>(context);
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

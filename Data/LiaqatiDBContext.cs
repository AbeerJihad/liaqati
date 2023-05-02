#nullable disable
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace liaqati_master.Data
{
    public class LiaqatiDBContext : IdentityDbContext<User>
    {
        public LiaqatiDBContext(DbContextOptions<LiaqatiDBContext> options) : base(options) { }
        public DbSet<Order> TblOrder { set; get; }
        public DbSet<Article> TblArticles { set; get; }
        public DbSet<Order_Details> TblOrder_Details { set; get; }
        public DbSet<Rate> TblRate { set; get; }
        public DbSet<SportsProgram> TblSportsProgram { get; set; }
        public DbSet<Service> TblServices { get; set; }
        public DbSet<Exercise> TblExercises { get; set; }
        public DbSet<MealPlans> TblMealPlans { get; set; }
        public DbSet<HealthyRecipe> TblHealthyRecipe { get; set; }
        public DbSet<Meal_Healthy> TblMeal_Healthy { get; set; }
        public DbSet<Product> TblProducts { get; set; }
        public DbSet<Achievement> TblAchievements { get; set; }
        public DbSet<Exercies_program> TblExercies_program { get; set; }
        public DbSet<Favorite> TblFavorite { get; set; }
        public DbSet<Favorite_Servies> TblFavorite_Servies { get; set; }
        public DbSet<Comments> TblComment { get; set; }
        public DbSet<Comment_Servies> TblCommentServies { get; set; }
        public DbSet<Chat> TblChat { get; set; }
        public DbSet<ChatUser> TblChatUser { get; set; }
        public DbSet<Category> TblCategory { get; set; }
        public DbSet<ContactUs> TblContactUs { get; set; }
        public DbSet<Notification> TblNotification { get; set; }
        public DbSet<Ingredent> TblIngredent { get; set; }
        public DbSet<Coupon_redemption> TblCoupon_redemption { get; set; }
        public DbSet<Coupon> TblCoupon { get; set; }
        public DbSet<Files> TblFiles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Relations
            modelBuilder.Entity<Order_Details>().HasOne(a => a.Rate).WithOne(a => a.Order_Details).HasForeignKey<Rate>(c => c.Order_DetailsId);
            modelBuilder.Entity<Service>().HasOne(a => a.Products).WithOne(a => a.Services).HasForeignKey<Product>(c => c.Id);
            modelBuilder.Entity<Service>().HasOne(a => a.MealPlans).WithOne(a => a.Services).HasForeignKey<MealPlans>(c => c.Id);
            modelBuilder.Entity<Service>().HasOne(a => a.SportsProgram).WithOne(a => a.Services).HasForeignKey<SportsProgram>(c => c.Id);


            //AutoInclude
            //modelBuilder.Entity<Service>().Navigation(p => p.Category).AutoInclude();
            //modelBuilder.Entity<MealPlans>().Navigation(p => p.Services).AutoInclude();
            //modelBuilder.Entity<Product>().Navigation(p => p.Services).AutoInclude();
            //modelBuilder.Entity<HealthyRecipe>().Navigation(p => p.Services).AutoInclude();
            //modelBuilder.Entity<SportsProgram>().Navigation(p => p.Services).AutoInclude();

            //Seeding Data
            modelBuilder.Seed();
        }

    }
}

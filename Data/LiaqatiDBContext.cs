
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace liaqati_master.Data
{
    public class LiaqatiDBContext : IdentityDbContext<User>
    {
        public LiaqatiDBContext(DbContextOptions<LiaqatiDBContext> options) : base(options)
        {
        }
        public DbSet<Order> TblOrder { set; get; }
        public DbSet<Article> TblArticles { set; get; }
        public DbSet<Order_Details> TblOrder_Details { set; get; }
        public DbSet<Rate> TblRate { set; get; }
        public DbSet<SportsProgram> TblSportsProgram { get; set; }
        public DbSet<Service> TblServices { get; set; }
        public DbSet<Exercise> TblExercises { get; set; }

        public DbSet<MealPlans> TblMealPlans { get; set; }
        public DbSet<Product> TblProducts { get; set; }
        public DbSet<Achievements> TblAchievements { get; set; }

        public DbSet<Exercies_program> TblExercies_program { get; set; }
        public DbSet<Tracking> TblTracking { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order_Details>()
            .HasOne(a => a.Rate)
            .WithOne(a => a.Order_Details)
            .HasForeignKey<Rate>(c => c.Order_DetailsId);
            modelBuilder.Entity<Service>()
                          .HasOne(a => a.HealthyRecipes)
                          .WithOne(a => a.Services)
                          .HasForeignKey<HealthyRecipe>(c => c.Id);
            modelBuilder.Entity<Service>()
                        .HasOne(a => a.Products)
                        .WithOne(a => a.Services)
                        .HasForeignKey<Product>(c => c.Id);

            modelBuilder.Entity<Service>()
                        .HasOne(a => a.MealPlans)
                        .WithOne(a => a.Services)
                        .HasForeignKey<MealPlans>(c => c.Id);

            modelBuilder.Entity<Service>()
                        .HasOne(a => a.sportsProgram)
                        .WithOne(a => a.Services)
                        .HasForeignKey<SportsProgram>(c => c.Id);

            modelBuilder.Entity<Service>().Navigation(p => p.Category).AutoInclude();
            modelBuilder.Entity<MealPlans>().Navigation(p => p.Services).AutoInclude();
            modelBuilder.Entity<Product>().Navigation(p => p.Services).AutoInclude();
            modelBuilder.Entity<HealthyRecipe>().Navigation(p => p.Services).AutoInclude();
            modelBuilder.Entity<SportsProgram>().Navigation(p => p.Services).AutoInclude();


            modelBuilder.SeedAsync();
        }

        public DbSet<liaqati_master.Models.Category>? Category { get; set; }
    }
}

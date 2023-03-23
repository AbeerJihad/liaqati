﻿namespace liaqati_master.Data
{
    public class LiaqatiDBContext : DbContext
    {
        public LiaqatiDBContext(DbContextOptions<LiaqatiDBContext> options) : base(options)
        {
        }
        public DbSet<Order> TblOrder { set; get; }
        public DbSet<Articles> TblArticles { set; get; }
        public DbSet<Order_Details> TblOrder_Details { set; get; }
        public DbSet<Rate> TblRate { set; get; }
        public DbSet<SportsProgram> TblSportsProgram { get; set; }
        public DbSet<Service> TblServices { get; set; }
        public DbSet<Exercise> TblExercises { get; set; }

        public DbSet<MealPlans> TblMealPlans { get; set; }
        public DbSet<Products> TblProducts { get; set; }
        public DbSet<Exercies_program> TblExercies_program { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<Order_Details>()
            .HasOne(a => a.Rate)
            .WithOne(a => a.Order_Details)
            .HasForeignKey<Rate>(c => c.Order_DetailsId);
            modelBuilder.Entity<Service>()
                          .HasOne(a => a.HealthyRecipes)
                          .WithOne(a => a.services)
                          .HasForeignKey<HealthyRecipes>(c => c.Id);
            modelBuilder.Entity<Service>()
                        .HasOne(a => a.Products)
                        .WithOne(a => a.services)
                        .HasForeignKey<Products>(c => c.Id);

            modelBuilder.Entity<Service>()
                        .HasOne(a => a.MealPlans)
                        .WithOne(a => a.services)
                        .HasForeignKey<MealPlans>(c => c.Id);






            modelBuilder.Entity<Service>()
                        .HasOne(a => a.sportsProgram)
                        .WithOne(a => a.services)
                        .HasForeignKey<SportsProgram>(c => c.Id);


           modelBuilder.Entity<MealPlans>().Navigation(p => p.services).AutoInclude();

            modelBuilder.Entity<Products>().Navigation(p => p.services).AutoInclude();

            modelBuilder.Entity<HealthyRecipes>().Navigation(p => p.services).AutoInclude();
           modelBuilder.Entity<SportsProgram>().Navigation(p => p.services).AutoInclude();


           modelBuilder.Entity<Exercies_program>().Navigation(p => p.sportsProgram).AutoInclude();

            modelBuilder.Entity<SportsProgram>().Navigation(p => p.exercies_Programs).AutoInclude();

            modelBuilder.Entity<Exercise>().Navigation(p => p.exercies_Programs).AutoInclude();


            modelBuilder.SeedAsync();
        }
    }
}

namespace liaqati_master.Data
{
    public static class SeedingDataOnModelCreating
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            var password = new PasswordHasher<User>();
            var user = new User
            {
                Id = "cadcdb03-ee31-4652-a8b5-9a9ace656e8f",
                Fname = "عمر",
                Lname = "حمد",
                Email = "user@example.com",
                NormalizedEmail = "USER@EXAMPLE.COM",
                UserName = "user@example.com",
                NormalizedUserName = "USER@EXAMPLE.COM",
                PhoneNumber = "+111111111111",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var hashed = password.HashPassword(user, "secret");
            user.PasswordHash = hashed;
            modelBuilder.Entity<SportsProgram>().HasData(Database.GetListOfSportsProgram());
            modelBuilder.Entity<User>().HasData(Database.GetListOfUsers().Append(user));
            modelBuilder.Entity<Product>().HasData(Database.GetListOfProducts());
            modelBuilder.Entity<Order>().HasData(Database.GetListOfOrders());
            modelBuilder.Entity<Category>().HasData(Database.GetListOfCategories());
            modelBuilder.Entity<Service>().HasData(Database.GetListOfOServies());
            modelBuilder.Entity<MealPlans>().HasData(Database.GetListOfMealPlan());
            modelBuilder.Entity<Order_Details>().HasData(Database.GetListOfOrdersDetails());
            modelBuilder.Entity<Tracking>().HasData(Database.GetListOfTracking());
            modelBuilder.Entity<Exercies_program>().HasData(Database.GetListOfExerciesprogram());
            modelBuilder.Entity<Exercise>().HasData(Database.GetListOfExercise());
            modelBuilder.Entity<HealthyRecipe>().HasData(Database.GetListHealthyRecipe().Concat(Database.GetListHealthyRecipe2()));
            modelBuilder.Entity<Files>().HasData(Database.GetListFiles());
            modelBuilder.Entity<Article>().HasData(Database.GetListOfArticle());
            modelBuilder.Entity<Consultation>().HasData(Database.GetListOfConsultation());
            modelBuilder.Entity<Replyconsultation>().HasData(Database.GetListOfReplyconsultation());
            modelBuilder.Entity<Notification>().HasData(Database.GetListOfNotifications());
        }
    }
}
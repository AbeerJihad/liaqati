namespace liaqati_master.Data
{
    public static class SeedingDataOnModelCreating
    {


        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SportsProgram>().HasData
                (
                Database.GetListOfAthleticProgram()
                );

            modelBuilder.Entity<User>().HasData(
                Database.GetListOfUsers()
             );
            modelBuilder.Entity<Product>().HasData(
              Database.GetListOfProducts()
           );

            modelBuilder.Entity<Order>().HasData(
                Database.GetListOfOrders()
             );
            modelBuilder.Entity<Category>().HasData(
             Database.GetListOfCategories()
          );
            modelBuilder.Entity<Service>().HasData(
          Database.GetListOfOServies()
       );

            modelBuilder.Entity<MealPlans>().HasData(
               Database.GetListOfMealPlan()
            );
            modelBuilder.Entity<Order_Details>().HasData(
            Database.GetListOfOrdersDetails()
         );





        }

    }
}

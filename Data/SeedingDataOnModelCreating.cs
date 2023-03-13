namespace liaqati_master.Data
{
    public static class SeedingDataOnModelCreating
    {


        public static void SeedAsync(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AthleticProgram>().HasData
                (
                Database.GetListOfAthleticProgram()
                );

            modelBuilder.Entity<User>().HasData(
                Database.GetListOfUsers()
             );

            modelBuilder.Entity<Order>().HasData(
                Database.GetListOfOrders()
             );
        }

    }
}

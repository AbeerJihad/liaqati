namespace liaqati_master.Data
{
    public static class SeedData
    {
        public static void SeedAsync(IApplicationBuilder applicationBuilder)
        {

            using var scope = applicationBuilder.ApplicationServices.CreateScope();
            LiaqatiDBContext liaqatiDBContext = scope.ServiceProvider.GetRequiredService<LiaqatiDBContext>();
            var migrations = liaqatiDBContext.Database.GetPendingMigrations();
            if (migrations.Any())
                liaqatiDBContext.Database.Migrate();

            if (!liaqatiDBContext.TblSportsProgram.Any())
            {
                liaqatiDBContext.TblSportsProgram.AddRangeAsync(Database.GetListOfAthleticProgram());

            }


        }
    }
}

using Microsoft.AspNetCore.Identity;

namespace liaqati_master.Data
{
    public static class SeedData
    {
        public static async Task SeedAsync(IApplicationBuilder applicationBuilder)
        {

            using var scope = applicationBuilder.ApplicationServices.CreateScope();
            LiaqatiDBContext liaqatiDBContext = scope.ServiceProvider.GetRequiredService<LiaqatiDBContext>();
            RoleManager<IdentityRole>? RoleManager = scope.ServiceProvider?.GetService<RoleManager<IdentityRole>>();
            UserManager<User>? userManager = scope.ServiceProvider?.GetService<UserManager<User>>();
            //var migrations = liaqatiDBContext.Database.GetPendingMigrations();
            //if (migrations.Any())
            // liaqatiDBContext.Database.Migrate();
            if (!liaqatiDBContext.TblSportsProgram.Any())
            {
                await liaqatiDBContext.TblSportsProgram.AddRangeAsync(Database.GetListOfAthleticProgram());
            }
            await SeedRoles(RoleManager);
            await SeedUsers(userManager, RoleManager);
        }
        private static async Task SeedUsers(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (await userManager.FindByNameAsync("OmarHamad") == null)
            {
                var Admin = new User
                {
                    Photo = "Admin.jpg",
                    UserName = "OmarHamad",
                    Email = "admin@website.com",
                    Fname = "Website",
                    Lname = "Admin"
                };
                var result = await userManager.CreateAsync(Admin, "Admin123@");
                if (result.Succeeded)
                {
                    bool checkRole = await roleManager!.RoleExistsAsync("Admin");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Admin" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Admin, "Admin");
                    }
                    else
                    {
                        await userManager.AddToRolesAsync(Admin, new[] { "Admin", "Trainer", "Customer" });
                    }

                }
            }
            if (await userManager.FindByNameAsync("Trainer1") == null)
            {
                var Trainer = new User
                {
                    Photo = "Trainer1.jpg",
                    UserName = "Trainer1",
                    Email = "trainer1@website.com",
                    Fname = "Trainer1",
                    Lname = "Trainer1"
                };
                var result = await userManager.CreateAsync(Trainer, "Trainer1231@");
                if (result.Succeeded)
                {
                    bool checkRole = await roleManager!.RoleExistsAsync("Trainer");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Trainer" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Trainer, "Trainer");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Trainer, "Trainer");
                    }

                }
            }
            if (await userManager.FindByNameAsync("Trainer2") == null)
            {
                var Trainer = new User
                {
                    Photo = "Trainer2.jpg",
                    UserName = "Trainer2",
                    Email = "trainer2@website.com",
                    Fname = "Trainer2",
                    Lname = "Trainer2"
                };
                var result = await userManager.CreateAsync(Trainer, "Trainer2231@");
                if (result.Succeeded)
                {
                    bool checkRole = await roleManager!.RoleExistsAsync("Trainer");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Trainer" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Trainer, "Trainer");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Trainer, "Trainer");
                    }

                }
            }
            if (await userManager.FindByNameAsync("Trainer3") == null)
            {
                var Trainer = new User
                {
                    Photo = "Trainer3.jpg",
                    UserName = "Trainer3",
                    Email = "trainer3@website.com",
                    Fname = "Trainer3",
                    Lname = "Trainer3"
                };
                var result = await userManager.CreateAsync(Trainer, "Trainer3231@");
                if (result.Succeeded)
                {
                    bool checkRole = await roleManager!.RoleExistsAsync("Trainer");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Trainer" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Trainer, "Trainer");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Trainer, "Trainer");
                    }

                }
            }
        }
        private static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                var role = new IdentityRole
                {
                    Name = "Admin",
                };
                await roleManager.CreateAsync(role);
            }
            if (!await roleManager.RoleExistsAsync("Trainer"))
            {
                var role = new IdentityRole
                {
                    Name = "Trainer",
                };
                await roleManager.CreateAsync(role);
            }
            if (!await roleManager.RoleExistsAsync("Customer"))
            {
                var role = new IdentityRole
                {
                    Name = "Customer",
                };
                await roleManager.CreateAsync(role);
            }

        }
    }
}

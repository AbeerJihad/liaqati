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
            //if (!liaqatiDBContext.TblSportsProgram.Any())
            //{
            //    await liaqatiDBContext.TblSportsProgram.AddRangeAsync(Database.GetListOfSportsProgram());
            //}
            await SeedRoles(RoleManager);
            await SeedUsers(userManager, RoleManager);
        }
         private static async Task SeedUsers(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (await userManager.FindByNameAsync("admin@website.com") == null)
            {
                var Admin = new User
                {
                    Photo = "/Images/Experts/m7.png",
                    UserName = "admin@website.com",
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
                    Photo = "/Images/Experts/m2.jpg",
                    UserName = "mohammed.sal2003@gmail.com",
                    Email = "mohammed.sal2003@gmail.com",
                    Fname = "محمد",
                    Lname = "سلامة",
                    Specialization = "مدرب لياقة "

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
                    Photo = "/Images/Experts/m1.png",
                    UserName = "trainer2@website.com",
                    Email = "trainer2@website.com",
                    Fname = "خالد",
                    Lname = "ياسين" ,
                    Specialization = "مدرب لياقة "

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
                    Photo = "/Images/Experts/m3.jpg",
                    UserName = "trainer3@website.com",
                    Email = "trainer3@website.com",
                    Fname = "عمر",
                    Lname = "حمد",
                    Specialization = "مدرب قوة "

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
       
            if (await userManager.FindByNameAsync("Trainer4") == null)
            {
                var Trainer = new User
                {
                    Photo = "/Images/Experts/m4.jpg",
                    UserName = "trainer4@website.com",
                    Email = "trainer4@website.com",
                    Fname = "ياسر",
                    Lname = "احمد",
                    Specialization = "مدرب كارديو "
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
          
            
            if (await userManager.FindByNameAsync("Trainer5") == null)
            {
                var Trainer = new User
                {
                    Photo = "/Images/Experts/m5.png",
                    UserName = "trainer5@website.com",
                    Email = "trainer5@website.com",
                    Fname = "حمزة",
                    Lname = "ياسر",
                    Specialization = "مدرب لياقة "
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

            if (await userManager.FindByNameAsync("Trainer6") == null)
            {
                var Trainer = new User
                {
                    Photo = "/Images/Experts/m6.png",
                    UserName = "trainer56website.com",
                    Email = "trainer6@website.com",
                    Fname = "ابراهيم",
                    Lname = "رامي",
                    Specialization = " اخصائي تغذية "
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

            if (await userManager.FindByNameAsync("Trainer7") == null)
            {
                var Trainer = new User
                {
                    Photo = "/Images/Experts/w1.jpg",
                    UserName = "trainer7@website.com",
                    Email = "trainer7@website.com",
                    Fname = "يسرا",
                    Lname = "مهدي",
                    Specialization = "مدرب كارديو "
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

            if (await userManager.FindByNameAsync("Trainer8") == null)
            {
                var Trainer = new User
                {
                    Photo = "/Images/Experts/w2.jpg",
                    UserName = "trainer8@website.com",
                    Email = "trainer8@website.com",
                    Fname = "ملك",
                    Lname = "ابو رامي",
                    Specialization = "مدرب لياقة "
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

            if (await userManager.FindByNameAsync("Trainer9") == null)
            {
                var Trainer = new User
                {
                    Photo = "/Images/Experts/w3.png",
                    UserName = "trainer9@website.com",
                    Email = "trainer9@website.com",
                    Fname = "ملك",
                    Lname = "الطيبي",
                    Specialization = "مدرب قوة "
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

            if (await userManager.FindByNameAsync("Trainer10") == null)
            {
                var Trainer = new User
                {
                    Photo = "/Images/Experts/w4.jpg",
                    UserName = "trainer10@website.com",
                    Email = "trainer10@website.com",
                    Fname = "ريهام",
                    Lname = "البردويل",
                    Specialization = "مدرب كارديو "
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

            if (await userManager.FindByNameAsync("Trainer11") == null)
            {
                var Trainer = new User
                {
                    Photo = "/Images/Experts/w5.jpg",
                    UserName = "trainer11@website.com",
                    Email = "trainer11@website.com",
                    Fname = "فرح",
                    Lname = "الحلبي",
                    Specialization = "  اخصائي تغذية"
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

            if (await userManager.FindByNameAsync("Trainer12") == null)
            {
                var Trainer = new User
                {
                    Photo = "/Images/Experts/womanDefault.jfif",
                    UserName = "trainer12@website.com",
                    Email = "trainer12@website.com",
                    Fname = "ندئ",
                    Lname = "محسن",
                    Specialization = " اخصائي تغذية  "
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

            if (await userManager.FindByNameAsync("Trainer13") == null)
            {
                var Trainer = new User
                {
                    Photo = "/Images/Experts/ManDefault.jfif",
                    UserName = "trainer13@website.com",
                    Email = "trainer13@website.com",
                    Fname = "عبيدة",
                    Lname = "احمد",
                    Specialization = "مدرب لياقة "
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

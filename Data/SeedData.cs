using System.Security.Claims;

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
            if (RoleManager != null)
                await SeedRoles(roleManager: RoleManager);
            if (userManager != null && RoleManager != null)
                await SeedUsers(userManager, roleManager: RoleManager);
            if (!await liaqatiDBContext.TblConsultation.AnyAsync())
            {
                await liaqatiDBContext.TblConsultation.AddRangeAsync(Database.GetListOfConsultation());
            }
            if (!await liaqatiDBContext.TblReplyconsultation.AnyAsync())
            {
                await liaqatiDBContext.TblReplyconsultation.AddRangeAsync(Database.GetListOfReplyconsultation());
            }
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
                    Fname = "مدير",
                    Lname = "لياقتي",
                    Specialization = "إدارة لياقتي"
                };
                var result = await userManager.CreateAsync(Admin, "Admin123@");
                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(Admin, new Claim(Database.Admin, "true"));
                    await userManager.AddClaimAsync(Admin, new Claim("FirstName", Admin.Fname));
                    await userManager.AddClaimAsync(Admin, new Claim("Image", Admin.Photo));
                    await userManager.AddClaimAsync(Admin, new Claim("LastName", Admin.Lname));
                    await userManager.AddClaimAsync(Admin, new Claim("Specialization", Admin.Specialization));

                    bool checkRole = await roleManager!.RoleExistsAsync("Admin");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Admin" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Admin, "Admin");
                    }
                    else
                    {
                        await userManager.AddToRolesAsync(Admin, new[] { "Admin", "Expert", "Customer" });
                    }

                }
            }
            if (await userManager.FindByNameAsync("Expert1") == null)
            {
                var Expert = new User
                {
                    Photo = "/Images/Experts/m2.jpg",
                    UserName = "mohammed.sal2003@gmail.com",
                    Email = "mohammed.sal2003@gmail.com",
                    Fname = "محمد",
                    Lname = "سلامة",
                    Specialization = "مدرب لياقة "

                };
                var result = await userManager.CreateAsync(Expert, "Expert1231@");
                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(Expert, new Claim(Database.Expert, value: "true"));
                    await userManager.AddClaimAsync(Expert, new Claim("FirstName", Expert.Fname));
                    await userManager.AddClaimAsync(Expert, new Claim("Image", Expert.Photo));
                    await userManager.AddClaimAsync(Expert, new Claim("LastName", Expert.Lname));
                    await userManager.AddClaimAsync(Expert, new Claim("Specialization", Expert.Specialization));
                    bool checkRole = await roleManager!.RoleExistsAsync("Expert");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Expert" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }

                }
            }
            if (await userManager.FindByNameAsync("Expert2") == null)
            {
                var Expert = new User
                {
                    Photo = "/Images/Experts/m1.png",
                    UserName = "expert2@website.com",
                    Email = "expert2@website.com",
                    Fname = "خالد",
                    Lname = "ياسين",
                    Specialization = "مدرب لياقة "

                };
                var result = await userManager.CreateAsync(Expert, "Expert2231@");
                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(Expert, new Claim(Database.Expert, value: "true"));
                    await userManager.AddClaimAsync(Expert, new Claim("FirstName", Expert.Fname));
                    await userManager.AddClaimAsync(Expert, new Claim("Image", Expert.Photo));
                    await userManager.AddClaimAsync(Expert, new Claim("LastName", Expert.Lname));
                    await userManager.AddClaimAsync(Expert, new Claim("Specialization", Expert.Specialization));


                    bool checkRole = await roleManager!.RoleExistsAsync("Expert");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Expert" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }

                }
            }
            if (await userManager.FindByNameAsync("Expert3") == null)
            {
                var Expert = new User
                {
                    Photo = "/Images/Experts/m3.jpg",
                    UserName = "expert3@website.com",
                    Email = "expert3@website.com",
                    Fname = "عمر",
                    Lname = "حمد",
                    Specialization = "مدرب قوة "

                };
                var result = await userManager.CreateAsync(Expert, "Expert3231@");
                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(Expert, new Claim(Database.Expert, value: "true"));
                    await userManager.AddClaimAsync(Expert, new Claim("FirstName", Expert.Fname));
                    await userManager.AddClaimAsync(Expert, new Claim("Image", Expert.Photo));
                    await userManager.AddClaimAsync(Expert, new Claim("LastName", Expert.Lname));
                    await userManager.AddClaimAsync(Expert, new Claim("Specialization", Expert.Specialization));

                    bool checkRole = await roleManager!.RoleExistsAsync("Expert");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Expert" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }

                }
            }

            if (await userManager.FindByNameAsync("Expert4") == null)
            {
                var Expert = new User
                {
                    Photo = "/Images/Experts/m4.jpg",
                    UserName = "expert4@website.com",
                    Email = "expert4@website.com",
                    Fname = "ياسر",
                    Lname = "احمد",
                    Specialization = "مدرب كارديو "
                };
                var result = await userManager.CreateAsync(Expert, "Expert3231@");
                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(Expert, new Claim(Database.Expert, value: "true"));
                    await userManager.AddClaimAsync(Expert, new Claim("FirstName", Expert.Fname));
                    await userManager.AddClaimAsync(Expert, new Claim("Image", Expert.Photo));
                    await userManager.AddClaimAsync(Expert, new Claim("LastName", Expert.Lname));
                    await userManager.AddClaimAsync(Expert, new Claim("Specialization", Expert.Specialization));


                    bool checkRole = await roleManager!.RoleExistsAsync("Expert");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Expert" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }

                }
            }


            if (await userManager.FindByNameAsync("Expert5") == null)
            {
                var Expert = new User
                {
                    Photo = "/Images/Experts/m5.png",
                    UserName = "expert5@website.com",
                    Email = "expert5@website.com",
                    Fname = "حمزة",
                    Lname = "ياسر",
                    Specialization = "مدرب لياقة "
                };
                var result = await userManager.CreateAsync(Expert, "Expert3231@");
                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(Expert, new Claim(Database.Expert, value: "true"));
                    await userManager.AddClaimAsync(Expert, new Claim("FirstName", Expert.Fname));
                    await userManager.AddClaimAsync(Expert, new Claim("Image", Expert.Photo));
                    await userManager.AddClaimAsync(Expert, new Claim("LastName", Expert.Lname));
                    await userManager.AddClaimAsync(Expert, new Claim("Specialization", Expert.Specialization));


                    bool checkRole = await roleManager!.RoleExistsAsync("Expert");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Expert" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }

                }
            }

            if (await userManager.FindByNameAsync("Expert6") == null)
            {
                var Expert = new User
                {
                    Photo = "/Images/Experts/m6.png",
                    UserName = "expert56website.com",
                    Email = "expert6@website.com",
                    Fname = "ابراهيم",
                    Lname = "رامي",
                    Specialization = " اخصائي تغذية "
                };
                var result = await userManager.CreateAsync(Expert, "Expert3231@");
                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(Expert, new Claim(Database.Expert, value: "true"));

                    await userManager.AddClaimAsync(Expert, new Claim("FirstName", Expert.Fname));
                    await userManager.AddClaimAsync(Expert, new Claim("Image", Expert.Photo));
                    await userManager.AddClaimAsync(Expert, new Claim("LastName", Expert.Lname));
                    await userManager.AddClaimAsync(Expert, new Claim("Specialization", Expert.Specialization));


                    bool checkRole = await roleManager!.RoleExistsAsync("Expert");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Expert" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }

                }
            }

            if (await userManager.FindByNameAsync("Expert7") == null)
            {
                var Expert = new User
                {
                    Photo = "/Images/Experts/w1.jpg",
                    UserName = "expert7@website.com",
                    Email = "expert7@website.com",
                    Fname = "يسرا",
                    Lname = "مهدي",
                    Specialization = "مدرب كارديو "
                };
                var result = await userManager.CreateAsync(Expert, "Expert3231@");
                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(Expert, new Claim(Database.Expert, value: "true"));
                    await userManager.AddClaimAsync(Expert, new Claim("FirstName", Expert.Fname));
                    await userManager.AddClaimAsync(Expert, new Claim("Image", Expert.Photo));
                    await userManager.AddClaimAsync(Expert, new Claim("LastName", Expert.Lname));
                    await userManager.AddClaimAsync(Expert, new Claim("Specialization", Expert.Specialization));


                    bool checkRole = await roleManager!.RoleExistsAsync("Expert");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Expert" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }

                }
            }

            if (await userManager.FindByNameAsync("Expert8") == null)
            {
                var Expert = new User
                {
                    Photo = "/Images/Experts/w2.jpg",
                    UserName = "expert8@website.com",
                    Email = "expert8@website.com",
                    Fname = "ملك",
                    Lname = "ابو رامي",
                    Specialization = "مدرب لياقة "
                };
                var result = await userManager.CreateAsync(Expert, "Expert3231@");
                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(Expert, new Claim(Database.Expert, value: "true"));

                    await userManager.AddClaimAsync(Expert, new Claim("FirstName", Expert.Fname));
                    await userManager.AddClaimAsync(Expert, new Claim("Image", Expert.Photo));
                    await userManager.AddClaimAsync(Expert, new Claim("LastName", Expert.Lname));
                    await userManager.AddClaimAsync(Expert, new Claim("Specialization", Expert.Specialization));


                    bool checkRole = await roleManager!.RoleExistsAsync("Expert");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Expert" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }

                }
            }

            if (await userManager.FindByNameAsync("Expert9") == null)
            {
                var Expert = new User
                {
                    Photo = "/Images/Experts/w3.png",
                    UserName = "expert9@website.com",
                    Email = "expert9@website.com",
                    Fname = "ملك",
                    Lname = "الطيبي",
                    Specialization = "مدرب قوة "
                };
                var result = await userManager.CreateAsync(Expert, "Expert3231@");
                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(Expert, new Claim(Database.Expert, value: "true"));
                    await userManager.AddClaimAsync(Expert, new Claim("FirstName", Expert.Fname));
                    await userManager.AddClaimAsync(Expert, new Claim("Image", Expert.Photo));
                    await userManager.AddClaimAsync(Expert, new Claim("LastName", Expert.Lname));
                    await userManager.AddClaimAsync(Expert, new Claim("Specialization", Expert.Specialization));


                    bool checkRole = await roleManager!.RoleExistsAsync("Expert");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Expert" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }

                }
            }

            if (await userManager.FindByNameAsync("Expert10") == null)
            {
                var Expert = new User
                {
                    Photo = "/Images/Experts/w4.jpg",
                    UserName = "expert10@website.com",
                    Email = "expert10@website.com",
                    Fname = "ريهام",
                    Lname = "البردويل",
                    Specialization = "مدرب كارديو "
                };
                var result = await userManager.CreateAsync(Expert, "Expert3231@");
                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(Expert, new Claim(Database.Expert, value: "true"));

                    await userManager.AddClaimAsync(Expert, new Claim("FirstName", Expert.Fname));
                    await userManager.AddClaimAsync(Expert, new Claim("Image", Expert.Photo));
                    await userManager.AddClaimAsync(Expert, new Claim("LastName", Expert.Lname));
                    await userManager.AddClaimAsync(Expert, new Claim("Specialization", Expert.Specialization));


                    bool checkRole = await roleManager!.RoleExistsAsync("Expert");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Expert" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }

                }
            }

            if (await userManager.FindByNameAsync("Expert11") == null)
            {
                var Expert = new User
                {
                    Photo = "/Images/Experts/w5.jpg",
                    UserName = "expert11@website.com",
                    Email = "expert11@website.com",
                    Fname = "فرح",
                    Lname = "الحلبي",
                    Specialization = "  اخصائي تغذية"
                };
                var result = await userManager.CreateAsync(Expert, "Expert3231@");
                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(Expert, new Claim(Database.Expert, value: "true"));
                    await userManager.AddClaimAsync(Expert, new Claim("FirstName", Expert.Fname));
                    await userManager.AddClaimAsync(Expert, new Claim("Image", Expert.Photo));
                    await userManager.AddClaimAsync(Expert, new Claim("LastName", Expert.Lname));
                    await userManager.AddClaimAsync(Expert, new Claim("Specialization", Expert.Specialization));


                    bool checkRole = await roleManager!.RoleExistsAsync("Expert");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Expert" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }

                }
            }

            if (await userManager.FindByNameAsync("Expert12") == null)
            {
                var Expert = new User
                {
                    Photo = "/Images/Experts/womanDefault.jfif",
                    UserName = "expert12@website.com",
                    Email = "expert12@website.com",
                    Fname = "ندئ",
                    Lname = "محسن",
                    Specialization = " اخصائي تغذية  "
                };
                var result = await userManager.CreateAsync(Expert, "Expert3231@");
                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(Expert, new Claim(Database.Expert, value: "true"));

                    await userManager.AddClaimAsync(Expert, new Claim("FirstName", Expert.Fname));
                    await userManager.AddClaimAsync(Expert, new Claim("Image", Expert.Photo));
                    await userManager.AddClaimAsync(Expert, new Claim("LastName", Expert.Lname));
                    await userManager.AddClaimAsync(Expert, new Claim("Specialization", Expert.Specialization));


                    bool checkRole = await roleManager!.RoleExistsAsync("Expert");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Expert" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }

                }
            }

            if (await userManager.FindByNameAsync("Expert13") == null)
            {
                var Expert = new User
                {
                    Photo = "/Images/Experts/ManDefault.jfif",
                    UserName = "expert13@website.com",
                    Email = "expert13@website.com",
                    Fname = "عبيدة",
                    Lname = "احمد",
                    Specialization = "مدرب لياقة "
                };
                var result = await userManager.CreateAsync(Expert, "Expert3231@");
                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(Expert, new Claim(Database.Expert, value: "true"));
                    await userManager.AddClaimAsync(Expert, new Claim("FirstName", Expert.Fname));
                    await userManager.AddClaimAsync(Expert, new Claim("Image", Expert.Photo));
                    await userManager.AddClaimAsync(Expert, new Claim("LastName", Expert.Lname));
                    await userManager.AddClaimAsync(Expert, new Claim("Specialization", Expert.Specialization));


                    bool checkRole = await roleManager!.RoleExistsAsync("Expert");
                    if (!checkRole)
                    {
                        IdentityRole role = new() { Name = "Expert" };
                        await roleManager.CreateAsync(role);
                        await userManager.AddToRoleAsync(Expert, "Expert");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(Expert, "Expert");
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
            if (!await roleManager.RoleExistsAsync("Expert"))
            {
                var role = new IdentityRole
                {
                    Name = "Expert",
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

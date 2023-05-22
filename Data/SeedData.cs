namespace liaqati_master.Data
{
    public static class SeedData
    {
        public static async Task SeedAsync(IApplicationBuilder applicationBuilder)
        {

            using var scope = applicationBuilder.ApplicationServices.CreateScope();
            LiaqatiDBContext liaqatiDBContext = scope.ServiceProvider.GetRequiredService<LiaqatiDBContext>();
            UserManager<User>? userManager = scope.ServiceProvider?.GetService<UserManager<User>>();
            //var migrations = liaqatiDBContext.Database.GetPendingMigrations();
            //if (migrations.Any())
            // liaqatiDBContext.Database.Migrate();
            //if (!liaqatiDBContext.TblSportsProgram.Any())
            //{
            //    await liaqatiDBContext.TblSportsProgram.AddRangeAsync(Database.GetListOfSportsProgram());
            //}

            if (userManager != null)
                await SeedUsers(userManager);

            //if (!await liaqatiDBContext.TblServices.AnyAsync())
            //{
            //    await liaqatiDBContext.TblServices.AddRangeAsync(Database.GetListOfOServies());
            //}
            //if (!await liaqatiDBContext.TblSportsProgram.AnyAsync())
            //{
            //    await liaqatiDBContext.TblSportsProgram.AddRangeAsync(Database.GetListOfSportsProgram());
            //} 
            //if (!await liaqatiDBContext.TblServices.AnyAsync())
            //{
            //    await liaqatiDBContext.TblServices.AddRangeAsync(Database.GetListOfOServies());
            //}
            //if (!await liaqatiDBContext.TblSportsProgram.AnyAsync())
            //{
            //    await liaqatiDBContext.TblSportsProgram.AddRangeAsync(Database.GetListOfSportsProgram());
            //}
            //if (!await liaqatiDBContext.TblProducts.AnyAsync())
            //{
            //    await liaqatiDBContext.TblProducts.AddRangeAsync(Database.GetListOfProducts());
            //}
            //if (!await liaqatiDBContext.TblOrder.AnyAsync())
            //{
            //    await liaqatiDBContext.TblOrder.AddRangeAsync(Database.GetListOfOrders());
            //}
            //if (!await liaqatiDBContext.TblCategory.AnyAsync())
            //{
            //    await liaqatiDBContext.TblCategory.AddRangeAsync(Database.GetListOfCategories());
            //}
            //if (!await liaqatiDBContext.TblMealPlans.AnyAsync())
            //{
            //    await liaqatiDBContext.TblMealPlans.AddRangeAsync(Database.GetListOfMealPlan());
            //}
            //if (!await liaqatiDBContext.TblOrder_Details.AnyAsync())
            //{
            //    await liaqatiDBContext.TblOrder_Details.AddRangeAsync(Database.GetListOfOrdersDetails());
            //}
            //if (!await liaqatiDBContext.TblTracking.AnyAsync())
            //{
            //    await liaqatiDBContext.TblTracking.AddRangeAsync(Database.GetListOfTracking());
            //}
            //if (!await liaqatiDBContext.TblExercises.AnyAsync())
            //{
            //    await liaqatiDBContext.TblExercises.AddRangeAsync(Database.GetListOfExercise());
            //}
            //if (!await liaqatiDBContext.TblExercies_program.AnyAsync())
            //{
            //    await liaqatiDBContext.TblExercies_program.AddRangeAsync(Database.GetListOfExerciesprogram());
            //}
            //if (!await liaqatiDBContext.TblHealthyRecipe.AnyAsync())
            //{
            //    await liaqatiDBContext.TblHealthyRecipe.AddRangeAsync(Database.GetListHealthyRecipe().Concat(Database.GetListHealthyRecipe2()));
            //}
            //if (!await liaqatiDBContext.TblFiles.AnyAsync())
            //{
            //    await liaqatiDBContext.TblFiles.AddRangeAsync(Database.GetListFiles());
            //}
            //if (!await liaqatiDBContext.TblArticles.AnyAsync())
            //{
            //    await liaqatiDBContext.TblArticles.AddRangeAsync(Database.GetListOfArticle());
            //}
            //if (!await liaqatiDBContext.TblNotification.AnyAsync())
            //{
            //    await liaqatiDBContext.TblNotification.AddRangeAsync(Database.GetListOfNotifications());
            //}
            try
            {
                await liaqatiDBContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static async Task SeedUsers(UserManager<User> userManager)
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
                    List<Claim> claims = new() {
                                            new Claim(Database.Admin, "true"),
                        new Claim("FirstName", Admin.Fname),
                        new Claim("Image", Admin.Photo),
                        new Claim("LastName", Admin.Lname),
                        new Claim("Specialization", Admin.Specialization)
                    };
                    await userManager.AddClaimsAsync(Admin, claims);

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
                    List<Claim> claims = new() {
                                            new Claim(Database.Expert, "true"),
                        new Claim("FirstName", Expert.Fname),
                        new Claim("Image", Expert.Photo),
                        new Claim("LastName", Expert.Lname),
                        new Claim("Specialization", Expert.Specialization)
                    };
                    await userManager.AddClaimsAsync(Expert, claims);

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
                    List<Claim> claims = new() {
                                            new Claim(Database.Expert, "true"),
                        new Claim("FirstName", Expert.Fname),
                        new Claim("Image", Expert.Photo),
                        new Claim("LastName", Expert.Lname),
                        new Claim("Specialization", Expert.Specialization)
                    };
                    await userManager.AddClaimsAsync(Expert, claims);

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
                    List<Claim> claims = new() {
                                            new Claim(Database.Expert, "true"),
                        new Claim("FirstName", Expert.Fname),
                        new Claim("Image", Expert.Photo),
                        new Claim("LastName", Expert.Lname),
                        new Claim("Specialization", Expert.Specialization)
                    };
                    await userManager.AddClaimsAsync(Expert, claims);

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
                    List<Claim> claims = new() {
                                            new Claim(Database.Expert, "true"),
                        new Claim("FirstName", Expert.Fname),
                        new Claim("Image", Expert.Photo),
                        new Claim("LastName", Expert.Lname),
                        new Claim("Specialization", Expert.Specialization)
                    };
                    await userManager.AddClaimsAsync(Expert, claims);
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
                    List<Claim> claims = new() {
                                            new Claim(Database.Expert, "true"),
                        new Claim("FirstName", Expert.Fname),
                        new Claim("Image", Expert.Photo),
                        new Claim("LastName", Expert.Lname),
                        new Claim("Specialization", Expert.Specialization)
                    };
                    await userManager.AddClaimsAsync(Expert, claims);
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
                    List<Claim> claims = new() {
                                            new Claim(Database.Expert, "true"),
                        new Claim("FirstName", Expert.Fname),
                        new Claim("Image", Expert.Photo),
                        new Claim("LastName", Expert.Lname),
                        new Claim("Specialization", Expert.Specialization)
                    };
                    await userManager.AddClaimsAsync(Expert, claims);
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
                    List<Claim> claims = new() {
                                            new Claim(Database.Expert, "true"),
                        new Claim("FirstName", Expert.Fname),
                        new Claim("Image", Expert.Photo),
                        new Claim("LastName", Expert.Lname),
                        new Claim("Specialization", Expert.Specialization)
                    };
                    await userManager.AddClaimsAsync(Expert, claims);

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
                    List<Claim> claims = new() {
                                            new Claim(Database.Expert, "true"),
                        new Claim("FirstName", Expert.Fname),
                        new Claim("Image", Expert.Photo),
                        new Claim("LastName", Expert.Lname),
                        new Claim("Specialization", Expert.Specialization)
                    };
                    await userManager.AddClaimsAsync(Expert, claims);

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
                    List<Claim> claims = new() {
                                            new Claim(Database.Expert, "true"),
                        new Claim("FirstName", Expert.Fname),
                        new Claim("Image", Expert.Photo),
                        new Claim("LastName", Expert.Lname),
                        new Claim("Specialization", Expert.Specialization)
                    };
                    await userManager.AddClaimsAsync(Expert, claims);

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
                    List<Claim> claims = new() {
                                            new Claim(Database.Expert, "true"),
                        new Claim("FirstName", Expert.Fname),
                        new Claim("Image", Expert.Photo),
                        new Claim("LastName", Expert.Lname),
                        new Claim("Specialization", Expert.Specialization)
                    };
                    await userManager.AddClaimsAsync(Expert, claims);

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
                    List<Claim> claims = new() {
                                            new Claim(Database.Expert, "true"),
                        new Claim("FirstName", Expert.Fname),
                        new Claim("Image", Expert.Photo),
                        new Claim("LastName", Expert.Lname),
                        new Claim("Specialization", Expert.Specialization)
                    };
                    await userManager.AddClaimsAsync(Expert, claims);

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
                    List<Claim> claims = new() {
                                            new Claim(Database.Expert, "true"),
                        new Claim("FirstName", Expert.Fname),
                        new Claim("Image", Expert.Photo),
                        new Claim("LastName", Expert.Lname),
                        new Claim("Specialization", Expert.Specialization)
                    };
                    await userManager.AddClaimsAsync(Expert, claims);

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
                    List<Claim> claims = new() {
                                            new Claim(Database.Expert, "true"),
                        new Claim("FirstName", Expert.Fname),
                        new Claim("Image", Expert.Photo),
                        new Claim("LastName", Expert.Lname),
                        new Claim("Specialization", Expert.Specialization)
                    };
                    await userManager.AddClaimsAsync(Expert, claims);

                }
            }
        }


    }
}

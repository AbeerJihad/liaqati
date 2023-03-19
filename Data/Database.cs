namespace liaqati_master.Data
{
    public static class Database
    {

        public static List<SportsProgram> GetListOfAthleticProgram()
        {
            return new List<SportsProgram>()
            {
                //new SportsProgram
                // {
                //     Id = "1",

                //     Title = " برنامج لنحت وتفصيل الجسم في 8 أسابيع فقط",
                //     Description = "" +
                //    "<p>\n أفضل طريقة لتحصيل أفضل النتائج من جهودك في التدريب هي تطبيق عدّة طرق وأنواع من التمارين والروتينات, وذلك لتمنح جسمك حوافز جديدة باستمرار لنمو العضلات وبناء أنسجة عضلية جديدة, ولتمنع تأقلم جسمك مع التدريبات التي تمارسهاء فإذا حصل هذا التاقلم سيبطئ عملية حرق الدهون وبناء العضلات. لذا عليك تغيير روتين تدريبك باستمرارإن كنت قد اتخذت قرارك بوضع حد لجسمك المترهّل وأسلوب حياتك الخامل وتريد أن تعرف كيف تنفذ خطة تدربيبة تعطيك نتائج مذهلة في فترة قصيرة, فقد وصلت للمكان المناسب. ستمكّنك هذه الخطة من رؤية تغيّرات جذرية في انسيابية جسمك ورشاقتك ومستوى لياقتك البدنية خلال 8 أسابيع من تنفيذها</p>" +
                //    "" +
                //    "<h2>why kadljkd</h2>",
                //     Length = 8,
                //     BodyFocus = "كل الجسم",
                //     Difficulty = "3-4",
                //     Equipment = "حزام التمرين,سجاد",
                //     Price = 99,
                //     TrainingType = "القلب والأوعية الدموية ، تأثير منخفض ، تدريب القوة ، التنغيم ، اليوجا ، الحركة"
                // }

            };
        }
        public static List<Category> GetListOfCategories()
        {
            return new List<Category>() {
                                            new Category { Id="1" , Name="النظام الغذائي" },
                                            new Category { Id="2" , Name="الوجبات" },
                                            new Category { Id="3" , Name="المكملات الغذائية" },
                                            new Category { Id="4" , Name="ٍٍالاجهزة الرياضية" }

            };
        }

        public static List<User> GetListOfUsers()
        {
            return new List<User>() {
                              new User() {
                                   Id = "1",
                                   Active = false,
                                   Wieght = 120,
                                   Height = 120,
                                   Gender = Gender.Male,
                                   Photograph = "ssssssssssssssss",
                                   Cover_photo = "sssssssssssssssa",
                                   Fname = "sssssssssssssss",
                                   Lname = "sssssssssssssss",
                                   Exp_Years = 10
                               }
            };
        }
        public static List<Order> GetListOfOrders()
        {
            return new List<Order>() {
                                    new Order()
                                    {
                                        Id = "1",
                                        OrderDate = new DateTime(),
                                        UserIdResiver = 1,
                                        UserIdDelivery = 1,
                                        UserId = "1"
                                    }
            };
        }

        public static List<Achievements> GetListOfAchievements()
        {
            return new()
            {
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title ="برامج تدريب لتحسين اللياقة - التخسيس - الضخامة العضلية" , FromDate= new DateTime(1997,7,5)},
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title ="التغذية الرياضية لجميع الرياضيين" ,FromDate= new DateTime(1998,3,19) },
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title ="دورة السمنة و علاجها و الطرق الصحيحة لانقاص الوزن" ,FromDate= new DateTime(2000,11,6) },
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title =" اللياقة البدنية للأطفال" , FromDate= new DateTime(2001,8,16)},
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title ="أساسيات التغذية السليمة" ,FromDate= new DateTime(2002,6,8)},
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title ="رحلة إنقاص الوزن" , FromDate= new DateTime(2003,12,8), },
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title ="دبلومة التغذية العلاجية" ,FromDate= new DateTime(2004,11,6) },
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title ="النظام الغذائي المتقدم وتخطيط الوجبات" , FromDate= new DateTime(2005,5,13)},
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title ="التغذية من الالتهاب - النظام الغذائي المضاد للالتهابات",FromDate= new DateTime(2006,7,13) },
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title ="تدريب مدرب الصحة" ,FromDate= new DateTime(2007,12,230)},
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title ="ممارسة اليوجا قبل الولادة" , FromDate= new DateTime(2009,7,15)},
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title ="تصميم الأنظمة الغذائية والوجبات الصحية" , FromDate= new DateTime(2011,12,15)},
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title ="دبلوم معتمد دوليا في تخطيط النظام الغذائي" , FromDate= new DateTime(2013,4,16)},
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title ="شهادة دبلوم معتمد دوليا في اللياقة البدنية" , FromDate= new DateTime(2017,9,18)},
                new Achievements {Id=Guid.NewGuid().ToString() ,  Title ="diploma in fitness" , FromDate= new DateTime(2019,5,27)},

            };

        }


        public static List<Service> GetListOfOServies()
        {
            return new List<Service>() {
                        new Service
{
    Id = "1",
    Description = "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ",
    Price = 19.99,
    Title = "حمية البحر المتوسط",
    CategoryId = "1",

},
                 new Service
                 {
                     Id = "2",
                     Description = " يعتمد على تقليل الكربوهيدرات  و منع السكر المصنع و البطاطا , يتم تناول الفواكه و الخضروات و الحبوب",
                     Price = 20.99,
                     Title = "  النظام الغذائي باليو",
                     CategoryId = "1",

                 },
                new Service
                {
                    Id = "3",
                    Description = "  يعتمد على تقليل الكربوهيدرات و تناول الدهون الصحية , لا ينصح به النساءو الحوامل و كبار السن",
                    Price = 19.99,
                    Title = "   كيتو دايت ",
                    CategoryId = "1",

                },
                new Service
                {
                    Id = "4",
                    Description = "  يعتمد على تقليل الكربوهيدرات و تناول الدهون الصحية , لا ينصح به النساءو الحوامل و كبار السن",
                    Price = 19.99,
                    Title = "   كيتو دايت ",
                    CategoryId = "1",
                },
                 new Service
                 {
                     Id = "5",
                     Description = "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ",
                     Price = 19.99,
                     Title = " اختبار ",
                     CategoryId = "1",

                 },
                new Service
                 {
                     Id = "11",
                     Description = "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ",
                     Price = 19.99,
                     Title = " اختبار ",
                     CategoryId = "1",

                 },

            new Service() { Id ="21",Title = "طقم اوزان دمبل 30 كغم", Price = 20,  CategoryId ="4"},
            new Service() { Id ="22",Title = "حلقات لايف اب الاولمبية للجمباز", Price = 30, CategoryId ="4"},
            new Service() { Id ="23",Title = "مشاية كهربائية منحنية بدون محرك", Price = 1490, CategoryId ="4"},
            new Service() { Id ="24",Title = "دراجة سبينر", Price = 320,  CategoryId ="4"},
            new Service() { Id ="25",Title = "Livepro أيروبيك ستيبر ومقعد", Price = 150,  CategoryId ="4"},
            new Service() { Id ="26",Title = "سجادة Liveup للتمارين الرياضية", Price = 15,  CategoryId ="4"},
            new Service() { Id ="27",Title = "مقعد بووفليكس متعدد الوظائف", Price = 175,  CategoryId ="4"},
            new Service() { Id ="28",Title = "حبل معركة بروبانتل", Price = 69,  CategoryId ="4"},
            new Service() { Id ="29",Title = "مقعد قابل للطي قابل للتعديل للتمارين الرياضية", Price = 125, CategoryId ="4"},
            new Service() { Id ="30",Title = "مجدّف", Price = 25,  CategoryId ="4"},
            new Service() { Id ="31",Title = "زيت السمك أوميغا 3", Price = 111, CategoryId ="3"},
            new Service() { Id ="32",Title = "Muscletech, بلاتينيوم ملتي فيتامين", Price = 78, CategoryId ="3", },
            new Service() { Id ="33",Title = "Ultima Replenisher", Price = 169,  CategoryId ="3", },
            new Service() { Id ="34",Title = "زيت الكريل", Price = 169, CategoryId ="3", },
            new Service() { Id ="35",Title = "أنافيت", Price = 170,  CategoryId ="3", },
            new Service() { Id ="36",Title = "Trace Minerals Research", Price = 79, CategoryId ="3", },
            new Service() { Id ="37",Title = "BodyBio, E-Lyte", Price = 109,  CategoryId ="3", },
            new Service() { Id ="38",Title = "فيجا ، سبورت", Price = 163,  CategoryId ="3", },
            new Service() { Id ="39",Title = "مضاعف الترطيب", Price = 111,  CategoryId ="3", },
            new Service() { Id ="40",Title = "NutriBiotic", Price = 54, CategoryId ="3", },
            new Service() { Id ="41",Title = "زيت الكريل", Price = 169,  CategoryId = "3", }



            };
        }

        public static List<MealPlans> GetListOfMealPlan()
        {
            return new List<MealPlans>() {
                                    new MealPlans()

{
    Id = "1",

    //numsubscribers= 105,
    //image= "./Images/images.jfif",
   
},
new MealPlans()
{
    Id ="2",
},
new MealPlans()
{
    Id = "3",
    //numsubscribers = 105,
    //image = "./Images/images.jfif",
},
new MealPlans()
{
    Id = "4",
},
new MealPlans()
{
    Id = "5",
    //numsubscribers = 105,
    //image = "./Images/images.jfif",
}

            };
        }


        public static List<Products> GetListOfProducts()
        {
            return new List<Products>() {
            new Products() { Id ="21" , imgUrl = "/Images/Product/Dumbbell3.jfif",Discount=20 },
            new Products() { Id ="22",imgUrl = "/Images/Product/LiveupOlympic.jpg",  },
            new Products() { Id ="23", imgUrl = "/Images/Product/Curved.jpg", },
            new Products() { Id ="24", imgUrl = "/Images/Product/Spinner.jpg"},
            new Products() { Id ="25", imgUrl = "/Images/Product/Liveup.jpg", },
            new Products() { Id ="26", imgUrl = "/Images/Product/LiveupOlympic.jpg", },
            new Products() { Id = "27", imgUrl = "/Images/Product/Bowflex.jpg", },
            new Products() { Id = "28", imgUrl = "/Images/Product/Brobantle.jfif", },
            new Products() { Id = "29", imgUrl = "/Images/Product/Adjustable.jpg", },
            new Products() { Id = "30", imgUrl = "/Images/Product/rower.jpg", },
            new Products() { Id = "31", imgUrl = "/Images/Product/omega.jpg",  },
            new Products() { Id = "32", imgUrl = "/Images/Product/Muscletech.jpg",  },
            new Products() { Id = "33", imgUrl = "/Images/Product/Ultima.jpg",  },
            new Products() { Id = "34", imgUrl = "/Images/Product/krilloil.jpg",  },
            new Products() { Id = "35", imgUrl = "/Images/Product/anavite.jpg",  },
            new Products() { Id = "36", imgUrl = "/Images/Product/Trace.jpg",  },
            new Products() { Id = "37", imgUrl = "/Images/Product/BodyBio.jpg",  },
            new Products() { Id = "38", imgUrl = "/Images/Product/Vega.jpg",  },
            new Products() { Id = "39", imgUrl = "/Images/Product/HydrationMultiplier.jpg",  },
            new Products() { Id = "40", imgUrl = "/Images/Product/NutriBiotic.jpg",  },
            new Products() { Id ="41", imgUrl = "/Images/Product/krilloil.jpg"}

            };
        }



    }
}

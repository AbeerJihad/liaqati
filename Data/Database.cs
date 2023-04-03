namespace liaqati_master.Data
{
    public static class Database
    {
        public static List<SportsProgram> GetListOfAthleticProgram()
        {
            return new List<SportsProgram>()
            {

                new SportsProgram
                 {
                     Id = "100",
                     Length = 4,
                     Duration =34,
                     BodyFocus = "الجسم السفلي ",
                     Difficulty = 3,
                     Equipment = "خطوة التمرين ، الدمبل ، حزام التمرين",
                     TrainingType = "تدريب القوة",
                     Image="Images/Program/10.jpg"
                 },



                  new SportsProgram
                 {
                     Id = "101",
                     Length = 1,
                     Duration =37,
                     BodyFocus = "كل الجسم ",
                     Difficulty = 3,
                     Equipment = "الدمبل ، حزام التمرين ، الكتيل بيل ، حصيرة ، بدون معدات",
                     TrainingType = "القلب والأوعية الدموية ، تأثير منخفض ، تدريب القوة ، التنغيم ، اليوجا ، الحركة",

                        Image="Images/Program/11.jpg"

                  },



                    new SportsProgram
                 {
                     Id = "102",
                     Length = 2,
                     Duration =44,
                     BodyFocus = " كل الجسم ",
                     Difficulty = 2,
                     Equipment = "الدمبل، حصيرة",
                     TrainingType = "تدريب القوة",
                        Image="Images/Program/12.jpg"
                    },



                      new SportsProgram
                 {
                     Id = "103",
                     Length = 8,
                     Duration =35,
                     BodyFocus = "كل الجسم ",
                     Difficulty = 1,
                     Equipment = "الدمبل ",
                     TrainingType = "تدريب متقطع عالي الكثافة ، تأثير منخفض ، بيلاتيس ، تدريب القوة ، التمدد / المرونة ، القدرة على الحركة",
                        Image="Images/Program/13.jpg"
                      },




            };
        }

        public static List<Service> GetListOfOServies()
        {
            return new List<Service>()
            {

                  new Service
                {
                    Id = "100",
                    Description="تم تصميم هذا التحدي لمدة 5 أيام للقوة والقلب والشد لتحسين قوة الجسم بالكامل والقدرة على التحمل وإعادة إشعال الحافز لروتين لياقة بدنية ثابت.",
                    Price=350,
                    Title="سلسلة مُدربي التحدي لمدة 5 أيام: تناغم مع إيريكا",
                    CategoryId = "1",

                },
                    new Service
                {
                    Id = "101",
                     Title="تحدي للياقة البدنية لمدة 5 أيام مجانًا",
                     Description="لبدء هذا العام بشكل صحيح ، ننشر فيديو تمرين مجاني جديد كل صباح للأسبوع الأول من شهر كانون الثاني (يناير) ؛ خمسة أيام من التدريبات المكثفة ، ويوم تعافي واحد ، وتأمل يوم راحة. نحن متحمسون جدًا لأن نكون قادرين على تقديم هذا التحدي الجديد ، ونحن متحمسون حقًا لأننا تمكنا من بنائه مع فريقنا. سيكون أسبوعًا ممتعًا!",
                     Price=100,
                    CategoryId = "5",

                },
                      new Service
                {
                    Id = "102",
                   Title="3 تمارين في الأسبوع لمدة أسبوعين",
                     Description="تحدي تجريب أسبوع مصمم للأشخاص الذين يريدون فقط ثلاثة (مطلوب) أيام تمرين في الأسبوع. سواء كنت مشغولاً للغاية لأكثر من ثلاثة تمارين في الأسبوع ، أو كنت ترغب في استكمال أنواع أخرى من اللياقة البدنية (المشي ، والسباحة ، وما إلى ذلك) بمقاطع فيديو للتمرين في المنزل ، فإن هذا التحدي يهدف إلى المساعدة في دعم اللياقة البدنية الشاملة. الروتين الذي يناسب الجدول الزمني والسرعة التي تريدها. توقع مزيجًا من رفع الأثقال والتدريب المتقطع عالي الكثافة (التدريب المتقطع عالي الكثافة) الذي سيختبر قدرتك على التحمل وصحة القلب والأوعية الدموية والقوة.",
                     Price=200,
                                         CategoryId = "5",

                 },

                
                        new Service
                {
                    Id = "103",
                    Title="برنامج لمدة 8 أسابيع لبدء روتين لياقتك البدنية",
                       Description="هذا برنامج صديق للمبتدئين مدته 8 أسابيع مصمم لبناء قاعدة القوة الكلية للجسم وتحمل القلب والأوعية الدموية واللياقة البدنية الشاملة.",
                       Price=450,
                    CategoryId = "5",

                },

                new Service
                {
                    Id = "1",
                    Description =
                        "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ",
                    Price = 19.99,
                    Title = "حمية البحر المتوسط",
                    CategoryId = "1",

                },
                new Service
                {
                    Id = "2",
                    Description =
                        " يعتمد على تقليل الكربوهيدرات  و منع السكر المصنع و البطاطا , يتم تناول الفواكه و الخضروات و الحبوب",
                    Price = 20.99,
                    Title = "  النظام الغذائي باليو",
                    CategoryId = "1",
                },
                new Service
                {
                    Id = "3",
                    Description =
                        "  يعتمد على تقليل الكربوهيدرات و تناول الدهون الصحية , لا ينصح به النساءو الحوامل و كبار السن",
                    Price = 19.99,
                    Title = "   كيتو دايت ",
                    CategoryId = "1",
                },
                new Service
                {
                    Id = "4",
                    Description =
                        "  يعتمد على تقليل الكربوهيدرات و تناول الدهون الصحية , لا ينصح به النساءو الحوامل و كبار السن",
                    Price = 19.99,
                    Title = "   كيتو دايت ",
                    CategoryId = "1",
                },
                new Service
                {
                    Id = "5",
                    Description =
                        "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ",
                    Price = 19.99,
                    Title = " اختبار ",
                    CategoryId = "1",
                },
                new Service
                {
                    Id = "11",
                    Description =
                        "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ",
                    Price = 19.99,
                    Title = " اختبار ",
                    CategoryId = "1",
                },
                new Service()
                {
                    Id = "21",
                    Title = "طقم اوزان دمبل 30 كغم",
                    Price = 20,
                    CategoryId = "4",
                    Description=""
                },
                new Service()
                {
                    Id = "22",
                    Title = "حلقات لايف اب الاولمبية للجمباز",
                    Price = 30,
                    CategoryId = "4",
                    Description=""
                },
                new Service()
                {
                    Id = "23",
                    Title = "مشاية كهربائية منحنية بدون محرك",
                    Price = 1490,
                    CategoryId = "4",
                    Description=""
                },
                new Service() { Id = "24", Title = "دراجة سبينر", Price = 320, CategoryId = "4" ,Description=""},
                new Service()
                {
                    Id = "25",
                    Title = "Livepro أيروبيك ستيبر ومقعد",
                    Price = 150,
                    CategoryId = "4",
                    Description=""
                },
                new Service()
                {
                    Id = "26",
                    Title = "سجادة Liveup للتمارين الرياضية",
                    Price = 15,
                    CategoryId = "4",
                    Description=""
                },
                new Service()
                {
                    Id = "27",
                    Title = "مقعد بووفليكس متعدد الوظائف",
                    Price = 175,
                    CategoryId = "4",
                    Description=""
                },
                new Service()
                {
                    Id = "28",
                    Title = "حبل معركة بروبانتل",
                    Price = 69,
                    CategoryId = "4",
                    Description=""
                },
                new Service()
                {
                    Id = "29",
                    Title = "مقعد قابل للطي قابل للتعديل للتمارين الرياضية",
                    Price = 125,
                    CategoryId = "4",
                    Description=""
                },
                new Service() { Id = "30", Title = "مجدّف", Price = 25, CategoryId = "4" ,Description=""},
                new Service()
                {
                    Id = "31",
                    Title = "زيت السمك أوميغا 3",
                    Price = 111,
                    CategoryId = "3",
                    Description=""
                },
                new Service()
                {
                    Id = "32",
                    Title = "Muscletech, بلاتينيوم ملتي فيتامين",
                    Price = 78,
                    CategoryId = "3",
                    Description=""
                },
                new Service()
                {
                    Id = "33",
                    Title = "Ultima Replenisher",
                    Price = 169,
                    CategoryId = "3",
                    Description=""
                },
                new Service() { Id = "34", Title = "زيت الكريل", Price = 169, CategoryId = "3", Description=""},
                new Service() { Id = "35", Title = "أنافيت", Price = 170, CategoryId = "3", Description=""},
                new Service()
                {
                    Id = "36",
                    Title = "Trace Minerals Research",
                    Price = 79,
                    CategoryId = "3",
                    Description=""
                },
                new Service()
                {
                    Id = "37",
                    Title = "BodyBio, E-Lyte",
                    Price = 109,
                    CategoryId = "3",
                    Description=""
                },
                new Service() { Id = "38", Title = "فيجا ، سبورت", Price = 163, CategoryId = "3", Description=""},
                new Service()
                {
                    Id = "39",
                    Title = "مضاعف الترطيب",
                    Price = 111,
                    CategoryId = "3",
                    Description=""
                },
                new Service() { Id = "40", Title = "NutriBiotic", Price = 54, CategoryId = "3", Description=""},
                new Service() { Id = "41", Title = "زيت الكريل", Price = 169, CategoryId = "3",Description="" },
               


            };
        }



        public static List<Category> GetListOfCategories()
        {
            return new List<Category>()
            {
                new Category { Id = "1", Name = "النظام الغذائي" },
                new Category { Id = "2", Name = "الوجبات" },
                new Category { Id = "3", Name = "المكملات الغذائية" },
                new Category { Id = "4", Name = "الاجهزة الرياضية" },
                new Category { Id = "5", Name = " النظام الرياضي" }
            };
        }

        public static List<User> GetListOfUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    Id = "1",
                    Active = false,
                    Wieght = 120,
                    Height = 120,
                    Gender = Gender.Male,
                    Photo = "ssssssssssssssss",
                    Cover_photo = "sssssssssssssssa",
                    Fname = "sssssssssssssss",
                    Lname = "sssssssssssssss",
                    Exp_Years = 10
                }
            };
        }
        public static List<Order> GetListOfOrders()
        {
            return new List<Order>()
            {
                new Order()
                {
                    Id = "1",
                    OrderDate = new  DateTime(year:2021,month:5,1 ),
                    UserIdResiver = 1,
                    UserIdDelivery = 1,
                    UserId = "1",
                    TotalPrice=200,
                }, new Order()
                {
                    Id = "2",
                    OrderDate = new DateTime(year:2021,month:5,1 ),
                    UserIdResiver = 1,
                    UserIdDelivery = 1,
                    UserId = "1"
                } ,new Order()
                {
                    Id = "3",
                    OrderDate = new DateTime(year:2021,month:5,1 ),
                    UserIdResiver = 1,
                    UserIdDelivery = 1,
                    UserId = "1"
                }
            };
        }
        public static List<Order_Details> GetListOfOrdersDetails()
        {
            return new List<Order_Details>()
            {
                new Order_Details(){Id = "1",OrderId="1",Price=100,RateId=1,Quantity=2,ServiceId="21"},
                new Order_Details(){Id = "2",OrderId="1",Price=100,RateId=1,Quantity=2,ServiceId="21"},
                new Order_Details(){Id = "3",OrderId="1",Price=100,RateId=1,Quantity=2 , ServiceId = "21"},
                new Order_Details(){Id = "4",OrderId="2",Price=100,RateId=1,Quantity=7  , ServiceId="31"},
                new Order_Details(){Id = "5",OrderId="2",Price=100,RateId=1,Quantity=5, ServiceId = "31"},
                new Order_Details(){Id = "6",OrderId="2",Price=100,RateId=1,Quantity=3, ServiceId = "24"},
                new Order_Details(){Id = "7",OrderId="3",Price=100,RateId=1,Quantity=2 , ServiceId = "23"},
                new Order_Details(){Id = "8",OrderId="3",Price=100,RateId=1,Quantity=4, ServiceId = "23"},
                new Order_Details(){Id = "9",OrderId="3",Price=100,RateId=1,Quantity = 10 , ServiceId = "23"},
                new Order_Details(){Id = "10",OrderId="1",Price=100,RateId=1,Quantity=2,ServiceId="23"},
                new Order_Details(){Id = "11",OrderId="1",Price=100,RateId=1,Quantity=2,ServiceId="23"},
                new Order_Details(){Id = "12",OrderId="1",Price=100,RateId=1,Quantity=2 , ServiceId = "23"},
                new Order_Details(){Id = "13",OrderId="2",Price=100,RateId=1,Quantity=7  , ServiceId="24"},
                new Order_Details(){Id = "14",OrderId="2",Price=100,RateId=1,Quantity=5, ServiceId = "24"},
                new Order_Details(){Id = "15",OrderId="2",Price=100,RateId=1,Quantity=3, ServiceId = "24"},
                new Order_Details(){Id = "16",OrderId="3",Price=100,RateId=1,Quantity=2 , ServiceId = "24"},
                new Order_Details(){Id = "17",OrderId="3",Price=100,RateId=1,Quantity=4, ServiceId = "24"},
                new Order_Details(){Id = "18",OrderId="3",Price=100,RateId=1,Quantity = 10 , ServiceId = "24"},
                new Order_Details(){Id = "19",OrderId="1",Price=100,RateId=1,Quantity=2,ServiceId="31"},
                new Order_Details(){Id = "20",OrderId="1",Price=100,RateId=1,Quantity=2,ServiceId="31"},
                new Order_Details(){Id = "21",OrderId="1",Price=100,RateId=1,Quantity=2 , ServiceId = "31"},
                new Order_Details(){Id = "22",OrderId="2",Price=100,RateId=1,Quantity=7  , ServiceId="31"},
                new Order_Details(){Id = "23",OrderId="2",Price=100,RateId=1,Quantity=5, ServiceId = "32"},
                new Order_Details(){Id = "24",OrderId="2",Price=100,RateId=1,Quantity=3, ServiceId = "32"},
                new Order_Details(){Id = "25",OrderId="3",Price=100,RateId=1,Quantity=2 , ServiceId = "32"},
                new Order_Details(){Id = "26",OrderId="3",Price=100,RateId=1,Quantity=4, ServiceId = "32"},
                new Order_Details(){Id = "27",OrderId="3",Price=100,RateId=1,Quantity = 10 , ServiceId = "32"},
            };
        }
        public static List<Achievements> GetListOfAchievements()
        {
            return new()
            {
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "برامج تدريب لتحسين اللياقة - التخسيس - الضخامة العضلية",
                    FromDate = new DateTime(1997, 7, 5)
                },
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "التغذية الرياضية لجميع الرياضيين",
                    FromDate = new DateTime(1998, 3, 19)
                },
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "دورة السمنة و علاجها و الطرق الصحيحة لانقاص الوزن",
                    FromDate = new DateTime(2000, 11, 6)
                },
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = " اللياقة البدنية للأطفال",
                    FromDate = new DateTime(2001, 8, 16)
                },
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "أساسيات التغذية السليمة",
                    FromDate = new DateTime(2002, 6, 8)
                },
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "رحلة إنقاص الوزن",
                    FromDate = new DateTime(2003, 12, 8),
                },
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "دبلومة التغذية العلاجية",
                    FromDate = new DateTime(2004, 11, 6)
                },
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "النظام الغذائي المتقدم وتخطيط الوجبات",
                    FromDate = new DateTime(2005, 5, 13)
                },
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "التغذية من الالتهاب - النظام الغذائي المضاد للالتهابات",
                    FromDate = new DateTime(2006, 7, 13)
                },
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "تدريب مدرب الصحة",
                    FromDate = new DateTime(2007, 12, 230)
                },
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "ممارسة اليوجا قبل الولادة",
                    FromDate = new DateTime(2009, 7, 15)
                },
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "تصميم الأنظمة الغذائية والوجبات الصحية",
                    FromDate = new DateTime(2011, 12, 15)
                },
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "دبلوم معتمد دوليا في تخطيط النظام الغذائي",
                    FromDate = new DateTime(2013, 4, 16)
                },
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "شهادة دبلوم معتمد دوليا في اللياقة البدنية",
                    FromDate = new DateTime(2017, 9, 18)
                },
                new Achievements
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "diploma in fitness",
                    FromDate = new DateTime(2019, 5, 27)
                },
            };
        }
        public static List<MealPlans> GetListOfMealPlan()
        {
            return new List<MealPlans>()
            {
                new MealPlans()
                {
                    Id = "1",
                    Numsubscribers= 105,
                    Length= 1,
                    DietaryType="اكلة اللحوم",
                    MealType="الإفطار والغداء والعشاء والوجبات الخفيفة\r\n",
                    AvgRecipeTime=13,
                    Image= "./Images/MealPlan/1.jpg",

                },
                new MealPlans()
                {
                    Id = "2",
                    Numsubscribers= 105,
                    Length= 1,
                    DietaryType="اكلة اللحوم",
                    MealType="الإفطار والغداء والعشاء والوجبات الخفيفة\r\n",
                    AvgRecipeTime=13,
                    Image= "./Images/MealPlan/2.jpg",

                },
                new MealPlans()
                {
                    Id = "3",
                    Numsubscribers= 105,
                    Length= 1,
                    DietaryType="اكلة اللحوم",
                    MealType="الإفطار والغداء والعشاء والوجبات الخفيفة\r\n",
                    AvgRecipeTime=20,
                    Image= "./Images/MealPlan/3.jpg",

                },
                new MealPlans()
                {
                    Id = "4",
                    Numsubscribers= 105,
                    Length= 1,
                    DietaryType="اكلة اللحوم",
                    MealType="الإفطار والغداء والعشاء والوجبات الخفيفة\r\n",
                    AvgRecipeTime=20,
                    Image= "./Images/MealPlan/4.jpg",

                },

            };
        }
        public static List<Product> GetListOfProducts()
        {
            return new List<Product>()
            {
                new Product(){Id = "21",imgUrl = "/Images/Product/Dumbbell3.jfif",Discount = 20,},
                new Product() { Id = "22", imgUrl = "/Images/Product/LiveupOlympic.jpg", },
                new Product() { Id = "23", imgUrl = "/Images/Product/Curved.jpg", },
                new Product() { Id = "24", imgUrl = "/Images/Product/Spinner.jpg" },
                new Product() { Id = "25", imgUrl = "/Images/Product/Liveup.jpg", },
                new Product() { Id = "26", imgUrl = "/Images/Product/LiveupOlympic.jpg", },
                new Product() { Id = "27", imgUrl = "/Images/Product/Bowflex.jpg", },
                new Product() { Id = "28", imgUrl = "/Images/Product/Brobantle.jfif", },
                new Product() { Id = "29", imgUrl = "/Images/Product/Adjustable.jpg", },
                new Product() { Id = "30", imgUrl = "/Images/Product/rower.jpg", },
                new Product() { Id = "31", imgUrl = "/Images/Product/omega.jpg", },
                new Product() { Id = "32", imgUrl = "/Images/Product/Muscletech.jpg", },
                new Product() { Id = "33", imgUrl = "/Images/Product/Ultima.jpg", },
                new Product() { Id = "34", imgUrl = "/Images/Product/krilloil.jpg", },
                new Product() { Id = "35", imgUrl = "/Images/Product/anavite.jpg", },
                new Product() { Id = "36", imgUrl = "/Images/Product/Trace.jpg", },
                new Product() { Id = "37", imgUrl = "/Images/Product/BodyBio.jpg", },
                new Product() { Id = "38", imgUrl = "/Images/Product/Vega.jpg", },
                new Product() { Id = "39", imgUrl = "/Images/Product/HydrationMultiplier.jpg", },
                new Product() { Id = "40", imgUrl = "/Images/Product/NutriBiotic.jpg", },
                new Product() { Id = "41", imgUrl = "/Images/Product/krilloil.jpg" }
            };
        }


        public static List<Exercise> GetListOfExercise()
        {
            return new List<Exercise>()
            {
             new Exercise(){Id="1" ,TraningType="تدريب القوة" ,BurnEstimate="50-250", Title="اليوجا الصباحية للجسم بالكامل",Price=0, BodyFocus="الجسم بالكامل" , Detail="هذا التدفق هو واحد من المفضلة. عندما أستيقظ في الصباح ، أحب أن أبدأ يومي بتمديدات روتينية من شأنها أن تجعل دمي يتدفق ، وطاقي ، وتضبط نغمة اليوم. هذه الممارسة ستجعلك تتعرق وتساعد " +"جسمك على تخفيف الضغط في نفس الوقت. تخلق أنماط الحركة ذاكرة حسية يمكننا البناء عليها. بدءًا من نمط التنفس ، تهدف كل حركة إلى مطابقة كل شهيق أو زفير لتشجيع التنفس العميق الذي يعزز الشعور بالتوتر ، ويزيد من مستوى الطاقة والاسترخاء ، ويثبت ضغط الدم. إذا ركزت على أنفاسك ، فسوف يهدأ عقلك. فيما يلي بعض إشارات المحاذاة التي يجب وضعها في الاعتبار للسلامة في Low Lunge:\r\n\r\nابدأ في اندفاع العداء ، والساق اليمنى للأمام مع الركبة فوق الكاحل والركبة اليسرى على الأرض مع وضع الجزء العلوي من قدمك على السجادة" +
             ". ارفع الجذع ببطء وضع يديك برفق على الفخذ الأيمن. تميل الوركين إلى الأمام قليلاً ،" +
             " مع إبقاء الركبة اليمنى خلف أصابع القدم ، والشعور بالتمدد في ثني الورك الأيسر." +
             "" +
             " امسك هنا ، أو لتمتد أعمق ، ارفع الذراعين فوق الرأس ، والعضلة ذات الرأسين من الأذنين. " +
             "استمر لمدة 30 ثانية على الأقل ، ثم كرر على الجانب الآخر. تتضمن عضلات الجسم المنخفضة المستهدفة في هذا" +
             " التسلسل أوتار الركبة ، وثني الورك ، والرباعية ، والألوية. في كل مرة نتنقل فيها عبر نمط الحركة" +
             " ، سيكون هناك موقف أو وضعان مضافان إلى التسلسل. التكرار مع كل الجسم للانفتاح على كل شكل تدريجيًا.",
             Difficulty=3 , Duration=27,Image="Images/Exercise/31.jpg",Video="https://www.youtube.com/watch?v=w5y3Zl1F5Vs", Equipments="حصيرة ، معدات اليوجا"},



             new Exercise(){Id="2",TraningType = "القلب والأوعية الدموية ، تأثير منخفض ، تدريب القوة ، التنغيم ، اليوجا ، الحركة",BurnEstimate="50-250",Title="تمارين تقوية الجسم بالكامل وتمارين القلب",Price=0, BodyFocus="الجسم بالكامل" , Detail="إذا كنت تريد ممارسة تمرينات رياضية فعالة في أقل من 25 دقيقة ، فلا داعي لمزيد من البحث. هذا مزيج قصير ولطيف بين نمطي تدريب مهمين: تدريب القوة وتمارين القلب والأوعية الدموية. يتم تقديم تعديلات عالية ومنخفضة التأثير حتى تتمكن من مقابلة جسمك تمامًا في مكانه.                        عندما يتعلق الأمر بالحصول على أقصى درجات \"الضجة\" لوقتك ، يمكن أن تكون قوة الاقتران وتمارين القلب فعالة للغاية. يسمح لنا تدريب القوة ببناء العضلات الخالية من الدهون بينما تحافظ تمارين القلب والأوعية الدموية على ارتفاع معدل ضربات القلب. يعملان معًا على تعزيز عملية التمثيل الغذائي وإطلاق الطاقة لتغذية يومك!\r\n\r\nكنت مؤخرًا أحضر فصلًا لركوب الدراجات حيث قال المدرب ، \"ما هي أفضل طريقة للاحتفال بجسدك من الشعور بإطلاق الطاقة والقوة التي يحملها جسمك؟\" لا يمكن اقبل المزيد. هذا التمرين هو النوع الذي يبدو وكأنه احتفال بما يمكن أن يفعله جسمك. دون أن تكون شديدة أو معتدلة للغاية ، فإنها تهبط في المنتصف تمامًا \"للاحتفال\" التمكيني والحيوي ، إذا رغبت في ذلك.",
                 Difficulty=3 , Duration=23,Image="Images/Exercise/32.jpg",Video="https://www.youtube.com/watch?v=R58oVgVgRlc"  , Equipments="حصيرة ، دمبل"},
            new Exercise(){Id="3",TraningType="تدريب القوة",BurnEstimate="50-250" ,Title="مجموعات القوة المركبة للجزء العلوي من الجسم",Price=0, BodyFocus="الجزء العلوي من الجسم" , Detail="أولاً ، سنركز على الصدر ، بدءًا من مكابس الأرضية ثم الانتقال بسرعة إلى ذبابة الصدر والانتهاء بضغطة سحق. بعد مجموعتين من تمارين الصدر ، سننتقل إلى الخلف ، بدءًا من الصفوف المنحنية ، والانتقال إلى الذباب العكسي ، والانتهاء من صف yates. مجموعتنا التالية سوف تستهدف الذراعين ، في المقام الأول العضلة ثلاثية الرؤوس والعضلة ذات الرأسين. بالنسبة لمجموعات الترايسبس لدينا ، نحتاج فقط إلى دمبل واحد. سنبدأ المجموعات بضغطة دمبل مفردة بقبضة قريبة ، وننتقل إلى كسارة جمجمة دمبل واحدة ، ثم ننتقل إلى تمديدات ثلاثية الرؤوس العلوية. (سوف تحترق عضلاتك ثلاثية الرؤوس ، لول). مجموعتنا التالية هي إحدى الطرق المفضلة لتدريب العضلة ذات الرأسين. سنستخدم المقاييس المتساوية لدفع العضلة ذات الرأسين هنا. تمريننا الأول هو ما أحب أن أسميه تجعيد الشعر أحادي الذراع ؛ سنقوم بعمل كل ذراع على حدة مع تلك قبل الانتهاء من تمارين العضلة ذات الرأسين القياسية. هذا المزيج يعمل دائمًا مع العضلة ذات الرأسين! في مجموعتنا النهائية ، سنركز على أكتافنا. سنبدأ العمل بضغط الكتف القياسي ، والانتقال إلى صفوفنا المستقيمة ، وإنهاء المجموعة مع صف دلتا الخلفي الذي يستهدف عضلات الدالية الصغيرة - مما يجعل هذه الطريقة المثالية لإنهاء تمرين الجزء العلوي من الجسم.",
                Difficulty=4 , Duration=37,Image="Images/Exercise/34.jpg",Video="https://www.youtube.com/watch?v=fPlN4amOMY8" ,  Equipments="دمبل"},
             new Exercise(){Id="4",TraningType="القلب والأوعية الدموية ، تأثير منخفض ، تدريب القوة ، التنغيم ، اليوجا ، الحركة" ,BurnEstimate="50-250",Title="مجموعة القلب والقوة",Price=0, BodyFocus="الجسم بالكامل" , Detail="أولاً ، سنركز على الصدر ، بدءًا من مكابس الأرضية ثم الانتقال بسرعة إلى ذبابة الصدر والانتهاء بضغطة سحق. بعد مجموعتين من تمارين الصدر ، سننتقل إلى الخلف ، بدءًا من الصفوف المنحنية ، والانتقال إلى الذباب العكسي ، والانتهاء من صف yates. مجموعتنا التالية سوف تستهدف الذراعين ، في المقام الأول العضلة ثلاثية الرؤوس والعضلة ذات الرأسين. بالنسبة لمجموعات الترايسبس لدينا ، نحتاج فقط إلى دمبل واحد. سنبدأ المجموعات بضغطة دمبل مفردة بقبضة قريبة ، وننتقل إلى كسارة جمجمة دمبل واحدة ، ثم ننتقل إلى تمديدات ثلاثية الرؤوس العلوية. (سوف تحترق عضلاتك ثلاثية الرؤوس ، لول). مجموعتنا التالية هي إحدى الطرق المفضلة لتدريب العضلة ذات الرأسين. سنستخدم المقاييس المتساوية لدفع العضلة ذات الرأسين هنا. تمريننا الأول هو ما أحب أن أسميه تجعيد الشعر أحادي الذراع ؛ سنقوم بعمل كل ذراع على حدة مع تلك قبل الانتهاء من تمارين العضلة ذات الرأسين القياسية. هذا المزيج يعمل دائمًا مع العضلة ذات الرأسين! في مجموعتنا النهائية ، سنركز على أكتافنا. سنبدأ العمل بضغط الكتف القياسي ، والانتقال إلى صفوفنا المستقيمة ، وإنهاء المجموعة مع صف دلتا الخلفي الذي يستهدف عضلات الدالية الصغيرة - مما يجعل هذه الطريقة المثالية لإنهاء تمرين الجزء العلوي من الجسم. ",
                 Difficulty=4 , Duration=23,Image="Images/Exercise/35.jpg",Video="https://www.youtube.com/watch?v=d8QcqQA0zIQ", Equipments="حصيرة ، دمبل" },
             new Exercise(){Id="5",TraningType="تدريب القوة",BurnEstimate="50-250" ,Title="دوائر القوة الأساسية السريعة و الجوهر",Price=0, BodyFocus="جوهر" , Detail="يعد هذا التمرين القصير الذي يركز على النواة إضافة رائعة لروتين الجسم السفلي أو العلوي أو الكلي - ولكنه أيضًا خيار رائع كتمرين مستقل لحركتك الأساسية في اليوم. استخدم الإحماء أحادي الدورة لتهيئة عضلاتك الأساسية جسديًا للدوائر الصعبة ولكن القابلة للتكيف التي تليها ، ولكن ركز أيضًا على التدفق ببطء خلال كل تمرين لتنشيط اتصال العقل والعضلات لتوظيف العضلات بكفاءة.\r\n\r\n\r\n\r\n\r\nتحتوي كل دائرة على تمارين تجمع بين الإمساك المتساوي القياس وأنماط الحركة الديناميكية ولكن المتحكم فيها والتركيز على الاستقرار الأساسي. هذه التمارين لن تقوي فقط عضلات البطن (التي تشمل عضلات البطن ، الألوية ، عضلات الفخذ ، وعضلات الظهر السفلية) مع حركات الانثناء / الطحن التقليدية ، بل ستعمل أيضًا على تحسين مشاركة عضلات الجسم الكلية وتكامل الحركة (التدفق).\r\n\r\nلاحظ أنه لا يوجد سوى عدد قليل من التمارين المتعلقة بلوح في هذا التمرين ؛ لذلك ، إذا كانت لديك مخاوف من ألم الرسغ أثناء تمارين اللوح / وضعية الانبطاح ، فقد يكون هذا الروتين خيارًا رائعًا للاحتفاظ به في مجموعتك من أجل إجراءات الانتقال الأساسية المستقبلية. من الاعتبارات المهمة للجميع الحفاظ على ثنية طفيفة في الحوض أثناء تمارين وضعية الاستلقاء (الوجه لأعلى) والمنبطحة (الوجه لأسفل / اللوح الخشبي). على سبيل المثال ، أثناء الجزء الميت من تسلسل التنشيط بالإضافة إلى تمرين لوح الساعد في الدائرة رقم 1 ، تخيل أنك تقوم بإدخال عظام الفخذ إلى ضلوعك - قم بإمالة الجزء العلوي من عظام الحوض قليلاً إلى الأعلى والعودة باتجاه الجزء السفلي من القفص الصدري الخاص بك.\r\n\r\nفيما يلي بعض النصائح الإضافية لجعل هذا الروتين تجربة مُرضية لك:\r\n\r\nتشمل التعديلات لجميع التمارين تقليل نطاق الحركة و / أو ثني ركبتيك (تقصير الرافعة) لأي حركات تتضمن اختلافات في تمديد الساق.\r\nلاحظ التمارين الأكثر صعوبة بالنسبة لك وحدد الاختلافات في نطاقات الحركة والقوة وعدد التكرارات للتمارين ذات التركيز الأحادي (مثل v-ups المائلة). سيساعدك الانتباه إلى أكثر الاختلافات دقة في توجيه تركيزك أثناء المحاولات المستقبلية في هذا التمرين.\r\nلا تتردد في تكرار دائرة التبريد القصيرة لتمديد ممتد أو إضافة الامتدادات الخاصة بك لمساعدتك على العودة إلى حالة الاسترخاء والحيوية. يجب أن تشعر كما لو أن عضلاتك \"تعمل\" خلال هذا الروتين ولكن لا تزال تنتهي بعقلية \"جاهزة للتعامل مع أي شيء قادم\".\r\nيتمتع!",
                 Difficulty=3 , Duration=19,Image="Images/Exercise/36.jpg",Video="https://www.youtube.com/watch?v=B5ZZqBslKU0" , Equipments="حصيرة"},
             new Exercise(){Id="6",TraningType="القلب والأوعية الدموية ، تأثير منخفض ، تدريب القوة ، التنغيم ، اليوجا ، الحركة",BurnEstimate="50-250" ,Title="دارات تقوية الجسم الكلي مع عمل التوازن",Price=0, BodyFocus="الجسم بالكامل" , Detail="\r\nتساعد التدريبات أحادية الجانب على تعزيز المشاركة الأساسية ، وبالتالي تحسين الأساس الذي تبدأ منه كل الحركات.\r\nتعمل عضلاتك معًا بشكل تآزري لتقوية السلسلة الحركية بأكملها ، مما يقلل من فرص السقوط أو العثرات الضارة المحتملة أثناء الأنشطة المعتادة للحياة اليومية.\r\nيمكن أن يساعدك العمل المتوازن في تحديد مناطق الضعف والكتل المحتملة نحو تحسين الأداء الرياضي وكذلك تحسين التنسيق لأنماط الحركة المتقدمة والتمارين التي تحركها القوة.\r\nالتدريبات مع تحديات التوازن تعمل على تحسين الاتصال بين العقل والجسم. يؤدي هذا الاتصال المعزز إلى زيادة القدرة على التحمل الذهني والفعالية الذاتية اللازمة لإكمال التدريبات الصعبة.\r\nتوفر مثل هذه التدريبات استراحة من البلى من التدريب على التأثير وتتحدى الدماغ لطرق بديلة لمعالجة وعي العقل والجسم من أجل نهج شامل للياقة البدنية.\r\nكل حركة في هذا التمرين لها درجات متفاوتة من التوازن في العمل. أثناء دورات القوة ، ستكمل كل تمرين لمدة 45 ثانية ، وهي فترة زمنية كافية لتتعرف تمامًا على كل حركة. تؤدي إضافة درجة صغيرة من التوازن أثناء هذه الحركات التي تركز على القوة إلى زيادة وقت العضلات تحت التوتر للمساعدة في بناء القوة. بمجرد الانتقال إلى موازنة قطاعات العمل ، استفد من تنشيط العضلات الذي حدث أثناء دوائر القوة لتحقيق أقصى استفادة من الفواصل الزمنية التي تبلغ دقيقة واحدة والتركيز على الاستقرار.\r\n\r\nسأعترف ، لقد استمتعت تمامًا بالحركة بسرعة أبطأ من التدريبات المعتادة مع هذه الجلسة التي تركز على التوازن. لبضعة أيام بعد ذلك ، لاحظت أن العديد من العضلات شعرت بـ \"الاستيقاظ\" مع نوع صحي جيد من القرحة التي سمحت لي بمعرفة أنني كنت أهمل مجموعات عضلية معينة وطرق التدريب. خذ وقتك مع كل حركة واستمع إلى الملاحظات التي يقدمها لك جسمك. استمتع!",
                 Difficulty=3 , Duration=45,Image="Images/Exercise/37.jpg",Video="https://www.youtube.com/watch?v=UzAFN61CiVQ" , Equipments="حصيرة"},
             new Exercise(){Id="7",TraningType="تدريب القوة",BurnEstimate="50-250" ,Title="مجموعة سريعة من تمارين القلب والقوة و الجوهر  لكامل الجسم",Price=0, BodyFocus="الجسم بالكامل" , Detail="في منتصف عام 2022 ، قمت بتصوير تمرين بدا أن عددًا كبيرًا منكم يحبه حقًا. كان قسم التعليقات مليئًا بطلبات لتصوير المزيد مثله ، وعلى الرغم من أنني كنت أمتلك مجموعة من التدريبات الأخرى المطلوبة للحصول عليها أولاً ، إلا أنني لم أنس هذا التمرين (بفضل Kelli لتذكيري) وقمت ببناء علامة تجارية جديدة نسخة منه مع جميع التدريبات الجديدة. بالنسبة لأولئك منكم الذين لم يجربوا النسخة الأصلية ، يمكنك إلقاء نظرة هنا أو - بل أفضل - جرب كلاهما وأخبرني ما إذا كان هذا الإصدار الجديد يتوافق مع نفس المعيار.\r\n\r\n\r\n\r\n\r\nسواء كنت قد جربت الإصدار الأصلي أم لا ، لا يهم ، حيث إن كلاهما تمرين مستقل مصمم لروتين كامل للجسم متوازن. يحتوي هذا التمرين الذي يستغرق 26 دقيقة على كل شيء: الإحماء ، والتهدئة ، وفترات HIIT للقلب ، ومجموعات القوة ، والتمارين الأساسية ، كل ذلك في فاصل زمني سريع بأسلوب Tabata للحفاظ على هذا التمرين سريعًا.\r\n\r\nتم بناء كل مجموعة من المجموعات الأربع في هذا الروتين بنفس الطريقة تمامًا ولكن مع تمارين فريدة في كل مرة. تتكون المجموعات من تمرين HIIT من أجل انفجار القلب ، يليه تمرين قوة متعدد السلاسل لزيادة إجهاد العضلات ومكاسب القوة ، ثم ننهيها بتمرين أساسي للمتعة فقط. على الرغم من أن هذا التمرين قصير ، إلا أنه يحزم لك بالتأكيد ، خاصة إذا كنت تتحدى نفسك في مجموعات القوة.\r\n\r\nأيضًا ، إذا كنت تريد تحديًا إضافيًا لكامل الجسم ، فحاول القيام بكل من هذين التمرينين معًا أو كل منهما مرتين خلال تمرين كامل للجسم لمدة ساعة تقريبًا.",
                 Difficulty=4 , Duration=26,Image="Images/Exercise/38.jpg",Video="https://www.youtube.com/watch?v=3xR8ZKVALwo", Equipments = "حصيرة ، دمبل  ، بدون معدات "},
             new Exercise(){Id="8" , TraningType = "تدريب متقطع عالي الكثافة ، تأثير منخفض ، بيلاتيس ، تدريب القوة ، التمدد / المرونة ، القدرة على الحركة" ,BurnEstimate="50-250" ,Title="تمرين الجسم الكلي السريع - 10 أو 15 دقيقة تختارها",Price=0, BodyFocus="الجسم بالكامل ", Detail="في تمرين اليوم نركز على السرعة. تم تصميم هذا التمرين القصير ولكن الفعال ليوفر لك تمرينًا جيدًا في أقصر وقت ممكن لتلك الأيام التي ربما لم تكن قد مارستها فيها على الإطلاق. لقد صممت هذا التمرين بعد نوبة أخيرة من العمل المكثف ومتطلبات الحياة التي ضربت في نفس الوقت ، مما يجعل التمرين لمدة 20 دقيقة يبدو كثيرًا.\r\n\r\nلقد صممت هذا الروتين عن قصد لاستخدامه بسهولة في تخصيصين مختلفين للوقت: إصدار سريع يأخذك خلال مقطع فيديو التمرين الكامل هذا ويبلغ أقصى حد له 15 دقيقة ، وإصدار فائق السرعة يأخذك خلال جزء \"التمرين\" لـ نصف الوقت مع قطع الطول الإجمالي إلى حوالي 10 دقائق.\r\n\r\nيتم إجراء كل هذا الروتين بنفس بنية الفاصل الزمني 20 تشغيل و 10 إيقاف لإبقائه سريعًا وبسيطًا. لقد قمت بتضمين إحماء سريع مدته 3 دقائق يتم تشغيله مباشرة في التمرين لتقليل أي توقف مؤقت غير ضروري ؛ تذكر أن هذا كله يتعلق بالكفاءة حتى نتمكن من الحصول على أفضل تدريب ممكن في أقصر وقت ممكن. لذلك ، بعد تمارين الإحماء الستة ، ننتقل مباشرة إلى التمارين الثمانية لقسم التمرين. هذا هو المكان الذي يمكنك فيه الاختيار من خلال هذه التدريبات الثمانية مرة واحدة أو مرتين. أعطي دعوة واضحة عندما ننتهي من أول تشغيل لهذه التمارين حتى تتمكن من اتخاذ قرار التخطي إلى فترة التهدئة السريعة التي تبلغ 3 دقائق والقيام بها في حوالي 10 دقائق أو إجراء التمارين مرة ثانية (كما أفعل في الفيديو) ويتم الانتهاء منه في حوالي 15 دقيقة. بهذه الطريقة يمكنك تحديد مقدار الوقت الذي يمكنك تخصيصه لهذا التمرين.\r\n\r\nهذا تمرين شامل للجسم ، لذا إذا كنت تستخدمه بعد يوم مكثف من الجزء العلوي أو السفلي من الجسم ، ففي كلتا الحالتين من المرجح أنك تستخدم بعض مجموعات العضلات نفسها. لا تقلق ، على الرغم من ذلك - ستفعل ذلك بوزن الجسم فقط حتى تتمكن من التكيف لجعل التمارين أسهل أو أصعب ، وستقوم فقط ببضع عمليات التكرار لكل منها ، لذلك لا داعي للقلق بشأن إرهاق العضلات المؤلمة.\r\n\r\nمع ذلك ، يمكن أيضًا استخدام هذا كتمرين إضافي إذا كنت تريد القيام بتمرين ثانٍ في يوم واحد. يمكن القيام بذلك إما مباشرة بعد التمرين الأول أو في وقت لاحق من اليوم للحصول على نوبة إضافية من حرق السعرات الحرارية.",
                 Difficulty=3 , Duration=15,Image="Images/Exercise/39.jpg",Video="https://www.youtube.com/watch?v=xafq0q5lIq4" , Equipments=" بدون معدات " },
             new Exercise(){Id="9",TraningType="تدريب القوة",BurnEstimate="50-250" ,Title="تقوية اعضاء الجسم السفلية - تمرين الفخذ لمدة 43 دقيقة",Price=0, BodyFocus="الجسم السفلي" , Detail="يمكن استخدام تمرين الجزء السفلي من الجسم هذا للتناغم أو القوة أو بناء الكتلة ، بحيث يمكنك استخدامه لما تحتاجه بالضبط. في هذا الروتين ، قمنا بتقسيم التمرين إلى ثلاث مجموعات (لا تشمل الإحماء والتهدئة). سيتم إجراء أول مجموعتين بأسلوب فاصل من 45 ثانية من النشاط مع 15 ثانية من الراحة للاستعداد للتمرين التالي. تحتوي كل مجموعة من هاتين المجموعتين الأوليين على 4 تمارين لكل منهما ، وسيتم إجراؤها بنمط A ، B A ، B بالتناوب ، بالتناوب ذهابًا وإيابًا بين اثنين من التمارين الأربعة في وقت واحد. سيتم إجراء كل تمرين لما مجموعه ثلاث مجموعات قبل الانتقال إلى التدريبات التالية ، مما يمنحنا إجمالي 12 فترة لكل مجموعة لأول مجموعتين. ستتم المجموعة الأخيرة قبل فترة التهدئة والتمدد بشكل مختلف. على الرغم من وجود أربعة تمارين مرة أخرى في هذه المجموعة ، فإننا سنقوم بدلاً من ذلك بإجراء كل تمرين لمجموعة واحدة فقط باستخدام فترات 60 ثانية على و 15 ثانية راحة. هذا المزيج من مجموعتين باستخدام ثلاث مجموعات تقليدية أكثر لكل تمرين متبوعًا بمجموعة تستخدم مجموعة نضوب واحدة سيسمح لنا بإرهاق العضلات بشكل فعال إلى الحد الذي يمكننا فيه الحصول على التمزقات الدقيقة في عضلاتنا التي تؤدي إلى زيادة القوة والكتلة.\r\nمع ما يقال ، تذكر أنه يمكنك التحكم بالضبط في النتائج التي تحصل عليها من هذا الروتين عن طريق ضبط الوزن الذي تختار رفعه ومدى سرعة القيام بكل تكرار. للحصول على تمرين أكثر تركيزًا على التنغيم ، استخدم وزن الجسم فقط أو الوزن الخفيف جدًا وتحرك بسرعة أكبر (طالما أنك لا تزال تتحرك مع التحكم ولا تستخدم الزخم للمساعدة في إكمال الحركة التي يتم إجراؤها). إذا كنت تريد التركيز أكثر على بناء الحجم الكلي للعضلات ، فحافظ على بطء حركاتك واختر أثقل وزن يمكنك التحكم فيه من خلال نطاق كامل من الحركة. مع بناء الكتلة ، يجب أن يكون هدفك هو الحصول على 90-100 ٪ من كل مجموعة من أول مجموعتين (من أي تمرين معين) قبل أن تبدأ عضلاتك في الاستسلام ويبدأ شكلك في المعاناة. يجب أن يكون الهدف من المجموعة الثالثة (الأخيرة) من كل تمرين هو إكمال 80-90٪ من الفاصل الزمني قبل أن تستسلم عضلاتك.",
                 Difficulty=4 , Duration=43,Image="Images/Exercise/40.jpg",Video="https://www.youtube.com/watch?v=ABDmiZD1TDU" , Equipments = "دمبل"},
             new Exercise(){Id="10",TraningType = "تدريب متقطع عالي الكثافة ، تأثير منخفض ، بيلاتيس ، تدريب القوة ، التمدد / المرونة ، القدرة على الحركة", BurnEstimate="50-250" ,Title="روتين القوة الأساسية الموزونة - روتين أوزان الدمبل في المنزل",Price=0, BodyFocus="جوهر" , Detail="\r\nإذا كنت تمارس هذا التمرين بهدف بناء القوة و / أو الكتلة ، فإليك بعض الأشياء التي يجب وضعها في الاعتبار.\r\n\r\nأولاً ، كما هو الحال مع أي تمرين قوي أو جماعي ، لا ترفع كثيرًا حتى يبدأ شكلك أو نطاق حركتك في المعاناة. إذا كنت قد قمت في أي وقت مضى بواحد من إجراءات قوتنا من أي نوع من قبل ، فمن المحتمل أنك سمعتنا بالفعل نقول هذا مرارًا وتكرارًا ؛ شكل ونطاق الحركة أكثر أهمية بكثير من مقدار الوزن الذي ترفعه عندما يتعلق الأمر بالقوة الوظيفية الخالية من الإصابات.\r\n\r\nثانيًا ، حدد الوزن الذي تستخدمه بناءً على معدل التعب لديك. يجب أن يكون هدفك هو استخدام وزن ثقيل بدرجة كافية بحيث يمكنك إجراء جميع عمليات التكرار تقريبًا بشكل مثالي ونطاق كامل من الحركة. يجب السماح للمعاناة في آخر 2 أو 3 مرات فقط لأن هذه العضلات تصبح مرهقة للغاية بحيث لا يمكن الحفاظ عليها نظيفة.\r\n\r\nثالثًا ، عندما تتخلى عضلاتك عن تلك التكرارات القليلة الأخيرة ، ابدأ في التركيز حقًا على الحركة \"السلبية\". يُعرف بشكل أكثر رسميًا باسم الانقباض غريب الأطوار ، والسالب هو النقطة التي يتغلب فيها الحمل على القوة التي يمكن للعضلة أو تقدمها والمبتدئين في إطالة العضلات. على سبيل المثال ، عند أداء تمرين الدمبل ، فإن المرحلة اللامتراكزة هي عندما يتراجع الدمبل إلى أسفل من الكتف ، مما يؤدي إلى إطالة عضلات البايسبس. من خلال التركيز على هذه الحركة ومحاولة التحكم في المرحلة اللامركزية ، يمكنك الحصول على مزيد من التمزقات الدقيقة في ألياف عضلاتك ، مما يؤدي إلى درجة أعلى من التقدم لزيادة القوة والحجم في العضلات التي تعمل. لذلك ، عندما تبدأ في الشعور بالتعب ، لا تدع هذا الوزن ينخفض فقط. إن بذل قصارى جهدك لمحاربة فقدان الوزن هو أهم جزء في روتين قوتك بالكامل.\r\n\r\nأخيرًا ، تأكد من ضبط الوزن الذي تستخدمه لكل مجموعة ، حسب الحاجة. لا تتعثر في عقلية أن ما تبدأ به يجب أن ينتهي به. بالنسبة لبعض التمارين ، قد تشعر أنه يمكنك زيادة وزنك والبعض الآخر قد تحتاج إلى إنقاصه ، وقد يكون ذلك لمجموعة واحدة فقط قبل التغيير مرة أخرى. جسمك هو آلة ديناميكية دائمة التغير ، لذلك عليك أن تكون قادرًا على التغيير والتكيف مع احتياجاته يوميًا ، إن لم يكن دقيقة بدقيقة.",
                 Difficulty=3 , Duration=37,Image="Images/Exercise/41.jpg",Video="https://www.youtube.com/watch?v=pnNCuecyZnQ" , Equipments = " دمبل  ، بدون معدات "},



            };
        }




        public static List<Exercies_program> GetListOfExerciesprogram()
        {
            return new List<Exercies_program>()
            {
             new Exercies_program(){Id="1",SportsProgramId="102" , ExerciseId="1" ,Day=1,Week=1},
             new Exercies_program(){Id="2",SportsProgramId="102" , ExerciseId="2" ,Day=2,Week=1},
             new Exercies_program(){Id="3",SportsProgramId="102" , ExerciseId="3" ,Day=3,Week=1},
             new Exercies_program(){Id="4",SportsProgramId="102" , ExerciseId="4" ,Day=4,Week=1},
             new Exercies_program(){Id="5",SportsProgramId="102" , ExerciseId="5" ,Day=4,Week=1},
             new Exercies_program(){Id="6",SportsProgramId="102" , ExerciseId="6" ,Day=5,Week=1},
             new Exercies_program(){Id="7",SportsProgramId="102" , ExerciseId="7" ,Day=6,Week=1},
             new Exercies_program(){Id="8",SportsProgramId="102" , ExerciseId="8" ,Day=7,Week=1},
             new Exercies_program(){Id="9",SportsProgramId="102" , ExerciseId="9" ,Day=7,Week=1},
             new Exercies_program(){Id="10",SportsProgramId="102" , ExerciseId="10" ,Day=7,Week=1},


             new Exercies_program(){Id="11",SportsProgramId="102" , ExerciseId="10" ,Day=1,Week=2},
             new Exercies_program(){Id="12",SportsProgramId="102" , ExerciseId="8" ,Day=2,Week=2},
             new Exercies_program(){Id="13",SportsProgramId="102" , ExerciseId="6" ,Day=2,Week=2},
             new Exercies_program(){Id="14",SportsProgramId="102" , ExerciseId="5" ,Day=3,Week=2},
             new Exercies_program(){Id="15",SportsProgramId="102" , ExerciseId="4" ,Day=4,Week=2},
             new Exercies_program(){Id="16",SportsProgramId="102" , ExerciseId="3" ,Day=5,Week=2},
             new Exercies_program(){Id="17",SportsProgramId="102" , ExerciseId="2" ,Day=6,Week=2},
             new Exercies_program(){Id="18",SportsProgramId="102" , ExerciseId="1" ,Day=7,Week=2},
             new Exercies_program(){Id="19",SportsProgramId="102" , ExerciseId="9" ,Day=8,Week=2},


            };
        }


        public static List<Tracking> GetListOfTracking()
        {
            return new List<Tracking>()
            {
                new Tracking(){Id="1",Iscomplete=true , Exercies_programId="1" , Order_DetailsId="1"},
               

            };
        }


        
    }
}

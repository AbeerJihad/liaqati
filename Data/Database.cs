namespace liaqati_master.Data
{
    public static class Database
    {

        public static List<AthleticProgram> GetListOfAthleticProgram()
        {
            return new List<AthleticProgram>() {
                new AthleticProgram
                 {
                     Id = 1,
                     Title = " برنامج لنحت وتفصيل الجسم في 8 أسابيع فقط",
                     Description = "" +
                    "<p>\n أفضل طريقة لتحصيل أفضل النتائج من جهودك في التدريب هي تطبيق عدّة طرق وأنواع من التمارين والروتينات, وذلك لتمنح جسمك حوافز جديدة باستمرار لنمو العضلات وبناء أنسجة عضلية جديدة, ولتمنع تأقلم جسمك مع التدريبات التي تمارسهاء فإذا حصل هذا التاقلم سيبطئ عملية حرق الدهون وبناء العضلات. لذا عليك تغيير روتين تدريبك باستمرارإن كنت قد اتخذت قرارك بوضع حد لجسمك المترهّل وأسلوب حياتك الخامل وتريد أن تعرف كيف تنفذ خطة تدربيبة تعطيك نتائج مذهلة في فترة قصيرة, فقد وصلت للمكان المناسب. ستمكّنك هذه الخطة من رؤية تغيّرات جذرية في انسيابية جسمك ورشاقتك ومستوى لياقتك البدنية خلال 8 أسابيع من تنفيذها</p>" +
                    "" +
                    "<h2>why kadljkd</h2>",
                     Length = 8,
                     BodyFocus = "كل الجسم",
                     Difficulty = "3-4",
                     Equipment = "حزام التمرين,سجاد",
                     Price = 99,
                     TrainingType = "القلب والأوعية الدموية ، تأثير منخفض ، تدريب القوة ، التنغيم ، اليوجا ، الحركة"
                 }
            };
        }
        public static List<User> GetListOfUsers()
        {
            return new List<User>() {
                              new User() {
                                   Id = 1,
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
                                        Id = 1,
                                        OrderDate = new DateTime(),
                                        UserIdResiver = 1,
                                        UserIdDelivery = 1,
                                        UserId = 1
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
    }
}

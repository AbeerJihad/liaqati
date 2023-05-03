using liaqati_master.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace liaqati_master.Data
{
    public static class Database
    {
        public static List<Consultation> GetListOfConsultation()
        {
            return new List<Consultation>()
            {
                new Consultation() {Id="1",Title="عند وضع ثقل على القدم ورفعه أشعر بألم في الركبة، فهل السبب قلة الحركة؟", UserId="5", CategoryId ="7"
                , Description="عمري 32 سنة، عاطل أعزب، توقفت عن لعب كرة القدم لمدة شهر، والحمد لله أشعر بتحسن كبير في الركبة، واختفاء الألم، ولكن لاحظت أنني حينما أمارس تمرين تقوية الفخذ (بوضع ثقل على القدم ورفع القدم لمنتصف الساق المنثنية وإخراجها)، أشعر بألم خفيف من حين لآخر لمدة يوم أو يومين، وعندما أتوقف عن التمارين لأيام يختفي الألم بصورة كبيرة جداً.\r\n\r\nفهل لقلة الحركة وكثرة الجلوس دور في الإصابات المختلفة، مثل إصابة القدم والركبة والكتف والكعب والتي أتعرض لها؟ فأنا كثير الاستلقاء على السرير، وقليل الحركة جداً. وفي الفترة الأخيرة أصبحت أمشي من نصف ساعة لساعة ونصف في اليوم، وهل لطريقة المشي من فرد الجسم ورفع الرأس وسرعة المشي دور في الاستفادة من المشي؟",},
                new Consultation() {Id="2",Title="رياضة المشي والجري..المدة والمسافة والحذاء المناسب!", UserId="5", CategoryId ="7",
                    Description="<p>أسأل عن الرياضة، حيث إني قرأت وسمعت عن فوائدها، ولكني لا أجد المكان الملائم لممارسة الرياضة، وهي (الجري) إلا في البيت، حيث إني أجري حول الحديقة، وهي على شكل مستطيل، وبطول خمس وأربعين خطوة، أي طول المسافة التي حول المستطيل أي مجموع الأربعة أضلاع، يساوي خمساً وأربعين خطوة.<br><br>هل يمكن الجري في هذه المسافة؟ علماً بأن نصف المسافة أرض صلبة من الإسمنت، فهل الجري على الإسمنت يسبب لي أضراراً؟ خاصة في مفاصل الركبة.<br><br>إذا كان يسبب أضراراً فهل المشي على الإسمنت يسبب أضراراً كذلك؟ وما هي السرعة والمدة الزمنية التي يجب أن أستغرقها في المشي للحصول على الفوائد الصحية؟<br><br>أيهما أفضل المشي أم الجري؟ وما مدة وسرعة كل منهما؟ وهل إذا مارست الجري في الصباح وفي يوم من الأيام لم أتمكن من الجري، هل يمكن أن أجري في المساء لأعوض أم يجب أن أستمر على وقت معين؟<br><br>ما هي مواصفات حذاء الجري؟ هل الحذاء الواطي أم العالي أفضل؟ حيث إني لم أجد حذاء ذا مرونة جيدة.</p>",},
                new Consultation() {Id="3",Title="إمكانية أكل الحلويات والوجبات السريعة بكميات قليلة لمن يعالجون بالحمية الغذائية", UserId="5", CategoryId ="8",
                    Description="عمري 29 سنةً، وطولي 155 سم، وزني 66 كجم، أجريت حميةً غذائيةً، ونزل وزني من 75 إلى 66 كجم، وأحاول الآن أن أصل إلى وزني الطبيعي 54 كجم، لكن أحياناً أشتهي تناول الحلوى، فما هو مقدار الحلوى الذي أستطيع أن أتناوله كل مرة أو أسبوعياً؟ وهل أستطيع أن آكل القشطة مع ملعقة عسل طبيعي في الصباح الباكر، أم أن هذا يزيد الوزن؟ وهل يمكن أن آكل في أوقات متباعدة قطعة بيتزا أو همبرجر؟",},
                new Consultation() {Id="4",Title="ما هو الطعام الصحي للعمال الذين يعملون أعمالاً شاقة بشكل مستمر؟", UserId="4", CategoryId ="8",
                    Description="ما هو الطعام الصحي للعمال الذين يعملون أعمالاً شاقة بشكل مستمر؟",},
              
              //  new Consultation() {Id="",Title="", UserId="", CategoryId ="", Description="",},
            };
        }
        public static List<Replyconsultation> GetListOfReplyconsultation()
        {
            return new List<Replyconsultation>()
            {
                new Replyconsultation(){Id="1", consId ="1",UserId ="2",
                    Reply="<p>بسم الله الرحمن الرحيم<br>السلام عليكم ورحمة الله وبركاته، وبعد:<br><br>كونك تمشي في الآونة الأخيرة من نصف ساعة إلى ساعة ونصف دون الشعور بالألم، فهذا أمر جيد، عليك المداومة عليه، والألم الذي تشعر به عند وضع ثقل على قدمك ورفعه أمر مرتبط بضعف اللياقة البدنية، وليس بإصابة في الركبة أو القدم، وأي شخص في النادي الرياضي إذا وضع ثقلًا على قدمه سوف يشعر بنوع من الألم قل أو كثر.<br><br>والمشي في اليوم 10000 خطوة يكفي جدًا لزيادة اللياقة البدنية، ولتحريك المفاصل والشفاء من الإصابات، ولا بأس بتحريك الذراعين، والنظر إلى الأمام أثناء المشي، والالتزام بالصلوات والنوافل، فهي رياضة في حد ذاتها، ونؤكد دائماً على ضبط مستوى فيتامين D، وفحص صورة الدم CBC، والتغذية الجيدة، والاستحمام بالماء البارد، إذا استطعت ذلك لكي تنشط الدورة الدموية.<br><br>وفقك الله لما فيه الخير.</p>",},
                new Replyconsultation(){Id="2", consId ="2",UserId ="2",
                    Reply="<p>بسم الله الرحمن الرحيم<br>الأخ الفاضل/ سامي حفظه الله.<br>السلام عليكم ورحمة الله وبركاته، وبعد:<br><br>فإن المشي من الرياضات المتوسطة الإجهاد التي تساعد الناس على المحافظة على لياقتهم ورشاقتهم بحرق الطاقة الزائدة، ويقوي الجهاز الدوري، ويحسن من استخدام الأكسجين والطاقة في الجسم.<br><br>لذلك يقلل من المخاطر المرتبطة بالسمنة، والسكري، وارتفاع الضغط، وأمراض القلب، ويقوي العضلات في الأرجل والبطن والظهر، ويقوي العظام، ويقلل من إصابتها بالهشاشة.<br><br>من ناحية أخرى: فإن المشي يفيد في التخلص من الضغوط النفسية، والقلق والإجهاد اليومي، ويحسن من الوضع النفسي، ومن تجاوب الجهاز العصبي، ويساعد المشي على التخلص من الوزن الزائد، وهذا بالطبع يعتمد على مدة المشي وسرعته.<br><br>إذا مشيت بمعدل 4 كم/ ساعة فإن جسمك يحرق ما بين 200 &ndash; 250 سعراً حرارياً في الساعة (22 &ndash; 28 جرام من الدهون).<br><br>يمكنك مزاولة المشي في أي مكان وزمان بدون تجهيزات أو ملابس خاصة، ويمكن أن يكون جزءاً من الحياة اليومية، ويمكن أن يكون في أي وقت من النهار، ومن الأفضل تحديد وقت معين خلال اليوم للمشي، بحيث يكون جزءاً من جدولك في اليوم، وذلك للمحافظة على موعد المشي.<br><br>إذا كان غرض المشي مجرد اللياقة البدنية فيكفي المشي مدة 30 دقيقة على الأقل يومياً، أو ثلاث مرات أسبوعياً.<br><br>أما إذا كان الغرض تخفيف الوزن واللياقة البدنية فيلزمك المشي 30 دقيقة على الأقل يومياً، أو خمس مرات في الأسبوع.<br><br>يمكنك زيادة مدة المشي إلى ساعة يومياً لكسب مزيد من اللياقة، وتخفيف الوزن.<br><br>المشي من أقل التمارين الرياضية ضرراً على المفاصل، والأقل في احتمالات الإصابة خلال التمارين.<br><br>عندما تمشي ابق رأسك مرفوعاً، وانظر على بعد بضع خطوات أمامك، وحافظ على الفك السفلي في مكانه دون شد بل اجعل عضلاته منبسطة وابق الكتفين إلى الخلف دون شد، ولا تجعلهما منحنيين إلى الأمام، وحافظ على الصدر مرتفعاً والظهر مستقيماً وقائماً، ويجب أن تكون عضلات البطن مشدودة قليلاً إلى الداخل، وعضلات الورك والعجيزة (المؤخرة) مشدودة قليلاً إلى الداخل أيضاً.<br><br>لا بد أن يكون مفصل الركبة مرناً للحركة فلا تجعله مشدوداً بحيث يتحرك الساق والفخذ معاً.<br><br>اثن أصابع اليد للداخل بدون تكوين قبضة كاملة وبدون ضغط عليها، ولا تجعل يديك تتدلى والكف مفتوحة، اجعل الذراع بشكل زاوية قائمة من عند المرفق، وحرك يديك إلى الأمام والخلف بحيث ترتفع قبضة الكف إلى أعلى في حركة اليد إلى الأمام وتصل إلى محاذاة الورك في حركتها إلى الخلف، ولا تجعلها تتأرجح أمام جسمك، ومع حركة المشي ارجع ذراعيك إلى الخلف نحو الورك ولا تجعلهما يرتفعان في الهواء، وحركة الأذرع تأتي من الكتف وليس من المرفق.<br><br>إذا أردت المشي بسرعة فلا تجعل خطوتك واسعة، بل قم بزيادة عدد الخطوات (زيادة السرعة)، ولا تقصر من الخطوات بل الأفضل السير بالخطوات الطبيعية المريحة لك.<br><br>يختلف حذاء المشي عن الأحذية الأخرى التي تستخدم عادة، كما أنه يختلف عن بقية الأحذية الرياضية الخاصة بالجري أو التنس أو كرة القدم مثلاً؛ وذلك لأن آلية حركة القدم خلال المشي تختلف عنها في الرياضات الأخرى.<br><br>يجب أن يكون حذاء المشي ذا كعب عريض، ونعل مرن في الوسط، وأن يكون حاضناً للكعب دون أن يكون ضيقاً عليه، وأن تكون حركة أصابع الرجل في الطرف الأمامي للحذاء ممكنة.<br><br>كما يجب تغيير الحذاء إذا تآكل جزء من نعله، وعند شرائه يجب التأكد من أنه مريح من أول تجربة لبس له، وصفاته مطابقة لما تم ذكره.<br><br>هناك جوارب خاصة بالمشي وتمتاز أنها تسمح بتهوية القدمين وبالتخلص من العرق، ويجب أن يكون حجم الجوارب مناسباً لمقاس القدم بحيث لا تنطوي أو تكوّن زوائد تؤدي إلى رفع درجة حرارة القدم، وإلى الإصابة بالنفطات.<br><br>يجب أن تقوم بعملية التسخين قبل رياضة المشي، ويجرى التسخين بأداء بعض الحركات لليدين، والقفز والجري في المكان، أو المشي البطيء مدة 5 &ndash; 10 دقائق قبل المشي السريع.</p>",},
                new Replyconsultation(){Id="3", consId ="3",UserId ="2",
                    Reply="<p>إن أردت أن تحافظي على وزنك فعليك أن تحافظي على أن يكون مقدار ما تأخذينه من طاقة من الطعام مساوياً للطاقة التي تحتاجينها يومياً، وتقدر بالنسبة لسنك بـ2200 كالوري بالمتوسط، وإن أردت أن تكوني دقيقةً أكثر فيمكنك مراجعة أخصائي تغذية، فيحسب لك بالتمام مقدار السعرات الحرارية اللازمة لك، والمناسبة لطولك، ووزنك، وعملك، والطاقة اللازمة لك، ويحتاج الجسم الطبيعي هذه المصادر لإنتاج الطاقة بنسب مختلفة:<br /><br />- الكربوهيدرات ( النشويات ) 50%.<br />- الدهون 35%.<br />- البروتينات 15%.<br /><br />الإنسان يحتاج لكمية مُحددة من السعرات الحرارية يومياً، وتزداد حسب نشاط الشخص وحجم جسده (الطول والوزن) وكذلك العمر، فالأطفال والشبان في طور النمو يحتاجون لكميات أكبر من السعرات الحرارية، ويجب أن يكون هناك توازن ما بين السعرات الحرارية التي نأخذها من الطعام والسعرات الحرارية التي نحرقها، حتى لا يزداد وزننا، حيث إن الجسم يُخزن السعرات الحرارية الزائدة عن حاجته على هيئة شحوم، ليستخدمها فيما بعد إذا اُضطر لذلك (في حال نقص السعرات الحرارية المأخوذة عن طريق الأكل)، وإذا أفرطنا في الأكل تزداد كمية الشحوم، وإذا قللنا الأكل فإن الجسم يستخدم الشحوم لإنتاج الطاقة ويحرقها، وبالتالي تقل الشحوم لدينا.<br />ولا يوجد ما يمنع أن تتناولي البيتزا أو الحلويات مرةً كل عدة أيام، بشرط أن تأخذي بعين الاعتبار كمية السعرات الحرارية التي تحويها هذه الأطعمة، وتحسب من ضمن السعرات الحرارية المسموح بها ذلك اليوم؛ لأن كل زيادة في الداخل من الطاقة إذا لم يقابلها حرق لهذه الطاقة، فإن ما يزيد يتحول إلى دهون وشحوم يجمعها الجسم في أماكن تخزين الدهون وهو البطن والأرداف، وأماكن أخرى من الجسم، ومتى قلت كمية الطعام الداخلة عن احتياج الجسم، فإن الجسم يبدأ باستهلاك الدهون في الجسم.</p>",},
                new Replyconsultation(){Id="4", consId ="4",UserId ="1",
                    Reply="<p>بسم الله الرحمن الرحيم<br />السلام عليكم ورحمة الله وبركاته، وبعد:<br /><br />فإن السعرات الحرارية التي نحتاجها يومياً تقدر : 5000-5600 سعرة حرارية.<br />والطعام الصحي هو الطعام المتوازن المعتدل في الكمية والمختلف في النوع، وتختلف الأطعمة حسب كمية ونوعية المواد الغذائية التي تحتوي عليها، لذلك فمن المهم عند تنظيم التغذية اختيار أطعمة من كافة الأصناف ما أمكن ذلك.<br /><br />وأصناف الطعام الرئيسية هي:<br /><br />الحبوب/ الخضار والفواكه /اللحوم والأسماك /مشتقات الحليب/الدسم والزيوت/<br /><br /><br />ولذلك عليك حساب كمية السعرات الحرارية التي تلزمك، ثم تقسيمها على المواد الغذائية من الأطعمة المختلفة والمتنوعة.</p>",},
              
              //  new Replyconsultation(){Id="", consId ="",UserId ="", Reply="",},
            };
        }
       
        public static List<SportsProgram> GetListOfSportsProgram()
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
        public static List<Category> GetListOfCategories() => new()
        {

            new Category
            {
                Id = "1", Name = "طبق رئيسي", Target = "الوجبات"
            },
            new Category
            {
                Id = "2", Name = "أكل صحي", Target = "الوجبات"
            },
             new Category
            {
                Id = "3", Name = "المكملات الغذائية", Target =  "منتجات"
            },
            new Category
            {
                Id = "4", Name = "الاجهزة الرياضية", Target =  "منتجات"
            },
            new Category
            {
                Id = "5", Name = "حلوى", Target ="الوجبات"
            },
            new Category
            {
                Id = "6", Name = "الوجبات", Target ="الوجبات"
            },
               new Category
            {
                Id = "7", Name = "لياقة بدنية", Target ="استشارات"
            },
                  new Category
            {
                Id = "8", Name = "تغذية", Target ="استشارات"
            },

        };
        public static List<SelectListItem> GetListOfMealType() => new()
        {
            new SelectListItem
            {
                Value = "وجبة الإفطار", Text = "وجبة الإفطار"
            },
            new SelectListItem
            {
                Value = "وجبة غداء", Text = "وجبة غداء"
            },
            new SelectListItem
            {
                Value = "وجبة عشاء", Text = "وجبة عشاء"
            },
            new SelectListItem
            {
                Value = "وجبة خفيفة", Text = "وجبة خفيفة"
            },
            new SelectListItem
            {
                Value = "حلوى", Text = "حلوى"
            },
            new SelectListItem
            {
                Value = "طبق جانبي", Text = "طبق جانبي"
            },
        };
        public static List<SelectListItem> GetListOfDietaryType() => new()
        {
            new SelectListItem
            {
                Value = "نباتي", Text = "نباتي"
            },
            new SelectListItem
            {
                Value = "حيواني", Text = "حيواني"
            },
        };
        public static List<SelectListItem> GetListOfBodyFocus() => new()
        {

            new SelectListItem() { Text = "الجسم السفلي من الجسم" ,Value = " الجسم السفلي من الجسم" },
             new SelectListItem() { Text = "الجزء العلوي من الجسم" ,Value = "الجزء العلوي من الجسم" },
             new SelectListItem() { Text = "جوهر" ,Value = "جوهر" },
             new SelectListItem() { Text = "الجسم بالكامل" ,Value = "الجسم بالكامل" }


        };
        public static List<SelectListItem> GetListOfTrainingType() => new()
        {
            new SelectListItem() { Text = "HIIT" ,Value = "HIIT" },
            new SelectListItem() { Text = "تدريب القوة" ,Value = "تدريب القوة" },
            new SelectListItem() { Text = "بيلاتيس" ,Value = "بيلاتيس" },
            new SelectListItem() { Text = "كيتل بيل" ,Value = "كيتل بيل" },
            new SelectListItem() { Text = "الكيك بوكسينغ" ,Value = "الكيك بوكسينغ" },
            new SelectListItem() { Text = "التنغيم" ,Value = "التنغيم" },
            new SelectListItem() { Text = "التوازن / الرشاقة" ,Value = "التوازن / الرشاقة" },
            new SelectListItem() { Text = "بليومترك" ,Value = "بليومترك" },
            new SelectListItem() { Text = "باري" ,Value = "باري" },
            new SelectListItem() { Text = "اليوغا" ,Value = "اليوغا" },
            new SelectListItem() { Text = "الاحماء / التبريد" ,Value = "الاحماء / التبريد" },
            new SelectListItem() { Text = "تأثير ضعيف" ,Value = "تأثير ضعيف" },
            new SelectListItem() { Text = "التمدد / المرونة" ,Value = "التمدد / المرونة" } ,
            new SelectListItem() { Text = "القلب والأوعية الدموية" ,Value = "القلب والأوعية الدموية" },
            new SelectListItem() { Text = "تدريب القوة" ,Value = "تدريب القوة" }


        };
        public static List<SelectListItem> GetListOfEquipment() => new()
        {

             new SelectListItem() { Text = "لا معدات" ,Value = "لا معدات" },
             new SelectListItem() { Text = "الدمبل" ,Value = "الدمبل" },
             new SelectListItem() { Text = "حصيرة" ,Value = "حصيرة" },
             new SelectListItem() { Text = "مقعد" ,Value = "مقعد" },
             new SelectListItem() { Text = "حزام التمارين الرياضية" ,Value = "حزام التمارين الرياضية" },
             new SelectListItem() { Text = "حبل قفز" ,Value = "حبل قفز" },
             new SelectListItem() { Text = "كيتل بيل" ,Value = "كيتل بيل" },
             new SelectListItem() { Text = "كرة طبية" ,Value = "كرة طبية" } ,
             new SelectListItem() { Text = "فيزيو بول" ,Value = "فيزيو بول" },
             new SelectListItem() { Text = "كيس الرمل" ,Value = "كيس الرمل" },
             new SelectListItem() { Text = "اسطوانة رغوة" ,Value = "اسطوانة رغوة" },
             new SelectListItem() { Text = "خطوة التمرين" ,Value = "خطوة التمرين" },
             new SelectListItem() { Text = "آخر" ,Value = "آخر" }


        };
        public static List<SelectListItem> GetListOfDifficulty() => new()
        {

            new SelectListItem() { Text = "1" ,Value = "1" },
            new SelectListItem() { Text = "2" ,Value = "2" },
            new SelectListItem() { Text = "3" ,Value = "3" },
            new SelectListItem() { Text = "4" ,Value = "4" },
            new SelectListItem() { Text = "5" ,Value = "5" },


        };
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
                },

                  new User() { Id = "2",Fname="اماني",Lname="محمد",Photo="/user/images/download.jpg"},
                  new User() { Id = "3",Fname="احمد",Lname="سعيد",Photo="/user/images/download.jpg" },
                  new User() { Id = "4",Fname="ماجد",Lname="خالد",Photo="/user/images/download.jpg" },
                  new User() { Id = "5",Fname="رشا",Lname="محمود",Photo="/user/images/download.jpg" },
                  new User() { Id = "6",Fname="ريهام",Lname="احمد",Photo="/user/images/download.jpg"},
            };
        }
        public static List<Order> GetListOfOrders()
        {
            return new List<Order>()
            {
                new Order()
                {
                    Id = "1",
                        OrderDate = new DateTime(year: 2021, month: 5, 1),
                        UserIdResiver = 1,
                        UserIdDelivery = 1,
                        UserId = "1",
                        TotalPrice = 200,
                }, new Order()
                {
                    Id = "2",
                        OrderDate = new DateTime(year: 2021, month: 5, 1),
                        UserIdResiver = 1,
                        UserIdDelivery = 1,
                        UserId = "1"
                }, new Order()
                {
                    Id = "3",
                        OrderDate = new DateTime(year: 2021, month: 5, 1),
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
                new Order_Details()
                      {
                        Id = "1", OrderId = "1", Price = 100, RateId = 1, Quantity =2,  ServiceId = "21"
                    },
                    new Order_Details()
                    {
                        Id = "2", OrderId = "1", Price = 100, RateId = 1, Quantity = 2, ServiceId = "21"
                    },
                    new Order_Details()
                    {
                        Id = "3", OrderId = "1", Price = 100, RateId = 1, Quantity = 2, ServiceId = "21"
                    },
                    new Order_Details()
                    {
                        Id = "4", OrderId = "2", Price = 100, RateId = 1, Quantity = 7, ServiceId = "31"
                    },
                    new Order_Details()
                    {
                        Id = "5", OrderId = "2", Price = 100, RateId = 1, Quantity = 5, ServiceId = "31"
                    },
                    new Order_Details()
                    {
                        Id = "6", OrderId = "2", Price = 100, RateId = 1, Quantity = 3, ServiceId = "24"
                    },
                    new Order_Details()
                    {
                        Id = "7", OrderId = "3", Price = 100, RateId = 1, Quantity = 2, ServiceId = "23"
                    },
                    new Order_Details()
                    {
                        Id = "8", OrderId = "3", Price = 100, RateId = 1, Quantity = 4, ServiceId = "23"
                    },
                    new Order_Details()
                    {
                        Id = "9", OrderId = "3", Price = 100, RateId = 1, Quantity = 10, ServiceId = "23"
                    },
                    new Order_Details()
                    {
                        Id = "10", OrderId = "1", Price = 100, RateId = 1, Quantity =2,  ServiceId = "23"
                    },
                    new Order_Details()
                    {
                        Id = "11", OrderId = "1", Price = 100, RateId = 1, Quantity =2,  ServiceId = "23"
                    },
                    new Order_Details()
                    {
                        Id = "12", OrderId = "1", Price = 100, RateId = 1, Quantity =3,  ServiceId = "23"
                    },
                    new Order_Details()
                    {
                        Id = "13", OrderId = "2", Price = 100, RateId = 1, Quantity = 7, ServiceId = "24"
                    },
                    new Order_Details()
                    {
                        Id = "14", OrderId = "2", Price = 100, RateId = 1, Quantity = 5, ServiceId = "24"
                    },
                    new Order_Details()
                    {
                        Id = "15", OrderId = "2", Price = 100, RateId = 1, Quantity = 3, ServiceId = "24"
                    },
                    new Order_Details()
                    {
                        Id = "16", OrderId = "3", Price = 100, RateId = 1, Quantity = 4, ServiceId = "24"
                    },
                    new Order_Details()
                    {
                        Id = "17", OrderId = "3", Price = 100, RateId = 1, Quantity = 4, ServiceId = "24"
                    },
                    new Order_Details()
                    {
                        Id = "18", OrderId = "3", Price = 100, RateId = 1, Quantity = 10, ServiceId = "24"
                    },
                    new Order_Details()
                    {
                        Id = "19", OrderId = "1", Price = 100, RateId = 1, Quantity = 5, ServiceId = "31"
                    },
                    new Order_Details()
                    {
                        Id = "20", OrderId = "1", Price = 100, RateId = 1, Quantity =6,  ServiceId = "31"
                    },
                    new Order_Details()
                    {
                        Id = "21", OrderId = "1", Price = 100, RateId = 1, Quantity =10,  ServiceId = "31"
                    },
                    new Order_Details()
                    {
                        Id = "22", OrderId = "2", Price = 100, RateId = 1, Quantity = 7, ServiceId = "31"
                    },
                    new Order_Details()
                    {
                        Id = "23", OrderId = "2", Price = 100, RateId = 1, Quantity = 5, ServiceId = "32"
                    },
                    new Order_Details()
                    {
                        Id = "24", OrderId = "2", Price = 100, RateId = 1, Quantity = 3, ServiceId = "32"
                    },
                    new Order_Details()
                    {
                        Id = "25", OrderId = "3", Price = 100, RateId = 1, Quantity = 11, ServiceId = "32"
                    },
                    new Order_Details()
                    {
                        Id = "26", OrderId = "3", Price = 100, RateId = 1, Quantity = 4, ServiceId = "32"
                    },
                    new Order_Details()
                    {
                        Id = "27", OrderId = "3", Price = 100, RateId = 1, Quantity = 10, ServiceId = "32"
                    },
            };
        }
        public static List<Achievement> GetListOfAchievements()
        {
            return new()
            {
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = "برامج تدريب لتحسين اللياقة - التخسيس - الضخامة العضلية",
                        FromDate = new DateTime(1997, 7, 5),
                },
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = "التغذية الرياضية لجميع الرياضيين",
                        FromDate = new DateTime(1998, 3, 19)
                },
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = "دورة السمنة و علاجها و الطرق الصحيحة لانقاص الوزن",
                        FromDate = new DateTime(2000, 11, 6)
                },
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = " اللياقة البدنية للأطفال",
                        FromDate = new DateTime(2001, 8, 16)
                },
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = "أساسيات التغذية السليمة",
                        FromDate = new DateTime(200, 6, 8)
                },
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = "رحلة إنقاص الوزن",
                        FromDate = new DateTime(2003, 1, 8),
                },
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = "دبلومة التغذية العلاجية",
                        FromDate = new DateTime(2004, 11, 6)
                },
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = "النظام الغذائي المتقدم وتخطيط الوجبات",
                        FromDate = new DateTime(2005, 5, 13)
                },
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = "التغذية من الالتهاب - النظام الغذائي المضاد للالتهابات",
                        FromDate = new DateTime(2006, 7, 13)
                },
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = "تدريب مدرب الصحة",
                        FromDate = new DateTime(2007, 1, 230)
                },
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = "ممارسة اليوجا قبل الولادة",
                        FromDate = new DateTime(2009, 7, 15)
                },
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = "تصميم الأنظمة الغذائية والوجبات الصحية",
                        FromDate = new DateTime(2011, 1, 15)
                },
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = "دبلوم معتمد دوليا في تخطيط النظام الغذائي",
                        FromDate = new DateTime(2013, 4, 16)
                },
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = "شهادة دبلوم معتمد دوليا في اللياقة البدنية",
                        FromDate = new DateTime(2017, 9, 18)
                },
                new Achievement
                {
                    Id = Guid.NewGuid().ToString(),
                        Title = "diploma in fitness",
                        FromDate = new DateTime(2019, 5, 27)
                },
            };
        }
        public static List<Service> GetListOfOServies()
        {
            return new List<Service>()
            {     new Service
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
                    new Service()
                    {
                        Id = "24", Title = "دراجة سبينر", Price = 320, CategoryId = "4",  Description=""
                    },
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
                    new Service()
                    {
                        Id = "30", Title = "مجدّف", Price = 25, CategoryId = "4",  Description=""
                    },
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
                    new Service()
                    {
                        Id = "34", Title = "زيت الكريل", Price = 169, CategoryId = "3",  Description=""
                    },
                    new Service()
                    {
                        Id = "35", Title = "أنافيت", Price = 170, CategoryId = "3",  Description=""
                    },
                    new Service()
                    {
                        Id = "36",
                            Title = "Trace Minerals Research",
                            Price = 79,
                            CategoryId = "3",  Description=""
                    },
                    new Service()
                    {
                        Id = "37",
                            Title = "BodyBio, E-Lyte",
                            Price = 109,
                            CategoryId = "3",  Description=""
                    },
                    new Service()
                    {
                        Id = "38", Title = "فيجا ، سبورت", Price = 163, CategoryId = "3",  Description=""
                    },
                    new Service()
                    {
                        Id = "39",
                            Title = "مضاعف الترطيب",
                            Price = 111,
                            CategoryId = "3",  Description=""
                    },
                    new Service()
                    {
                        Id = "40", Title = "NutriBiotic", Price = 54, CategoryId = "3",  Description=""
                    },
                    new Service()
                    {
                        Id = "41", Title = "زيت الكريل", Price = 169, CategoryId = "3",  Description=""
                    }
                    // new Service()
                    //{
                    //     Id = "42",
                    //     Title = "ماذا تأكل أثناء تدريب القوة؟",
                    //     Price = 11,
                    //     CategoryId = "3",
                    //     ShortDescription="وصفات للتزود بالوقود والتعافي بعد تمارين القوة",
                    //     Description="تم تصميم خطة الوجبات هذه من قبل اختصاصي تغذية مسجل، وتحديداً لدعم التغذية بعد التمرين واستعادة برنامج تدريب القوة. هذا زوج رائع مع 4 أسابيع FB Strong: Round 3. إذا كنت ترغب في معرفة المزيد حول كيفية التعافي جيدًا من برنامج تمرين مكثف، فأنت في المكان المناسب!\r\n\r\nإلى جانب خطة للوجبات والوجبات الخفيفة، نشارك كل يوم الأشياء الأساسية لمعرفة ما بعد التمرين والتطبيقات العملية لما يمكن أن يبدو عليه هذا. سنشرح أيضًا محتوى خطة الوجبة هذه وكيف يمكنك استخدامها لبناء العضلات وتزويد جسمك بالوقود للتدريب وبناء القوة.\r\n\r\nخطة وجباتنا 1-Week لتدريب القوة سهلة الاستخدام وغنية بالمغذيات ولذيذة. تم تطويره خصيصًا من قبل أخصائيي التغذية المسجلين ومطوري الوصفات ومراجعته من قبل أخصائيي الصحة العقلية على مستوى الدكتوراه."
                    //},
            };
        }

        public static List<Product> GetListOfProducts()
        {
            return new List<Product>()
            {
                new Product()
                    {
                        Id = "21", ImgUrl = "/Image/Product/Dumbbell3.jfif", Discount = 20,
                    },
                    new Product()
                    {
                        Id = "22", ImgUrl = "/Image/Product/LiveupOlympic.jpg",
                    },
                    new Product()
                    {
                        Id = "23", ImgUrl = "/Image/Product/Curved.jpg",
                    },
                    new Product()
                    {
                        Id = "24", ImgUrl = "/Image/Product/Spinner.jpg"
                    },
                    new Product()
                    {
                        Id = "25", ImgUrl = "/Image/Product/Liveup.jpg",
                    },
                    new Product()
                    {
                        Id = "26", ImgUrl = "/Image/Product/LiveupOlympic.jpg",
                    },
                    new Product()
                    {
                        Id = "27", ImgUrl = "/Image/Product/Bowflex.jpg",
                    },
                    new Product()
                    {
                        Id = "28", ImgUrl = "/Image/Product/Brobantle.jfif",
                    },
                    new Product()
                    {
                        Id = "29", ImgUrl = "/Image/Product/Adjustable.jpg",
                    },
                    new Product()
                    {
                        Id = "30", ImgUrl = "/Image/Product/rower.jpg",
                    },
                    new Product()
                    {
                        Id = "31", ImgUrl = "/Image/Product/omega.jpg",
                    },
                    new Product()
                    {
                        Id = "32", ImgUrl = "/Image/Product/Muscletech.jpg",
                    },
                    new Product()
                    {
                        Id = "33", ImgUrl = "/Image/Product/Ultima.jpg",
                    },
                    new Product()
                    {
                        Id = "34", ImgUrl = "/Image/Product/krilloil.jpg",
                    },
                    new Product()
                    {
                        Id = "35", ImgUrl = "/Image/Product/anavite.jpg",
                    },
                    new Product()
                    {
                        Id = "36", ImgUrl = "/Image/Product/Trace.jpg",
                    },
                    new Product()
                    {
                        Id = "37", ImgUrl = "/Image/Product/BodyBio.jpg",
                    },
                    new Product()
                    {
                        Id = "38", ImgUrl = "/Image/Product/Vega.jpg",
                    },
                    new Product()
                    {
                        Id = "39", ImgUrl = "/Image/Product/HydrationMultiplier.jpg",
                    },
                    new Product()
                    {
                        Id = "40", ImgUrl = "/Image/Product/NutriBiotic.jpg",
                    },
                    new Product()
                    {
                        Id = "41", ImgUrl = "/Image/Product/krilloil.jpg"
                    }
            };
        }
        public static List<Exercise> GetListOfExercise2()
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
        public static List<Exercise> GetListOfExercise()
        {
            return new List<Exercise>()
            {
             new Exercise(){Id="1" ,
                 TraningType="تدريب القوة" ,
                 BurnEstimate="50-250",
                 Title="اليوجا الصباحية للجسم بالكامل",
                 Price=0,
                 BodyFocus="الجسم بالكامل" ,
                 Detail="هذا التدفق هو واحد من المفضلة. عندما أستيقظ في الصباح ، أحب أن أبدأ يومي بتمديدات روتينية من شأنها أن تجعل دمي يتدفق ، وطاقي ، وتضبط نغمة اليوم. هذه الممارسة ستجعلك تتعرق وتساعد " +"جسمك على تخفيف الضغط في نفس الوقت. تخلق أنماط الحركة ذاكرة حسية يمكننا البناء عليها. بدءًا من نمط التنفس ، تهدف كل حركة إلى مطابقة كل شهيق أو زفير لتشجيع التنفس العميق الذي يعزز الشعور بالتوتر ، ويزيد من مستوى الطاقة والاسترخاء ، ويثبت ضغط الدم. إذا ركزت على أنفاسك ، فسوف يهدأ عقلك. فيما يلي بعض إشارات المحاذاة التي يجب وضعها في الاعتبار للسلامة في Low Lunge:\r\n\r\nابدأ في اندفاع العداء ، والساق اليمنى للأمام مع الركبة فوق الكاحل والركبة اليسرى على الأرض مع وضع الجزء العلوي من قدمك على السجادة" +
             ". ارفع الجذع ببطء وضع يديك برفق على الفخذ الأيمن. تميل الوركين إلى الأمام قليلاً ،" +
             " مع إبقاء الركبة اليمنى خلف أصابع القدم ، والشعور بالتمدد في ثني الورك الأيسر." +
             "" +
             " امسك هنا ، أو لتمتد أعمق ، ارفع الذراعين فوق الرأس ، والعضلة ذات الرأسين من الأذنين. " +
             "استمر لمدة 30 ثانية على الأقل ، ثم كرر على الجانب الآخر. تتضمن عضلات الجسم المنخفضة المستهدفة في هذا" +
             " التسلسل أوتار الركبة ، وثني الورك ، والرباعية ، والألوية. في كل مرة نتنقل فيها عبر نمط الحركة" +
             " ، سيكون هناك موقف أو وضعان مضافان إلى التسلسل. التكرار مع كل الجسم للانفتاح على كل شكل تدريجيًا.",
             Difficulty=3 , Duration=27,Image="/images/Exercise/1.png",Video="https://www.youtube.com/watch?v=w5y3Zl1F5Vs", Equipments="حصيرة ، معدات اليوجا",RatePercentage = 50,exerciseDate= new DateTime(year: 2017, month: 3, 3)},

             new Exercise(){Id="2",TraningType = "الحركة",BurnEstimate="50-250",Title="تمارين تقوية الجسم بالكامل وتمارين القلب",Price=0, BodyFocus="الجسم بالكامل" , Detail="إذا كنت تريد ممارسة تمرينات رياضية فعالة في أقل من 25 دقيقة ، فلا داعي لمزيد من البحث. هذا مزيج قصير ولطيف بين نمطي تدريب مهمين: تدريب القوة وتمارين القلب والأوعية الدموية. يتم تقديم تعديلات عالية ومنخفضة التأثير حتى تتمكن من مقابلة جسمك تمامًا في مكانه.                        عندما يتعلق الأمر بالحصول على أقصى درجات \"الضجة\" لوقتك ، يمكن أن تكون قوة الاقتران وتمارين القلب فعالة للغاية. يسمح لنا تدريب القوة ببناء العضلات الخالية من الدهون بينما تحافظ تمارين القلب والأوعية الدموية على ارتفاع معدل ضربات القلب. يعملان معًا على تعزيز عملية التمثيل الغذائي وإطلاق الطاقة لتغذية يومك!\r\n\r\nكنت مؤخرًا أحضر فصلًا لركوب الدراجات حيث قال المدرب ، \"ما هي أفضل طريقة للاحتفال بجسدك من الشعور بإطلاق الطاقة والقوة التي يحملها جسمك؟\" لا يمكن اقبل المزيد. هذا التمرين هو النوع الذي يبدو وكأنه احتفال بما يمكن أن يفعله جسمك. دون أن تكون شديدة أو معتدلة للغاية ، فإنها تهبط في المنتصف تمامًا \"للاحتفال\" التمكيني والحيوي ، إذا رغبت في ذلك.",
                 Difficulty=3 , Duration=23,Image="/images/Exercise/2.png",Video="https://www.youtube.com/watch?v=R58oVgVgRlc"  , Equipments="دمبل",RatePercentage = 50,exerciseDate= new DateTime(year: 2023, month: 3, 3)},
            new Exercise(){Id="3",TraningType="تدريب القوة",BurnEstimate="50-250" ,Title="مجموعات القوة المركبة للجزء العلوي من الجسم",Price=0, BodyFocus="الجزء العلوي من الجسم" , Detail="أولاً ، سنركز على الصدر ، بدءًا من مكابس الأرضية ثم الانتقال بسرعة إلى ذبابة الصدر والانتهاء بضغطة سحق. بعد مجموعتين من تمارين الصدر ، سننتقل إلى الخلف ، بدءًا من الصفوف المنحنية ، والانتقال إلى الذباب العكسي ، والانتهاء من صف yates. مجموعتنا التالية سوف تستهدف الذراعين ، في المقام الأول العضلة ثلاثية الرؤوس والعضلة ذات الرأسين. بالنسبة لمجموعات الترايسبس لدينا ، نحتاج فقط إلى دمبل واحد. سنبدأ المجموعات بضغطة دمبل مفردة بقبضة قريبة ، وننتقل إلى كسارة جمجمة دمبل واحدة ، ثم ننتقل إلى تمديدات ثلاثية الرؤوس العلوية. (سوف تحترق عضلاتك ثلاثية الرؤوس ، لول). مجموعتنا التالية هي إحدى الطرق المفضلة لتدريب العضلة ذات الرأسين. سنستخدم المقاييس المتساوية لدفع العضلة ذات الرأسين هنا. تمريننا الأول هو ما أحب أن أسميه تجعيد الشعر أحادي الذراع ؛ سنقوم بعمل كل ذراع على حدة مع تلك قبل الانتهاء من تمارين العضلة ذات الرأسين القياسية. هذا المزيج يعمل دائمًا مع العضلة ذات الرأسين! في مجموعتنا النهائية ، سنركز على أكتافنا. سنبدأ العمل بضغط الكتف القياسي ، والانتقال إلى صفوفنا المستقيمة ، وإنهاء المجموعة مع صف دلتا الخلفي الذي يستهدف عضلات الدالية الصغيرة - مما يجعل هذه الطريقة المثالية لإنهاء تمرين الجزء العلوي من الجسم.",
                Difficulty=4 , Duration=37,Image="/images/Exercise/3.png",Video="https://www.youtube.com/watch?v=fPlN4amOMY8" ,  Equipments="دمبل",RatePercentage = 50,exerciseDate= new DateTime(year: 2022, month: 4, 3)},
             new Exercise(){Id="4",TraningType="اليوجا" ,BurnEstimate="50-250",Title="مجموعة القلب والقوة",Price=0, BodyFocus="الجسم بالكامل" , Detail="أولاً ، سنركز على الصدر ، بدءًا من مكابس الأرضية ثم الانتقال بسرعة إلى ذبابة الصدر والانتهاء بضغطة سحق. بعد مجموعتين من تمارين الصدر ، سننتقل إلى الخلف ، بدءًا من الصفوف المنحنية ، والانتقال إلى الذباب العكسي ، والانتهاء من صف yates. مجموعتنا التالية سوف تستهدف الذراعين ، في المقام الأول العضلة ثلاثية الرؤوس والعضلة ذات الرأسين. بالنسبة لمجموعات الترايسبس لدينا ، نحتاج فقط إلى دمبل واحد. سنبدأ المجموعات بضغطة دمبل مفردة بقبضة قريبة ، وننتقل إلى كسارة جمجمة دمبل واحدة ، ثم ننتقل إلى تمديدات ثلاثية الرؤوس العلوية. (سوف تحترق عضلاتك ثلاثية الرؤوس ، لول). مجموعتنا التالية هي إحدى الطرق المفضلة لتدريب العضلة ذات الرأسين. سنستخدم المقاييس المتساوية لدفع العضلة ذات الرأسين هنا. تمريننا الأول هو ما أحب أن أسميه تجعيد الشعر أحادي الذراع ؛ سنقوم بعمل كل ذراع على حدة مع تلك قبل الانتهاء من تمارين العضلة ذات الرأسين القياسية. هذا المزيج يعمل دائمًا مع العضلة ذات الرأسين! في مجموعتنا النهائية ، سنركز على أكتافنا. سنبدأ العمل بضغط الكتف القياسي ، والانتقال إلى صفوفنا المستقيمة ، وإنهاء المجموعة مع صف دلتا الخلفي الذي يستهدف عضلات الدالية الصغيرة - مما يجعل هذه الطريقة المثالية لإنهاء تمرين الجزء العلوي من الجسم. ",
                 Difficulty=4 , Duration=23,Image="/images/Exercise/4.png",Video="https://www.youtube.com/watch?v=d8QcqQA0zIQ", Equipments="دمبل",RatePercentage=50 ,exerciseDate= new DateTime(year: 2021, month: 3, 3)},
             new Exercise(){Id="5",TraningType="تدريب القوة",BurnEstimate="50-250" ,Title="دوائر القوة الأساسية السريعة و الجوهر",Price=0, BodyFocus="جوهر" , Detail="يعد هذا التمرين القصير الذي يركز على النواة إضافة رائعة لروتين الجسم السفلي أو العلوي أو الكلي - ولكنه أيضًا خيار رائع كتمرين مستقل لحركتك الأساسية في اليوم. استخدم الإحماء أحادي الدورة لتهيئة عضلاتك الأساسية جسديًا للدوائر الصعبة ولكن القابلة للتكيف التي تليها ، ولكن ركز أيضًا على التدفق ببطء خلال كل تمرين لتنشيط اتصال العقل والعضلات لتوظيف العضلات بكفاءة.\r\n\r\n\r\n\r\n\r\nتحتوي كل دائرة على تمارين تجمع بين الإمساك المتساوي القياس وأنماط الحركة الديناميكية ولكن المتحكم فيها والتركيز على الاستقرار الأساسي. هذه التمارين لن تقوي فقط عضلات البطن (التي تشمل عضلات البطن ، الألوية ، عضلات الفخذ ، وعضلات الظهر السفلية) مع حركات الانثناء / الطحن التقليدية ، بل ستعمل أيضًا على تحسين مشاركة عضلات الجسم الكلية وتكامل الحركة (التدفق).\r\n\r\nلاحظ أنه لا يوجد سوى عدد قليل من التمارين المتعلقة بلوح في هذا التمرين ؛ لذلك ، إذا كانت لديك مخاوف من ألم الرسغ أثناء تمارين اللوح / وضعية الانبطاح ، فقد يكون هذا الروتين خيارًا رائعًا للاحتفاظ به في مجموعتك من أجل إجراءات الانتقال الأساسية المستقبلية. من الاعتبارات المهمة للجميع الحفاظ على ثنية طفيفة في الحوض أثناء تمارين وضعية الاستلقاء (الوجه لأعلى) والمنبطحة (الوجه لأسفل / اللوح الخشبي). على سبيل المثال ، أثناء الجزء الميت من تسلسل التنشيط بالإضافة إلى تمرين لوح الساعد في الدائرة رقم 1 ، تخيل أنك تقوم بإدخال عظام الفخذ إلى ضلوعك - قم بإمالة الجزء العلوي من عظام الحوض قليلاً إلى الأعلى والعودة باتجاه الجزء السفلي من القفص الصدري الخاص بك.\r\n\r\nفيما يلي بعض النصائح الإضافية لجعل هذا الروتين تجربة مُرضية لك:\r\n\r\nتشمل التعديلات لجميع التمارين تقليل نطاق الحركة و / أو ثني ركبتيك (تقصير الرافعة) لأي حركات تتضمن اختلافات في تمديد الساق.\r\nلاحظ التمارين الأكثر صعوبة بالنسبة لك وحدد الاختلافات في نطاقات الحركة والقوة وعدد التكرارات للتمارين ذات التركيز الأحادي (مثل v-ups المائلة). سيساعدك الانتباه إلى أكثر الاختلافات دقة في توجيه تركيزك أثناء المحاولات المستقبلية في هذا التمرين.\r\nلا تتردد في تكرار دائرة التبريد القصيرة لتمديد ممتد أو إضافة الامتدادات الخاصة بك لمساعدتك على العودة إلى حالة الاسترخاء والحيوية. يجب أن تشعر كما لو أن عضلاتك \"تعمل\" خلال هذا الروتين ولكن لا تزال تنتهي بعقلية \"جاهزة للتعامل مع أي شيء قادم\".\r\nيتمتع!",
                 Difficulty=3 , Duration=19,Image="/images/Exercise/5.png",Video="https://www.youtube.com/watch?v=B5ZZqBslKU0" , Equipments="حصيرة",RatePercentage=50,exerciseDate= new DateTime(year: 2021, month: 1, 3)},
             new Exercise(){Id="6",TraningType="القلب والأوعية الدموية",BurnEstimate="50-250" ,Title="دارات تقوية الجسم الكلي مع عمل التوازن",Price=0, BodyFocus="الجسم بالكامل" , Detail="\r\nتساعد التدريبات أحادية الجانب على تعزيز المشاركة الأساسية ، وبالتالي تحسين الأساس الذي تبدأ منه كل الحركات.\r\nتعمل عضلاتك معًا بشكل تآزري لتقوية السلسلة الحركية بأكملها ، مما يقلل من فرص السقوط أو العثرات الضارة المحتملة أثناء الأنشطة المعتادة للحياة اليومية.\r\nيمكن أن يساعدك العمل المتوازن في تحديد مناطق الضعف والكتل المحتملة نحو تحسين الأداء الرياضي وكذلك تحسين التنسيق لأنماط الحركة المتقدمة والتمارين التي تحركها القوة.\r\nالتدريبات مع تحديات التوازن تعمل على تحسين الاتصال بين العقل والجسم. يؤدي هذا الاتصال المعزز إلى زيادة القدرة على التحمل الذهني والفعالية الذاتية اللازمة لإكمال التدريبات الصعبة.\r\nتوفر مثل هذه التدريبات استراحة من البلى من التدريب على التأثير وتتحدى الدماغ لطرق بديلة لمعالجة وعي العقل والجسم من أجل نهج شامل للياقة البدنية.\r\nكل حركة في هذا التمرين لها درجات متفاوتة من التوازن في العمل. أثناء دورات القوة ، ستكمل كل تمرين لمدة 45 ثانية ، وهي فترة زمنية كافية لتتعرف تمامًا على كل حركة. تؤدي إضافة درجة صغيرة من التوازن أثناء هذه الحركات التي تركز على القوة إلى زيادة وقت العضلات تحت التوتر للمساعدة في بناء القوة. بمجرد الانتقال إلى موازنة قطاعات العمل ، استفد من تنشيط العضلات الذي حدث أثناء دوائر القوة لتحقيق أقصى استفادة من الفواصل الزمنية التي تبلغ دقيقة واحدة والتركيز على الاستقرار.\r\n\r\nسأعترف ، لقد استمتعت تمامًا بالحركة بسرعة أبطأ من التدريبات المعتادة مع هذه الجلسة التي تركز على التوازن. لبضعة أيام بعد ذلك ، لاحظت أن العديد من العضلات شعرت بـ \"الاستيقاظ\" مع نوع صحي جيد من القرحة التي سمحت لي بمعرفة أنني كنت أهمل مجموعات عضلية معينة وطرق التدريب. خذ وقتك مع كل حركة واستمع إلى الملاحظات التي يقدمها لك جسمك. استمتع!",
                 Difficulty=3 , Duration=45,Image="/images/Exercise/6.png",Video="https://www.youtube.com/watch?v=UzAFN61CiVQ" , Equipments="حصيرة",RatePercentage = 50,exerciseDate= new DateTime(year: 2021, month: 2, 3)},
             new Exercise(){Id="7",TraningType="تدريب القوة",BurnEstimate="50-250" ,Title="مجموعة سريعة من تمارين القلب والقوة و الجوهر  لكامل الجسم",Price=0, BodyFocus="الجسم بالكامل" , Detail="في منتصف عام 2022 ، قمت بتصوير تمرين بدا أن عددًا كبيرًا منكم يحبه حقًا. كان قسم التعليقات مليئًا بطلبات لتصوير المزيد مثله ، وعلى الرغم من أنني كنت أمتلك مجموعة من التدريبات الأخرى المطلوبة للحصول عليها أولاً ، إلا أنني لم أنس هذا التمرين (بفضل Kelli لتذكيري) وقمت ببناء علامة تجارية جديدة نسخة منه مع جميع التدريبات الجديدة. بالنسبة لأولئك منكم الذين لم يجربوا النسخة الأصلية ، يمكنك إلقاء نظرة هنا أو - بل أفضل - جرب كلاهما وأخبرني ما إذا كان هذا الإصدار الجديد يتوافق مع نفس المعيار.\r\n\r\n\r\n\r\n\r\nسواء كنت قد جربت الإصدار الأصلي أم لا ، لا يهم ، حيث إن كلاهما تمرين مستقل مصمم لروتين كامل للجسم متوازن. يحتوي هذا التمرين الذي يستغرق 26 دقيقة على كل شيء: الإحماء ، والتهدئة ، وفترات HIIT للقلب ، ومجموعات القوة ، والتمارين الأساسية ، كل ذلك في فاصل زمني سريع بأسلوب Tabata للحفاظ على هذا التمرين سريعًا.\r\n\r\nتم بناء كل مجموعة من المجموعات الأربع في هذا الروتين بنفس الطريقة تمامًا ولكن مع تمارين فريدة في كل مرة. تتكون المجموعات من تمرين HIIT من أجل انفجار القلب ، يليه تمرين قوة متعدد السلاسل لزيادة إجهاد العضلات ومكاسب القوة ، ثم ننهيها بتمرين أساسي للمتعة فقط. على الرغم من أن هذا التمرين قصير ، إلا أنه يحزم لك بالتأكيد ، خاصة إذا كنت تتحدى نفسك في مجموعات القوة.\r\n\r\nأيضًا ، إذا كنت تريد تحديًا إضافيًا لكامل الجسم ، فحاول القيام بكل من هذين التمرينين معًا أو كل منهما مرتين خلال تمرين كامل للجسم لمدة ساعة تقريبًا.",
                 Difficulty=4 , Duration=26,Image="/images/Exercise/7.png",Video="https://www.youtube.com/watch?v=3xR8ZKVALwo", Equipments = "حصيرة ، دمبل  ، بدون معدات ",RatePercentage = 50,exerciseDate= new DateTime(year: 2022, month: 5, 3)},
             new Exercise(){Id="8" , TraningType = "اليوجا" ,BurnEstimate="50-250" ,Title="تمرين الجسم الكلي السريع - 10 أو 15 دقيقة تختارها",Price=0, BodyFocus="الجسم بالكامل ", Detail="في تمرين اليوم نركز على السرعة. تم تصميم هذا التمرين القصير ولكن الفعال ليوفر لك تمرينًا جيدًا في أقصر وقت ممكن لتلك الأيام التي ربما لم تكن قد مارستها فيها على الإطلاق. لقد صممت هذا التمرين بعد نوبة أخيرة من العمل المكثف ومتطلبات الحياة التي ضربت في نفس الوقت ، مما يجعل التمرين لمدة 20 دقيقة يبدو كثيرًا.\r\n\r\nلقد صممت هذا الروتين عن قصد لاستخدامه بسهولة في تخصيصين مختلفين للوقت: إصدار سريع يأخذك خلال مقطع فيديو التمرين الكامل هذا ويبلغ أقصى حد له 15 دقيقة ، وإصدار فائق السرعة يأخذك خلال جزء \"التمرين\" لـ نصف الوقت مع قطع الطول الإجمالي إلى حوالي 10 دقائق.\r\n\r\nيتم إجراء كل هذا الروتين بنفس بنية الفاصل الزمني 20 تشغيل و 10 إيقاف لإبقائه سريعًا وبسيطًا. لقد قمت بتضمين إحماء سريع مدته 3 دقائق يتم تشغيله مباشرة في التمرين لتقليل أي توقف مؤقت غير ضروري ؛ تذكر أن هذا كله يتعلق بالكفاءة حتى نتمكن من الحصول على أفضل تدريب ممكن في أقصر وقت ممكن. لذلك ، بعد تمارين الإحماء الستة ، ننتقل مباشرة إلى التمارين الثمانية لقسم التمرين. هذا هو المكان الذي يمكنك فيه الاختيار من خلال هذه التدريبات الثمانية مرة واحدة أو مرتين. أعطي دعوة واضحة عندما ننتهي من أول تشغيل لهذه التمارين حتى تتمكن من اتخاذ قرار التخطي إلى فترة التهدئة السريعة التي تبلغ 3 دقائق والقيام بها في حوالي 10 دقائق أو إجراء التمارين مرة ثانية (كما أفعل في الفيديو) ويتم الانتهاء منه في حوالي 15 دقيقة. بهذه الطريقة يمكنك تحديد مقدار الوقت الذي يمكنك تخصيصه لهذا التمرين.\r\n\r\nهذا تمرين شامل للجسم ، لذا إذا كنت تستخدمه بعد يوم مكثف من الجزء العلوي أو السفلي من الجسم ، ففي كلتا الحالتين من المرجح أنك تستخدم بعض مجموعات العضلات نفسها. لا تقلق ، على الرغم من ذلك - ستفعل ذلك بوزن الجسم فقط حتى تتمكن من التكيف لجعل التمارين أسهل أو أصعب ، وستقوم فقط ببضع عمليات التكرار لكل منها ، لذلك لا داعي للقلق بشأن إرهاق العضلات المؤلمة.\r\n\r\nمع ذلك ، يمكن أيضًا استخدام هذا كتمرين إضافي إذا كنت تريد القيام بتمرين ثانٍ في يوم واحد. يمكن القيام بذلك إما مباشرة بعد التمرين الأول أو في وقت لاحق من اليوم للحصول على نوبة إضافية من حرق السعرات الحرارية.",
                 Difficulty=4 , Duration=23,Image="/images/Exercise/8.png",Video="https://www.youtube.com/watch?v=xafq0q5lIq4" , Equipments="دمبل" ,RatePercentage = 50,exerciseDate= new DateTime(year: 2022, month: 6, 3)},
             new Exercise(){Id="9",TraningType="تدريب القوة",BurnEstimate="50-250" ,Title="تقوية اعضاء الجسم السفلية - تمرين الفخذ لمدة 43 دقيقة",Price=0, BodyFocus="الجسم السفلي" , Detail="يمكن استخدام تمرين الجزء السفلي من الجسم هذا للتناغم أو القوة أو بناء الكتلة ، بحيث يمكنك استخدامه لما تحتاجه بالضبط. في هذا الروتين ، قمنا بتقسيم التمرين إلى ثلاث مجموعات (لا تشمل الإحماء والتهدئة). سيتم إجراء أول مجموعتين بأسلوب فاصل من 45 ثانية من النشاط مع 15 ثانية من الراحة للاستعداد للتمرين التالي. تحتوي كل مجموعة من هاتين المجموعتين الأوليين على 4 تمارين لكل منهما ، وسيتم إجراؤها بنمط A ، B A ، B بالتناوب ، بالتناوب ذهابًا وإيابًا بين اثنين من التمارين الأربعة في وقت واحد. سيتم إجراء كل تمرين لما مجموعه ثلاث مجموعات قبل الانتقال إلى التدريبات التالية ، مما يمنحنا إجمالي 12 فترة لكل مجموعة لأول مجموعتين. ستتم المجموعة الأخيرة قبل فترة التهدئة والتمدد بشكل مختلف. على الرغم من وجود أربعة تمارين مرة أخرى في هذه المجموعة ، فإننا سنقوم بدلاً من ذلك بإجراء كل تمرين لمجموعة واحدة فقط باستخدام فترات 60 ثانية على و 15 ثانية راحة. هذا المزيج من مجموعتين باستخدام ثلاث مجموعات تقليدية أكثر لكل تمرين متبوعًا بمجموعة تستخدم مجموعة نضوب واحدة سيسمح لنا بإرهاق العضلات بشكل فعال إلى الحد الذي يمكننا فيه الحصول على التمزقات الدقيقة في عضلاتنا التي تؤدي إلى زيادة القوة والكتلة.\r\nمع ما يقال ، تذكر أنه يمكنك التحكم بالضبط في النتائج التي تحصل عليها من هذا الروتين عن طريق ضبط الوزن الذي تختار رفعه ومدى سرعة القيام بكل تكرار. للحصول على تمرين أكثر تركيزًا على التنغيم ، استخدم وزن الجسم فقط أو الوزن الخفيف جدًا وتحرك بسرعة أكبر (طالما أنك لا تزال تتحرك مع التحكم ولا تستخدم الزخم للمساعدة في إكمال الحركة التي يتم إجراؤها). إذا كنت تريد التركيز أكثر على بناء الحجم الكلي للعضلات ، فحافظ على بطء حركاتك واختر أثقل وزن يمكنك التحكم فيه من خلال نطاق كامل من الحركة. مع بناء الكتلة ، يجب أن يكون هدفك هو الحصول على 90-100 ٪ من كل مجموعة من أول مجموعتين (من أي تمرين معين) قبل أن تبدأ عضلاتك في الاستسلام ويبدأ شكلك في المعاناة. يجب أن يكون الهدف من المجموعة الثالثة (الأخيرة) من كل تمرين هو إكمال 80-90٪ من الفاصل الزمني قبل أن تستسلم عضلاتك.",Difficulty=4 , Duration=43,Image="/images/Exercise/9.png",Video="https://www.youtube.com/watch?v=ABDmiZD1TDU" , Equipments = "دمبل",RatePercentage = 50,exerciseDate= new DateTime(year: 2023, month: 5, 3)},
             new Exercise(){Id="10",TraningType = "الحركة", BurnEstimate="50-250" ,Title="روتين القوة الأساسية الموزونة - روتين أوزان الدمبل في المنزل",Price=0, BodyFocus="جوهر" , Detail="\r\nإذا كنت تمارس هذا التمرين بهدف بناء القوة و / أو الكتلة ، فإليك بعض الأشياء التي يجب وضعها في الاعتبار.\r\n\r\nأولاً ، كما هو الحال مع أي تمرين قوي أو جماعي ، لا ترفع كثيرًا حتى يبدأ شكلك أو نطاق حركتك في المعاناة. إذا كنت قد قمت في أي وقت مضى بواحد من إجراءات قوتنا من أي نوع من قبل ، فمن المحتمل أنك سمعتنا بالفعل نقول هذا مرارًا وتكرارًا ؛ شكل ونطاق الحركة أكثر أهمية بكثير من مقدار الوزن الذي ترفعه عندما يتعلق الأمر بالقوة الوظيفية الخالية من الإصابات.\r\n\r\nثانيًا ، حدد الوزن الذي تستخدمه بناءً على معدل التعب لديك. يجب أن يكون هدفك هو استخدام وزن ثقيل بدرجة كافية بحيث يمكنك إجراء جميع عمليات التكرار تقريبًا بشكل مثالي ونطاق كامل من الحركة. يجب السماح للمعاناة في آخر 2 أو 3 مرات فقط لأن هذه العضلات تصبح مرهقة للغاية بحيث لا يمكن الحفاظ عليها نظيفة.\r\n\r\nثالثًا ، عندما تتخلى عضلاتك عن تلك التكرارات القليلة الأخيرة ، ابدأ في التركيز حقًا على الحركة \"السلبية\". يُعرف بشكل أكثر رسميًا باسم الانقباض غريب الأطوار ، والسالب هو النقطة التي يتغلب فيها الحمل على القوة التي يمكن للعضلة أو تقدمها والمبتدئين في إطالة العضلات. على سبيل المثال ، عند أداء تمرين الدمبل ، فإن المرحلة اللامتراكزة هي عندما يتراجع الدمبل إلى أسفل من الكتف ، مما يؤدي إلى إطالة عضلات البايسبس. من خلال التركيز على هذه الحركة ومحاولة التحكم في المرحلة اللامركزية ، يمكنك الحصول على مزيد من التمزقات الدقيقة في ألياف عضلاتك ، مما يؤدي إلى درجة أعلى من التقدم لزيادة القوة والحجم في العضلات التي تعمل. لذلك ، عندما تبدأ في الشعور بالتعب ، لا تدع هذا الوزن ينخفض فقط. إن بذل قصارى جهدك لمحاربة فقدان الوزن هو أهم جزء في روتين قوتك بالكامل.\r\n\r\nأخيرًا ، تأكد من ضبط الوزن الذي تستخدمه لكل مجموعة ، حسب الحاجة. لا تتعثر في عقلية أن ما تبدأ به يجب أن ينتهي به. بالنسبة لبعض التمارين ، قد تشعر أنه يمكنك زيادة وزنك والبعض الآخر قد تحتاج إلى إنقاصه ، وقد يكون ذلك لمجموعة واحدة فقط قبل التغيير مرة أخرى. جسمك هو آلة ديناميكية دائمة التغير ، لذلك عليك أن تكون قادرًا على التغيير والتكيف مع احتياجاته يوميًا ، إن لم يكن دقيقة بدقيقة.",Difficulty=3 , Duration=37,Image="/images/Exercise/9.png",Video="https://www.youtube.com/watch?v=pnNCuecyZnQ" , Equipments = " دمبل  ، بدون معدات ",RatePercentage = 50,exerciseDate= new DateTime(year: 2021, month: 9, 3)},



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
        //public static List<HealthyRecipe> GetListHealthyRecipe()
        //{
        //    return new List<HealthyRecipe>()
        //    {



        //        new HealthyRecipe { Id = "41", Image = "1.jpg", MealType = MealTypeTypeStatus.Dinner.ToString(), DietaryType = DietaryTypeStatus.Omnivore.ToString(), PrepTime = 50, Calories = 491, Total_Carbohydrate = 43, Protein = 35},
        //        //الثوم الطازج والليمون,سمك السلمون,طماطم كرزية,صلصة 
        //        new HealthyRecipe { Id = "42", Image = "2.jpg", MealType = MealTypeTypeStatus.Snack.ToString(), DietaryType = DietaryTypeStatus.Vegetarian.ToString(), PrepTime = 5, Calories = 156, Total_Carbohydrate = 17, Protein = 4},
        //        //موزولوز
        //        new HealthyRecipe { Id = "43", Image = "3.jpg", MealType = MealTypeTypeStatus.Lunch.ToString(), DietaryType = DietaryTypeStatus.Omnivore.ToString(), PrepTime = 50, Calories = 379, Total_Carbohydrate = 47, Protein = 32},
        //        // الدجاج المشويةوصلصة الباربكيو و وتوابل الصوديوم المنخفضةوالسكروالطماطم و شريحتين من خبز القمح الكامل المحمص و خل التفاح
        //        new HealthyRecipe { Id = "44", Image = "4.jpg", MealType = MealTypeTypeStatus.Snack.ToString(), DietaryType = DietaryTypeStatus.Vegetarian.ToString(), PrepTime = 60, Calories = 19 ,Total_Carbohydrate = 37, Protein = 5 },
        //        //100 جرام زيت كانولا, 1كوب لبن, 2بيضة,1 ملعقة صغيرةبيكنج باودر,رشةفانيلا,6 باكتسكر دايت,نصف كوبكاكاو خام,1كوب دقيق كامل الحبة,1 ملعقة صغيرةبيكنج صودا, رشةملح
        //        new HealthyRecipe { Id = "45", Image = "5.png", MealType = MealTypeTypeStatus.Snack.ToString(), DietaryType = DietaryTypeStatus.Omnivore.ToString(), PrepTime = 60, Calories = 170, Total_Carbohydrate = 43, Protein = 5},
        //        //150جرام  مكرونة,1بصلة,رشةفلفل,كوب ونصفلبن, ملعقتين دقيق, 2جبنة مثلثات خفيفة,ربع لحمة مفروم احمر, رشةملح, ملعقتين زيت, كوب ماء, 50جرامجبنة حلوم, كوب ونصف لبن,
        //        new HealthyRecipe { Id = "46", Image = "6.jpg", MealType = MealTypeTypeStatus.Lunch.ToString(), DietaryType = DietaryTypeStatus.Vegetarian.ToString(), PrepTime = 30, Calories = 180, Total_Carbohydrate = 44, Protein = 4 },
        //        //كوب ارز بسمتي,100 جرامجزر, 2 ملعقةشوفان مطحون,رشةفلفل,كوب شوربة, ربع ملعقةزبد, 1ثومة,100 جرامبسلة,100 جرامفلفل الوان, رشة ملح,رشةقرفة, 50 جرامجبن حلوم, كوب لبن
        //        new HealthyRecipe { Id = "47", Image = "7.jpg", MealType = MealTypeTypeStatus.Dinner.ToString(), DietaryType = DietaryTypeStatus.Omnivore.ToString(), PrepTime = 35, Calories = 538, Total_Carbohydrate = 79, Protein = 37 },
        //        //صدور الدجاج والجلد,الأرز البني, زبادي يوناني قليل الدسم ,الثوم, فتات خبز القمح الكامل المقرمش,طبقة البارميزان,
        //        new HealthyRecipe { Id = "48", Image = "8.jpg", MealType = MealTypeTypeStatus.Breakfast.ToString(), DietaryType = DietaryTypeStatus.Vegetarian.ToString(), PrepTime = 10, Calories = 30, Total_Carbohydrate = 10, Protein = 5  },
        //        //50 جرام بقدونس,1الليمون,1الخيار, 1التفاح,20 جرام النعناع
        //        new HealthyRecipe { Id = "49", Image = "9.png", MealType = MealTypeTypeStatus.Breakfast.ToString(), DietaryType = DietaryTypeStatus.Vegetarian.ToString(), PrepTime = 15, Calories = 110, Total_Carbohydrate = 10, Protein = 5 , },
        //        //ربع ملعقةزيت زيتون,1فلفل, ربع كوبزيتون, رشةفلفل اسود, قطعةريكفورد
        //        new HealthyRecipe { Id = "50", Image = "10.png", MealType = MealTypeTypeStatus.SideDish.ToString(), DietaryType = DietaryTypeStatus.Vegetarian.ToString(), PrepTime = 60, Calories = 40, Total_Carbohydrate = 20, Protein = 8  },
        //        //1جزر, 1 خرشوف,100 جرامكوسة,100 جرامذرة حب,ربع ملعقة نشأ, 1 بطاطس,100 جرامبسلة,100 جرامفاصوليا, نصف كوب لبن, ملعقة دقيق
        //        new HealthyRecipe { Id = "51", Image = "11.png", MealType = MealTypeTypeStatus.Lunch.ToString(), DietaryType = DietaryTypeStatus.Vegetarian.ToString(), PrepTime = 50, Calories = 125, Total_Carbohydrate = 30, Protein = 5 , },
        //        // ملعقةخميرة,ملعقتان دقيق ابيض,50 جرامشوفان مطحون,ملعقةخل,رشة بيكنج بودر,50 جرامطماطم,50 جرامفلفل الوا,50 جرامبصل,50 جرامزيتون,50 جرامذرة مسلوق,100 جرامجبن حلوم,فصثوم مفروم,ملعقةسكر,ملعقتانزيت زيتون,
        //        new HealthyRecipe { Id = "52", Image = "12.png", MealType = MealTypeTypeStatus.Snack.ToString()    , DietaryType = DietaryTypeStatus.Omnivore.ToString(), PrepTime = 30, Calories = 66, Total_Carbohydrate = 36, Protein = 5 , },
        //        //كوب دقيق ذرة اصفر,نصف كوب دقيق ابيض,1 بيضه,كوب لبن,رشه ملح,3معالقزيت كانولا او زيت نباتي,3 معالق سكر بني او دايت,معلقةبيكنج بودر,نصف معلقةفانيليا سائلة
        //        new HealthyRecipe { Id = "53", Image = "13.jpg", MealType = MealTypeTypeStatus.Lunch.ToString(), DietaryType = DietaryTypeStatus.Vegetarian.ToString(), PrepTime = 30, Calories = 110, Total_Carbohydrate = 45, Protein = 7 , },
        //        //250 جرام دجاج,2فلفل الوان,1بصلة,ملعقتين صلصلة صحية,100 جراممكرونة
        //        new HealthyRecipe { Id = "54", Image = "14.jpg", MealType = MealTypeTypeStatus.Lunch.ToString(), DietaryType = DietaryTypeStatus.Omnivore.ToString()   , PrepTime = 60, Calories = 145, Total_Carbohydrate = 30, Protein = 17 , },
        //        // كوبارز بني,1بصلة,1دجاجة,رشة بهارات صحيحة,رشة ملح,رشة كمون,رشة فلفل اسود,رشة بهارات مشكلة,رشة بصل بودر,رشة قرفه مطحونه,رشةلومي مطحون,رشةكزبرة مطحونه,30 جرام مكسرات
        //        new HealthyRecipe { Id = "55", Image = "15.png", MealType = MealTypeTypeStatus.SideDish.ToString(), DietaryType = DietaryTypeStatus.Vegetarian.ToString(), PrepTime = 15, Calories = 25, Total_Carbohydrate = 10, Protein = 8     },
        //        //كوب فاصوليا حمراء,كوب فاصوليا بيضاء,كوب فاصوليا خضراء,1بصلة خضراء,2 ملعقةبقدونس,ملعقةزيت زيتون,ملعقةخل,1ثومة,ملعقةماستردة,ملعقةفلفل اسود,ملعقةملح
        //        new HealthyRecipe { Id = "56", Image = "16.jpg", MealType = MealTypeTypeStatus.Snack.ToString(), DietaryType = DietaryTypeStatus.Omnivore.ToString(), PrepTime = 30, Calories = 150, Total_Carbohydrate = 25, Protein = 5 },
        //        // نصف لتر لبن,4 باكيتسكر دايت,2 ملعقةجوز الهند,2 ملعقة ماء ورد,ملعقةنشا,1فانيليا
        //        new HealthyRecipe { Id = "57", Image = "17.jpg", MealType = MealTypeTypeStatus.Dinner.ToString(), DietaryType = DietaryTypeStatus.Vegetarian.ToString(), PrepTime = 20, Calories = 50, Total_Carbohydrate = 15, Protein = 4 },
        //        //1ملفوف,1جزر,3المايونيز الصحي,1زبادي كبير,ملعقة صغيرة عسل ابيض,3 ملعقاتخل,ربع ملعقةملح
        //        new HealthyRecipe { Id = "58", Image = "18.jpg", MealType = MealTypeTypeStatus.Breakfast.ToString(), DietaryType = DietaryTypeStatus.Omnivore.ToString(), PrepTime = 30, Calories = 65, Total_Carbohydrate = 40, Protein = 15 },
        //        //1بصلة,300 جراملحمة المفرومة,1بيضة, رشة فلفل أسمر,ملعقتانزيت,ملعقةبصل بودر,حسب الرغبةبهارات,حسب الرغبةبقدونس
        //        new HealthyRecipe { Id = "59", Image = "19.jpg", MealType = MealTypeTypeStatus.Breakfast.ToString(), DietaryType = DietaryTypeStatus.Omnivore.ToString(), PrepTime = 15, Calories = 34, Total_Carbohydrate = 15, Protein = 0 },
        //        // ملعقةسكر دايت,1تفاح,2القرنفل ,عودالقرفة
        //        new HealthyRecipe { Id = "6-", Image = "20.jpg", MealType = MealTypeTypeStatus.Breakfast.ToString(), DietaryType = DietaryTypeStatus.Omnivore.ToString(), PrepTime = 240, Calories = 45, Total_Carbohydrate = 15, Protein = 7 }
        //        //نصف كيلوكريز,3 معالقسكر ستيفيا,نصف ملعقة صغيرةفانيلا سائلة,رشة قرفة,ربع كوبعصير ليمونة,ملعقةعسل

        //    };
        //}
        public static List<HealthyRecipe> GetListHealthyRecipe2()
        {
            return new List<HealthyRecipe>()
            {

                new HealthyRecipe {
                    Id = "61",
                    Image = "/Images/HealthyRecipes/1.jpg",
                    MealType = "وجبة الإفطار",
                    DietaryType = "حيواني",
                    PrepTime = 12,
                    Calories = 250,
                    Total_Carbohydrate = 6,
                    Protein = 24,
                    Ingredients="بيضات كاملة,100,غرام\n"+" الديك الرومي المطحون الخالي من الد,60,غرام\n"+
                    "توابل التاكو ,2,غرام\n"+" الفلفل الأخضر الجرس,20,غرام\n"+" الفلفل الأحمر,20,غرام\n"
                    +" البصل الأحمر,20,غرام\n"+"صلصة,15,غرام\n"+" زبادي يوناني قليل الدسم,15,غرام\n"+" البصل الأخضر,10,غرام\n",
                    PreparationMethod="دهن مقلاة غير لاصقة بقليل من بخاخ تحرير المقلاة وقم بالتسخين المسبق على حرارة متوسطة إلى عالية.\r\nبمجرد أن يسخن , افرم الديك الرومي المطحون في المقلاة ورشي توابل التاكو مع التقليب حتى تمتزج. يُطهى لمدة 3-4 دقائق مع التحريك من حين لآخر أو حتى ينضج تمامًا ويصبح لونه بنيًا جيدًا. بمجرد طهيه , باستخدام ملعقة مثقوبة , أخرج الديك الرومي من المقلاة وضعه جانبًا على طبق.\r\n, دهن المقلاة برفق مرة أخرى وعاد إلى درجة حرارة متوسطة إلى عالية. يُضاف الفلفل والبصل ويُطهى لمدة 3-4 دقائق أو حتى ينضج.\r\n, بمجرد أن تصبح الخضار طرية , أعد الديك الرومي المطحون إلى المقلاة وقلّب المزيج. باستخدام ملعقة مشقوقة , تُرفع الخضار والديك الرومي المفروم من المقلاة , ويُترك جانباً على الطبق , ويُتبل قليلاً بالملح والفلفل حسب الرغبة.\r\n, أعد المقلاة إلى درجة حرارة متوسطة إلى عالية. بمجرد أن يسخن , أضف البيض ولفه لتغطي قاع المقلاة.\r\n,يُغطّى ويُطهى لمدة 2-3 دقائق أو حتى يصبح البيض متماسكًا وينضج تمامًا. أخرج البيضة من المقلاة بحذر وانقلها إلى طبق التقديم.\r\nوزعي البيض بالديك الرومي والخضار والصلصة. دولوب مع الزبادي ورش البصل الأخضر قبل التقديم.",
                    Description="<p> <strong> الطبق </strong> </p>\r\n<p> فاهيتا على الفطور؟ تتحدى! مستوحاة من تلك الفاهيتا الأزيز على غرار المطاعم ، قمنا بإعادة إنشاء نسخة مبسطة مثالية لصباح أيام الأسبوع المزدحمة - كاملة مع خيارات الإعداد المسبق لتوفير المزيد من الوقت. بدلاً من التورتيلا ، ابتكرنا مفهوم الأومليت المفتوح الوجه. الأومليت مليء بالديك الرومي المحمر والمتبل بالإضافة إلى الفلفل والبصل المقلي. القليل من الصلصة والزبادي قليل الدسم والبصل الأخضر يكمل جمالية الفاهيتا. إذا كنت ترغب في جعل فاهيتا الإفطار نباتيًا ، فلا تتردد في استبدال الديك الرومي ببديل اللحم المفروم المفضل لديك (أو التوفو المفتت). </p>\r\n<p> <strong> نصائح للتحضير المسبق / لتوفير الوقت </strong> </p>\r\n<p> يمكن طهي الديك الرومي والخضار (الفلفل والبصل) وتبريدهما قبل يوم أو يومين. أثناء طهي البيض ، قم بإعادة تسخين مزيج الديك الرومي والخضروات في الميكروويف (أو في مقلاة أخرى) ، ثم قم بتجميعها حسب التعليمات. </p>",
                    Price=0,
                    RatePercentage=0,
                    ShortDescription="",
                    Title=" فاهيتا أوميليت مفتوح الوجه مع تركيا المطحونة والفلفل والبصل",
                },

                 new HealthyRecipe {
                    Id = "62",
                    Image = "/Images/HealthyRecipes/2.jpg",
                    MealType = "طبق جانبي,وجبة غداء",
                    DietaryType = "حيواني",
                    PrepTime = 15,
                    Calories = 269,
                    Total_Carbohydrate = 30,
                    Protein = 26,
                    Ingredients=" الريحان الطازج,2,غرام\n"+" خيارة,60,غرام\n"+
                    " جبن كوخ قليل الدسم ,2,غرام\n"+"  كعكة القمح الكامل الإنجليزية ,20,غرام\n"+" الخل البلسمي ,20,غرام\n"
                    +"  البارود الأسود,20,غرام\n"+"التوابل الإيطالية,15,غرام\n"+" صدر دجاج,15,غرام\n"+"زيت الزيتون,10,غرام\n",
                    PreparationMethod=", قم بالتسخين المسبق لشواية الغاز إلى درجة حرارة متوسطة إلى عالية أو الفحم المسبق لشواية الفحم., صدر الدجاج يجفف بالمناشف الورقية ويوضع على طبق ويتبل قليلا بالتوابل الإيطالية والفلفل الأسود والخل البلسمي ورشة ملح., ضع الدجاج جانبًا لينقع لمدة 10 دقائق بينما تسخن الشواية مسبقًا., بمجرد أن تصبح الشواية ساخنة ، أضيفي الدجاج واطهيها لمدة 2-3 دقائق لكل جانب أو حتى تفحم قليلاً وتنضج بالكامل. تُرفع عن الشواية وتترك جانباً لترتاح قبل التقطيع., ملعقة وافرد الجبن القريش على الكعك الإنجليزي المحمص. يُغطى التوست المُجهز بشرائح الدجاج وشرائح الخيار والريحان الطازج. الموسم الى الذوق مع الملح والفلفل.",
                    Description="<p> <strong> الطبق </strong> </p>\r\n<p> مستوحاة من شطائر الشاي الإنجليزي التقليدية ، تستخدم هذه النسخة اللطيفة الخيار الكلاسيكي والجبن بينما يتم تعزيزها بالبروتين من خلال صدور الدجاج الخالية من الدهون والمشوية والمتبل. يكمن السر في بناء وجبة ديناميكية ولذيذة في إضافة طبقة من النكهة والقوام. يتناقض الجبن الدسم قليل الدسم بشكل جيد مع شرائح الخيار الطازجة. الدجاج - المتبل بالخل البلسمي والتوابل الإيطالية - هو إضافة لذيذة لهذه الخبز المحمص ، يضفي نكهة حلوة ومالحة ومدخنة رائعة. قم بإقران هذه الوصفة مع أي نوع من أنواع الحساء أو السلطات التي تركز على الخضار للحصول على وجبة متوازنة - مثالية للغداء أو العشاء! </ p>\r\n<p> <strong> الاستعداد للأمام ونصيحة لتوفير الوقت </strong> </p>\r\n<p> لتوفير الوقت أو كخيار مسبق ، لا تتردد في نقع الدجاج طوال الليل. يمكنك أيضًا تتبيل صدور الدجاج وشويها وتبريدها وتقطيعها إلى شرائح لتوفير المزيد من الوقت. </p>",
                    Price=0,
                    RatePercentage=0,
                    ShortDescription="",
                    Title="خيار وجبن كوخ وخبز محمص دجاج مشوي مع الخل البلسمي والأعشاب الإيطالية",
                },


                  new HealthyRecipe {
                    Id = "63",
                    Image = "/user/images/pexels-toni-cuenca-616833.png",
                    MealType = "مشروبات",
                    PrepTime = 30,
                    Calories = 273,
                    Total_Carbohydrate = 43,
                    Protein = 20,
                    Ingredients=" الريحان الطازج,2,غرام\n"+" خيارة,60,غرام\n"+
                    " جبن كوخ قليل الدسم ,2,غرام\n"+"  كعكة القمح الكامل الإنجليزية ,20,غرام\n"+" الخل البلسمي ,20,غرام\n"
                    +"  البارود الأسود,20,غرام\n"+"التوابل الإيطالية,15,غرام\n"+" صدر دجاج,15,غرام\n"+"زيت الزيتون,10,غرام\n",
                    PreparationMethod="  <ol>\r\n                    <li>اغسلي جميع الخضار والفواكه وقطعيها لقطع متوسطة يسهل وضعها في الخلاط.</li>\r\n                    <li>ضعي الخضار والفواكه في العصارة أو الخلاط الكهربائي واحداً تلو الآخر واخلطيها لمدة أربع دقائق حتى تتجانس المكونات.</li>\r\n                    <li>قدمي العصير مبرداً واحفظيه في الثلاجة إذ يمكن تناوله خلال سبع أيام.</li>\r\n                  \r\n                </ol>",
                    Description=" <p class=\"fs-6\">\r\n                            تساعد على تنظيف الجسم من السموم وتخليصه من الأمراض المختلفة، إذ يمكن عمله\r\n                            بطرق عدة باستخدام أنواع مختلفة من الخضار والفواكه، وهذه المشروبات تساعد في\r\n                            حميات إنقاص الوزن وتعزز الصحة العامة، هنا سنقدم طريقة عمل عصير ديتوكس\r\n                        </p>",
                    DietaryType = "نباتي",

                    Price=0,
                    RatePercentage=5,
                    ShortDescription="",
                    Title="مشروب الديتوكس الأخضر",
                },


            };
        }
        public static List<Tracking> GetListOfTracking()
        {
            return new List<Tracking>()
            {
                new Tracking(){Id="1",Iscomplete=true , Exercies_programId="1" , Order_DetailsId="1"},


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

                //new MealPlans()
                //{
                //    Id = "42",
                //    Numsubscribers= 105,
                //    Length= 1,
                //    DietaryType="اكلة اللحوم",
                //    MealType="الإفطار والغداء والعشاء والوجبات الخفيفة",
                //    AvgRecipeTime=13,
                //    Image= "./Images/MealPlan/4.jpg",

                //}
                //,new MealPlans()
                //{
                //    Id = "43",
                //    Numsubscribers= 105,
                //    Length= 1,
                //    DietaryType="اكلة اللحوم",
                //    MealType="الإفطار والغداء والعشاء والوجبات الخفيفة",
                //    AvgRecipeTime=10,
                //    Image= "./Images/MealPlan/4.jpg",

                //},new MealPlans()
                //{
                //    Id = "44",
                //    Numsubscribers= 105,
                //    Length= 1,
                //    DietaryType="اكلة اللحوم",
                //    MealType="الإفطار والغداء والعشاء والوجبات الخفيفة",
                //    AvgRecipeTime=20,
                //    Image= "./Images/MealPlan/4.jpg",

                //},

            };
        }

        public static List<Files> GetListFiles()
        {
            return new List<Files>()
            {
                
                 new Files()
                {
                    Id="1",
                    Path="/Images/HealthyRecipes/1.jpg",
                    HealthyId= "61",
                },
                  new Files()
                {
                    Id="2",
                    Path="/Images/HealthyRecipes/img61.jpg",
                    HealthyId= "61",
                },
                   new Files()
                {
                    Id="3",
                    Path="/Images/HealthyRecipes/im61.jpg",
                    HealthyId= "61",
                },
                    new Files()
                {
                    Id="4",
                    Path="/Images/HealthyRecipes/2.jpg",
                    HealthyId= "62",
                },
                     new Files()
                {
                    Id="5",
                    Path="/Images/HealthyRecipes/img62.jpg",
                    HealthyId= "62",
                },
                      new Files()
                {
                    Id="6",
                    Path="/Images/HealthyRecipes/im62.jpg",
                    HealthyId= "62",
                }, new Files()
                {
                    Id="7",
                    Path="/user/images/pexels-toni-cuenca-616833.png",
                    HealthyId= "63",
                }, new Files()
                {
                    Id="8",
                    Path="~/user/images/224347.png",
                    HealthyId= "63",
                }, new Files()
                {
                    Id="9",
                    Path="/user/images/224664.png",
                    HealthyId= "63",
                },
            };
        }



    }
}
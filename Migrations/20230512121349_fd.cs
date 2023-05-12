using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class fd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "900c6ab5-3e79-4199-b99c-18075791cc57", "56974e9a-88bc-4e87-a707-0493b3d430df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df7d54f6-5aca-4b9d-89d9-173ab92c9fa4", "b6ff18d4-0e7b-453e-8735-97ecda4207b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6a1c828d-6fba-4128-9b43-7d23a6ec2ef0", "c1daee4a-de78-470d-9077-ad5907192567" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be17b9f7-053b-40af-8d2c-7502b2487f9a", "68455915-b527-4fbb-8e50-fe20984cca47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94d9898e-60e6-4f1b-b7f3-dca1f71b2719", "60b5c67c-b577-4a31-a17b-ff84f42f734e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11615c1e-f8d1-4b5a-9299-0cc6963b89b3", "6bcd8adf-95d3-4ab2-98b0-f8e9cc603af5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01de8933-e90b-4990-bba3-5419a3e2dde0", "2163c49e-a04f-4586-a914-37a58c81d469" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e94fc6b4-03d1-41e7-8a25-d992a1f2767d", "ea4603b6-165b-497d-b204-ad1a0883ea44" });

            migrationBuilder.InsertData(
                table: "TblConsultation",
                columns: new[] { "Id", "CategoryId", "Description", "PostDate", "Title", "UserId", "ViewsNumber" },
                values: new object[,]
                {
                    { "1", "13", "عمري 32 سنة، عاطل أعزب، توقفت عن لعب كرة القدم لمدة شهر، والحمد لله أشعر بتحسن كبير في الركبة، واختفاء الألم، ولكن لاحظت أنني حينما أمارس تمرين تقوية الفخذ (بوضع ثقل على القدم ورفع القدم لمنتصف الساق المنثنية وإخراجها)، أشعر بألم خفيف من حين لآخر لمدة يوم أو يومين، وعندما أتوقف عن التمارين لأيام يختفي الألم بصورة كبيرة جداً.\r\n\r\nفهل لقلة الحركة وكثرة الجلوس دور في الإصابات المختلفة، مثل إصابة القدم والركبة والكتف والكعب والتي أتعرض لها؟ فأنا كثير الاستلقاء على السرير، وقليل الحركة جداً. وفي الفترة الأخيرة أصبحت أمشي من نصف ساعة لساعة ونصف في اليوم، وهل لطريقة المشي من فرد الجسم ورفع الرأس وسرعة المشي دور في الاستفادة من المشي؟", new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عند وضع ثقل على القدم ورفعه أشعر بألم في الركبة، فهل السبب قلة الحركة؟", "5", 0 },
                    { "10", "14", "أنا فتاة عمري 24 عاما, أعاني من نقص الوزن, وأريد أن يزيد وزني، جربت بعض الأدوية ولكن لم أر أي فائدة, مع العلم أنني لا أشكو من أي مرض والحمد لله.\r\n\r\nوزني 41 كيلو, وطولي 150 سم, سمعت عن حبوب اسمها سبروفيتا (cypro-vita)\r\nما رأيكم فيها؟ وهل لها أضرار؟\r\n", new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(1152), "هل دواء سبروفيتا ناجع لزيادة الوزن؟", "6", 0 },
                    { "2", "13", "<p>أسأل عن الرياضة، حيث إني قرأت وسمعت عن فوائدها، ولكني لا أجد المكان الملائم لممارسة الرياضة، وهي (الجري) إلا في البيت، حيث إني أجري حول الحديقة، وهي على شكل مستطيل، وبطول خمس وأربعين خطوة، أي طول المسافة التي حول المستطيل أي مجموع الأربعة أضلاع، يساوي خمساً وأربعين خطوة.<br><br>هل يمكن الجري في هذه المسافة؟ علماً بأن نصف المسافة أرض صلبة من الإسمنت، فهل الجري على الإسمنت يسبب لي أضراراً؟ خاصة في مفاصل الركبة.<br><br>إذا كان يسبب أضراراً فهل المشي على الإسمنت يسبب أضراراً كذلك؟ وما هي السرعة والمدة الزمنية التي يجب أن أستغرقها في المشي للحصول على الفوائد الصحية؟<br><br>أيهما أفضل المشي أم الجري؟ وما مدة وسرعة كل منهما؟ وهل إذا مارست الجري في الصباح وفي يوم من الأيام لم أتمكن من الجري، هل يمكن أن أجري في المساء لأعوض أم يجب أن أستمر على وقت معين؟<br><br>ما هي مواصفات حذاء الجري؟ هل الحذاء الواطي أم العالي أفضل؟ حيث إني لم أجد حذاء ذا مرونة جيدة.</p>", new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "رياضة المشي والجري..المدة والمسافة والحذاء المناسب!", "5", 0 },
                    { "3", "14", "عمري 29 سنةً، وطولي 155 سم، وزني 66 كجم، أجريت حميةً غذائيةً، ونزل وزني من 75 إلى 66 كجم، وأحاول الآن أن أصل إلى وزني الطبيعي 54 كجم، لكن أحياناً أشتهي تناول الحلوى، فما هو مقدار الحلوى الذي أستطيع أن أتناوله كل مرة أو أسبوعياً؟ وهل أستطيع أن آكل القشطة مع ملعقة عسل طبيعي في الصباح الباكر، أم أن هذا يزيد الوزن؟ وهل يمكن أن آكل في أوقات متباعدة قطعة بيتزا أو همبرجر؟", new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "إمكانية أكل الحلويات والوجبات السريعة بكميات قليلة لمن يعالجون بالحمية الغذائية", "5", 0 },
                    { "4", "14", "ما هو الطعام الصحي للعمال الذين يعملون أعمالاً شاقة بشكل مستمر؟", new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "ما هو الطعام الصحي للعمال الذين يعملون أعمالاً شاقة بشكل مستمر؟", "4", 0 },
                    { "5", "13", "أنا نحيفة جداً، حيث أن طولي 152 ووزني 43 وأنا بعمر 25 سنة، أخجل من نحافتي، تناولت حبوب ميساغور لمدة سنة، وتناولت الخميرة، ولم أستفد منها.\r\n\r\nأنا الآن أتناول حبوب زيت كبد الحوت، وكذلك الدبس، تعبت من نحافتي، فقد كنت سابقاً نحيفة لكن جسمي مقبول، ويمدحني الكثير، لكن الآن زادت نحافتي، أرجوكم أريد أسماء حبوب تزيد من وزني، وأسماء مكملات تمد جسمي بالطاقة والنشاط، ودعواتكم لي.", new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(1125), "أريد أسماء حبوب ومكملات غذائية تزيد من وزني", "6", 0 },
                    { "6", "13", "أنا فتاة أبلغ من العمر 15 سنةً تقريباً، وطولي 1.73 ، ووزني 65 كغم، وأقوم بعمل حمية غذائية لأصل إلى 58 كغم، مشكلتي هي أنني أريد حلاً لطولي -أريد أن أقصر-؛ فكل الفتيات اللواتي بعمري أقصر مني، وأنا بصراحة لا أحب طولي، وهل سأطول أكثر أم لا؟\r\n\r\nوجزاكم الله خيراً.", new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(1131), "قامتي طويلة وكل صديقاتي أقصر مني، فهل يمكن تقليل طولي؟\r\n", "6", 0 },
                    { "7", "14", "<p>السلام عليكم ورحمة الله وبركاته.<br />\r\nرزقني الله طفلاً منذ أسبوعين، ولكن زوجتي تشتكي أن وزنها زاد جداً؛ لأنها في فترة الحمل كانت تأكل كثيراً حتى زاد وزنها، وتريد أن يعود جسمها كما كان، فقلت لها اشربي شاياً أخضر في الصباح، ولكنها تعتقد أن ما أصابها بسبب الرضاعة، فبماذا تنصحون؟<br />\r\nوما هي الأطعمة التي يفضل تناولها حتى يعود جسمها كما كان؟ وما هي الأطعمة التي تزيد من إفراز اللبن للطفل؟<br />\r\n&nbsp;</p>", new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(1136), "ما هي الأطعمة التي تساعد على عودة جسم المرضع كما كان؟\r\n", "5", 0 },
                    { "8", "14", "لقد تعبت من أطباء التغذية ومن نصائحهم المتناقضة، فكل طبيب ينقض كلام الذي سبقه، فأريد منكم نصائح يسيرة لتخفيف الوزن، والكرش، والصدر المترهل، علماً بأن وزني 68 كيلو، وطولي 160 سنتميتر.", new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(1140), "النصائح النافعة للتخلص من الوزن الزائد", "5", 0 },
                    { "9", "14", "<p>عمري 27 سنة، ووزني 86 كجم، وطولي 175سم.<br />\r\nأمارس رياضة المشي يومياً بمعدل ساعة ونصف يومياً موزعة بين بعد الفجر وبعد العصر، بالإضافة إلى ممارستي لكرة القدم بالأسبوع بمعدل 10 ساعات.<br />\r\nعلى ضوء هذه البيانات كم سعرة حرارية لازمة لجسمي بحيث لا يحدث زيادة في الوزن؟ حيث إنني سريع التغير في الجسم إن لم أحافظ على الرياضة المتواصلة؟ وما هي المشروبات المفيدة لإزالة الدهون من الجسم؟<br />", new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(1145), "عدد السعرات الحرارية لإعطاء التوازن للجسم", "3", 0 }
                });

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "42",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "43",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "44",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "45",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "46",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "47",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "48",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "49",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "50",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "51",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "52",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "53",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "54",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "55",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "56",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "57",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "58",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "59",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "60",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 13, 46, 888, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.InsertData(
                table: "TblReplyconsultation",
                columns: new[] { "Id", "Reply", "UserId", "consId" },
                values: new object[,]
                {
                    { "1", "<p>بسم الله الرحمن الرحيم<br>السلام عليكم ورحمة الله وبركاته، وبعد:<br><br>كونك تمشي في الآونة الأخيرة من نصف ساعة إلى ساعة ونصف دون الشعور بالألم، فهذا أمر جيد، عليك المداومة عليه، والألم الذي تشعر به عند وضع ثقل على قدمك ورفعه أمر مرتبط بضعف اللياقة البدنية، وليس بإصابة في الركبة أو القدم، وأي شخص في النادي الرياضي إذا وضع ثقلًا على قدمه سوف يشعر بنوع من الألم قل أو كثر.<br><br>والمشي في اليوم 10000 خطوة يكفي جدًا لزيادة اللياقة البدنية، ولتحريك المفاصل والشفاء من الإصابات، ولا بأس بتحريك الذراعين، والنظر إلى الأمام أثناء المشي، والالتزام بالصلوات والنوافل، فهي رياضة في حد ذاتها، ونؤكد دائماً على ضبط مستوى فيتامين D، وفحص صورة الدم CBC، والتغذية الجيدة، والاستحمام بالماء البارد، إذا استطعت ذلك لكي تنشط الدورة الدموية.<br><br>وفقك الله لما فيه الخير.</p>", "2", "1" },
                    { "10", "<p>بسم الله الرحمن الرحيم<br />\r\nلسلام عليكم ورحمة الله وبركاته، وبعد:<br />\r\nفواضح من طولك ووزنك أن هناك زيادة في وزنك بالنسبة لطولك، فأعلى نسبة طبيعية لوزنك بالنسبة لطولك هي 77 كيلو، وحتى لو تجازونا ذلك لـ80 فإن هناك ما زالت عدة كيلوات للفقدان، وأنت تقول إنك تريد كم سعرة حرارية بحيث لا يزيد وزنك.<br />\r\n<br />\r\nجسم الإنسان يحتاج إلى &quot;1&quot; من السعرات الحرارية لكل كيلو جرام من وزنه في كل ساعة زمنية ليعمل للاحتراق الداخلي، أي أن الجسم يحتاج إلى هذه السعرات لكي تعمل جميع أعضائه وأجهزته، مثل جهاز التنفس وضخ الدم والتفكير.<br />\r\n<br />\r\nفالإنسان الذي يزن: 86 كيلو جراماً يحتاج إلى 86&times;1&times;24=2024 سعرةً حراريةً خلال أربع وعشرين ساعة.<br />\r\n<br />\r\nهذا الرقم هو ما يحتاج إليه الجسم ليعمل دون أي مجهودات إضافية، ولحساب السعرات التي يحتاج إليها الإنسان ليعمل هناك ثلاثة معدلات تختلف باختلاف الجهد الذي يبذله الإنسان:<br />\r\n<br />\r\nفإذا كان هذا الإنسان قليل الحركة ( كأن يعمل في مكتب) يكون معدل احتياجه هو 1.3 سعرة حرارية لكل كيلوجرام من وزنه، ويكون حساب احتياجه كالتالي:<br />\r\n86&times;24&times;1.3=2683 سعرةً حراريةً.<br />\r\n<br />\r\nوإذا كان يبذل مجهوداً متوسطاً، فإن معدل احتياجه يزيد ليصبح 1.4 لكل كيلو جرام من وزنه، ويكون حساب احتياجه كالتالي: 86X1.4X24=2890 سعراً حرارياً.<br />\r\n<br />\r\nوإما إذا كان يعمل عملاً مجهداً جسدياً فإنه يحتاج إلى 1.5 سعرًا حراريًا لكل كيلو جرام من وزنه .. ويكون حساب احتياجه كالتالي: 86X1.5X24=3096 سعراً حراريا.<br />\r\nالمشي للساعة الواحدة 13- 300 سعرة حرارية.<br />\r\nالـسـباحة 200 - 700 سعرة حرارية.<br />\r\nركوب الدراجة 180- 300 سعرة حرارية.<br />\r\nأما كرة القدم فتصرف 10 سعرات لكل دقيقة.<br />\r\n<br />\r\nأما عن المشروبات المفيدة؛ ومنها: الزنجبيل، فهو مفيدٌ جداً للجسم، ويمكن أخذ كوبٍ من مشروب الزنجبيل مساءً.<br />\r\n<br />\r\nومن المشروبات المفيدة أيضاً الشاي الأخضر، وهو يساعد على تسريع عملية استقلاب الغذاء؛ لأن تأثيره المضاد للأكسدة يساعد الكبد على أداء وظيفته بشكلٍ أكثر فعالية، كما أن شرب الشاي الأخضر ثلاث مرات يومياً يحرق 200 سعرة حرارية إضافية يومياً، ولقد وجد الأشخاص الذين يتناولون الشاي الأخضر أن الطاقة لديهم تعزَّزَت بشكلٍ كبير.<br />\r\n<br />\r\nوعلاوةً على ذلك؛ فإن الشاي الأخضر يخفِّض مستوى السكر في الدم، والذي يعتبر مسئولاً عن خزن الجلوكوز على شكل شحوم، ولذا فإن تخفيض مستوى السكر يُخفض أيضاً مستوى الشحوم المخزونة في الجسم.<br />", "9", "9" },
                    { "11", "<p>بسم الله الرحمن الرحيم<br />\r\nالسلام عليكم ورحمة الله وبركاته وبعد،،،<br />\r\nهذا الدواء يحتوي على ما يلي:</p>\r\n\r\n<ul>\r\n	<li>&nbsp;سيبروهيبتادين هيدروكلورايد.</li>\r\n	<li>فيتامين (أ).</li>\r\n	<li>فيتامين (د3).</li>\r\n	<li>&nbsp;ثيامين مونوترات(فيتامين ب1).</li>\r\n	<li>&nbsp;ريبو فلافين(فيتامين ب2).</li>\r\n	<li>&nbsp;بيريدوكسين هيدروكلورايد(فيتامين ب6).</li>\r\n	<li>&nbsp;سيانو كوبالامين (فيتامين ب 12).</li>\r\n	<li>&nbsp;نياسيناميد.</li>\r\n	<li>-حمض الأسكوربيك (الفيتامين سي).</li>\r\n</ul>\r\n\r\n<p>فكما ترين فهو مجموعة من الفيتامينات مع دواء سيبروهبتادين Cyproheptadine, وهذا الدواء هو يستعمل السيبروهيبتادين لعلاج بعض الحالات المرضية, ومنها على سبيل المثال لا الحصر:<br />\r\nردة فعل الحساسية مثل حساسية الأنف, الكوابيس, فرط التعرق.<br />\r\nيسبب استخدام السيبروهيبتادين الأعراض الجانبية التالية:<br />\r\nالدوار, غشاوة الرؤية, الإمساك, جفاف الفم والحلق, أو الأنف, سرعة الهيجان, الغثيان, العصبية والقلق, التململ.<br />\r\nومن أعراضه الجانبية هو فتح الشهية, فهذا هو سبب استخدامه في النحافة, أي لأنه يفتح الشهية, والفيتامينات الأخرى موجودة في كثير من المركبات التي تحتوي على الفيتايمنات, فهو ليس دواء جديدا في الحقيقة, وإنما وضعوا في هذا المركب السيبروهيباتادين الذي يستخدم من سنوات طويلة, وموجود في الأسواق, ووضعوا معه فيتامينات.<br />\r\nفيمكن استخدامه, تبدئين بحبة واحدة لعدة أيام؛ لأنه قد يسبب الأعراض الجانبية التي ذكرناها, ومن ثم يمكن أن تزيدي الجرعة بعد ذلك إلى حبتين, فإن تحسنت الشهية يمكن أن تستمري على حبيتين, ويمكن أن تزيدي إلى ثلاث حبات إن لزم الأمر</p>", "9", "10" },
                    { "2", "<p>بسم الله الرحمن الرحيم<br>السلام عليكم ورحمة الله وبركاته، وبعد:<br><br>فإن المشي من الرياضات المتوسطة الإجهاد التي تساعد الناس على المحافظة على لياقتهم ورشاقتهم بحرق الطاقة الزائدة، ويقوي الجهاز الدوري، ويحسن من استخدام الأكسجين والطاقة في الجسم.<br><br>لذلك يقلل من المخاطر المرتبطة بالسمنة، والسكري، وارتفاع الضغط، وأمراض القلب، ويقوي العضلات في الأرجل والبطن والظهر، ويقوي العظام، ويقلل من إصابتها بالهشاشة.<br><br>من ناحية أخرى: فإن المشي يفيد في التخلص من الضغوط النفسية، والقلق والإجهاد اليومي، ويحسن من الوضع النفسي، ومن تجاوب الجهاز العصبي، ويساعد المشي على التخلص من الوزن الزائد، وهذا بالطبع يعتمد على مدة المشي وسرعته.<br><br>إذا مشيت بمعدل 4 كم/ ساعة فإن جسمك يحرق ما بين 200 &ndash; 250 سعراً حرارياً في الساعة (22 &ndash; 28 جرام من الدهون).<br><br>يمكنك مزاولة المشي في أي مكان وزمان بدون تجهيزات أو ملابس خاصة، ويمكن أن يكون جزءاً من الحياة اليومية، ويمكن أن يكون في أي وقت من النهار، ومن الأفضل تحديد وقت معين خلال اليوم للمشي، بحيث يكون جزءاً من جدولك في اليوم، وذلك للمحافظة على موعد المشي.<br><br>إذا كان غرض المشي مجرد اللياقة البدنية فيكفي المشي مدة 30 دقيقة على الأقل يومياً، أو ثلاث مرات أسبوعياً.<br><br>أما إذا كان الغرض تخفيف الوزن واللياقة البدنية فيلزمك المشي 30 دقيقة على الأقل يومياً، أو خمس مرات في الأسبوع.<br><br>يمكنك زيادة مدة المشي إلى ساعة يومياً لكسب مزيد من اللياقة، وتخفيف الوزن.<br><br>المشي من أقل التمارين الرياضية ضرراً على المفاصل، والأقل في احتمالات الإصابة خلال التمارين.<br><br>عندما تمشي ابق رأسك مرفوعاً، وانظر على بعد بضع خطوات أمامك، وحافظ على الفك السفلي في مكانه دون شد بل اجعل عضلاته منبسطة وابق الكتفين إلى الخلف دون شد، ولا تجعلهما منحنيين إلى الأمام، وحافظ على الصدر مرتفعاً والظهر مستقيماً وقائماً، ويجب أن تكون عضلات البطن مشدودة قليلاً إلى الداخل، وعضلات الورك والعجيزة (المؤخرة) مشدودة قليلاً إلى الداخل أيضاً.<br><br>لا بد أن يكون مفصل الركبة مرناً للحركة فلا تجعله مشدوداً بحيث يتحرك الساق والفخذ معاً.<br><br>اثن أصابع اليد للداخل بدون تكوين قبضة كاملة وبدون ضغط عليها، ولا تجعل يديك تتدلى والكف مفتوحة، اجعل الذراع بشكل زاوية قائمة من عند المرفق، وحرك يديك إلى الأمام والخلف بحيث ترتفع قبضة الكف إلى أعلى في حركة اليد إلى الأمام وتصل إلى محاذاة الورك في حركتها إلى الخلف، ولا تجعلها تتأرجح أمام جسمك، ومع حركة المشي ارجع ذراعيك إلى الخلف نحو الورك ولا تجعلهما يرتفعان في الهواء، وحركة الأذرع تأتي من الكتف وليس من المرفق.<br><br>إذا أردت المشي بسرعة فلا تجعل خطوتك واسعة، بل قم بزيادة عدد الخطوات (زيادة السرعة)، ولا تقصر من الخطوات بل الأفضل السير بالخطوات الطبيعية المريحة لك.<br><br>يختلف حذاء المشي عن الأحذية الأخرى التي تستخدم عادة، كما أنه يختلف عن بقية الأحذية الرياضية الخاصة بالجري أو التنس أو كرة القدم مثلاً؛ وذلك لأن آلية حركة القدم خلال المشي تختلف عنها في الرياضات الأخرى.<br><br>يجب أن يكون حذاء المشي ذا كعب عريض، ونعل مرن في الوسط، وأن يكون حاضناً للكعب دون أن يكون ضيقاً عليه، وأن تكون حركة أصابع الرجل في الطرف الأمامي للحذاء ممكنة.<br><br>كما يجب تغيير الحذاء إذا تآكل جزء من نعله، وعند شرائه يجب التأكد من أنه مريح من أول تجربة لبس له، وصفاته مطابقة لما تم ذكره.<br><br>هناك جوارب خاصة بالمشي وتمتاز أنها تسمح بتهوية القدمين وبالتخلص من العرق، ويجب أن يكون حجم الجوارب مناسباً لمقاس القدم بحيث لا تنطوي أو تكوّن زوائد تؤدي إلى رفع درجة حرارة القدم، وإلى الإصابة بالنفطات.<br><br>يجب أن تقوم بعملية التسخين قبل رياضة المشي، ويجرى التسخين بأداء بعض الحركات لليدين، والقفز والجري في المكان، أو المشي البطيء مدة 5 &ndash; 10 دقائق قبل المشي السريع.</p>", "2", "2" },
                    { "3", "<p>إن أردت أن تحافظي على وزنك فعليك أن تحافظي على أن يكون مقدار ما تأخذينه من طاقة من الطعام مساوياً للطاقة التي تحتاجينها يومياً، وتقدر بالنسبة لسنك بـ2200 كالوري بالمتوسط، وإن أردت أن تكوني دقيقةً أكثر فيمكنك مراجعة أخصائي تغذية، فيحسب لك بالتمام مقدار السعرات الحرارية اللازمة لك، والمناسبة لطولك، ووزنك، وعملك، والطاقة اللازمة لك، ويحتاج الجسم الطبيعي هذه المصادر لإنتاج الطاقة بنسب مختلفة:<br /><br />- الكربوهيدرات ( النشويات ) 50%.<br />- الدهون 35%.<br />- البروتينات 15%.<br /><br />الإنسان يحتاج لكمية مُحددة من السعرات الحرارية يومياً، وتزداد حسب نشاط الشخص وحجم جسده (الطول والوزن) وكذلك العمر، فالأطفال والشبان في طور النمو يحتاجون لكميات أكبر من السعرات الحرارية، ويجب أن يكون هناك توازن ما بين السعرات الحرارية التي نأخذها من الطعام والسعرات الحرارية التي نحرقها، حتى لا يزداد وزننا، حيث إن الجسم يُخزن السعرات الحرارية الزائدة عن حاجته على هيئة شحوم، ليستخدمها فيما بعد إذا اُضطر لذلك (في حال نقص السعرات الحرارية المأخوذة عن طريق الأكل)، وإذا أفرطنا في الأكل تزداد كمية الشحوم، وإذا قللنا الأكل فإن الجسم يستخدم الشحوم لإنتاج الطاقة ويحرقها، وبالتالي تقل الشحوم لدينا.<br />ولا يوجد ما يمنع أن تتناولي البيتزا أو الحلويات مرةً كل عدة أيام، بشرط أن تأخذي بعين الاعتبار كمية السعرات الحرارية التي تحويها هذه الأطعمة، وتحسب من ضمن السعرات الحرارية المسموح بها ذلك اليوم؛ لأن كل زيادة في الداخل من الطاقة إذا لم يقابلها حرق لهذه الطاقة، فإن ما يزيد يتحول إلى دهون وشحوم يجمعها الجسم في أماكن تخزين الدهون وهو البطن والأرداف، وأماكن أخرى من الجسم، ومتى قلت كمية الطعام الداخلة عن احتياج الجسم، فإن الجسم يبدأ باستهلاك الدهون في الجسم.</p>", "3", "3" },
                    { "4", "<p>بسم الله الرحمن الرحيم<br />السلام عليكم ورحمة الله وبركاته، وبعد:<br /><br />فإن السعرات الحرارية التي نحتاجها يومياً تقدر : 5000-5600 سعرة حرارية.<br />والطعام الصحي هو الطعام المتوازن المعتدل في الكمية والمختلف في النوع، وتختلف الأطعمة حسب كمية ونوعية المواد الغذائية التي تحتوي عليها، لذلك فمن المهم عند تنظيم التغذية اختيار أطعمة من كافة الأصناف ما أمكن ذلك.<br /><br />وأصناف الطعام الرئيسية هي:<br /><br />الحبوب/ الخضار والفواكه /اللحوم والأسماك /مشتقات الحليب/الدسم والزيوت/<br /><br /><br />ولذلك عليك حساب كمية السعرات الحرارية التي تلزمك، ثم تقسيمها على المواد الغذائية من الأطعمة المختلفة والمتنوعة.</p>", "3", "4" },
                    { "5", "<p>مع ضعف اللياقة البدنية وقلة الحركة فإن الجلوس مع ثني الركبة لفترات طويلة يؤدي إلى شد على الأربطة المحيطة بالمفصل، ويؤدي إلى الشعور بالألم، والأمر يحتاج إلى ممارسة رياضة المشي، وجعل هدف المشي 10000 خطوة على الجوال هدفاً يومياً، يجب العمل على تحقيقه قدر المستطاع.<br />\r\n<br />\r\nومن المعروف عموماً أن نقص فيتامين D يؤدي إلى ضعف في الأربطة والمفاصل والعظام، ولذلك يجب ضبط مستوى فيتامين D من خلال أخذ حقنة فيتامين D3 جرعة 300000 وحدة دولية، أو جرعة 200000 وحدة دولية حسب المتوفر، ثم تناول كبسولات فيتامين D3 الأسبوعية جرعة 50000 وحدة دولية، كبسولة واحدة أسبوعياً لمدة 12 أسبوعاً، مع الحرص على تناول المكملات الغذائية مثل: حبوب المغنسيوم جليسينات 500 مج، وفيتامين C واحد جرام بشكل يومي لمدة شهرين أو أكثر، وهي موجودة في الصيدليات، وفي محلات المكملات الغذائية.<br />\r\n<br />\r\nمع أهمية فحص صورة الدم CBC، وفحص فيتامين B12، ووظائف الغدة الدرقية TSH &amp; FT4، وتناول العلاج حسب نتيجة التحاليل، ولا مانع من تناول قرصين مسكن من باراسيتامول عند الضرورة، ولا قلق -إن شاء الله-.</p>", "2", "1" },
                    { "6", "<p>بسم الله الرحمن الرحيم</p>\r\n\r\n<p>السلام عليكم ورحمة الله وبركاته، وبعد:<br />\r\n<br />\r\nمؤشر كتلة الوزن الطبيعية &nbsp;لديك :43<br />\r\nمؤشر كتلة الوزن عندك= 18.6</p>\r\n\r\n<p>هذا يعني من الناحية الطبية أن وزنك يعتبر طبيعياً، وهو يعتبر الحدود الدنيا للوزن الطبيعي، وعلى كل حال فإن كنت تعتقدين أن وزنك أقل من المطلوب، فكما تعلمين فإن الوراثة تلعب دوراً كبيراً في تحديد شكل ووزن الإنسان، وكذلك فإن بعض الأشخاص يكون لديهم زيادة في نسبة الاستقلاب، وبالتالي فإنهم يتناولون كميات كبيرة من الطعام، ومع ذلك لا يزيد الوزن لديهم، وعلى كل حال فإنه يجب التأكد من الخلو من بعض الأمراض، مثل زيادة نشاط الغدة الدرقية ونقص الامتصاص والأمراض المزمنة، ولذا يجب التأكد من عدم وجود أحد هذه الأمراض.<br />\r\n<br />\r\nأما عن المكملات الغذائية إن أردت تناولها فمنها:<br />\r\n- Ensure وكل زجاجة تمنحك 250 سعرة حرارية.<br />\r\n- Ensure plus والعلبة الواحدة تعطيك 350 سعرة حرارية.<br />\r\n- Ensure high protein وكل زجاجة تمنحك 230 سعرة حرارية، وهو بشكل سائل في علب.<br />\r\n<br />\r\nوالله الموفق.</p>\r\n", "7", "5" },
                    { "7", "<p>بسم الله الرحمن الرحيم<br />\r\nالسلام عليكم ورحمة الله وبركاته، وبعد:<br />\r\n<br />\r\nكثير من الفتيات يحلمن أن يكون طولهن مثل طولك، فالقصيرات يتمنين أن يكن طوالاً، والطوال يتمنين أن يكن قصاراً، وأود أن أطمئنك حتى لا تشغلي بالك بأن طولك ممتاز، ولا يوجد أي شيء لتقصير الطول، لا دواء ولا جراحة، وعادة ما يتوقف نمو الفتيات في سن الـ 15-16 لذا قد يزداد طولك قليلاً بين 1-2 سم.<br />\r\n<br />\r\nالشيء الآخر هو وزنك، فوزنك طبيعي بالنسبة لطولك، ومؤشر كتلة الوزن عندك هي 21.2 وهذا يعتبر وزناً مثالياً، ولا تفكري كثيراً في إنقاصه، وإلا أصبح ذلك هاجساً عندك، فكثير من الفتيات يؤدي كثرة التفكير في أوزانهن وخوفهن من السمنة إلى أن يتوقفوا عن تناول الطعام، وقد يؤدي ذلك إلى مرض القمة العصبي، أو ما يسمى (Anorexia nervosa) فليس هناك أي شيء تستطيعين فعله لوزنك الذي يحلم به الكثير من الفتيات، فوزنك مناسب جداً لطولك، واحمدي الله تعالى على ما اختاره لك من طول.<br />\r\n<br />\r\nوالله الموفق.</p>\r\n", "7", "6" },
                    { "8", "<p>بسم الله الرحمن الرحيم<br />\r\nالسلام عليكم ورحمة الله وبركاته، وبعد:<br />\r\n<br />\r\nفنبارك لك المولود الجديد، ونسأل الله عز وجل أن يجعله قرة عين لك ولزوجتك، وأن يكون من أهل السعادة في الدارين.<br />\r\n<br />\r\nوبالنسبة لسؤالك عن زيادة الوزن التي حدثت عند زوجتك بعد الحمل والولادة؛ أقول لك: إن هناك ما بين 2 - 4 كج زيادة في الوزن تلاحظها أغلب السيدات في أوزانهن بعد الولادة، وهي زيادة طبيعية تحدث في الحمل لكل سيدة كنوع من الحماية للحمل، فإن كان وزن زوجتك الآن قد ازداد عن ما قبل الحمل من 2 - 4 كج فهذا أمر متوقع، وستخسره بالتدريج إن عادت إلى عاداتها الغذائية السابقة للحمل.<br />\r\n<br />\r\nلكن إن كان قد ازداد وزنها أكثر من ذلك؛ فهنا يكون السبب كثرة تناول الطعام، أو قلة ممارسة الرياضة، وهنا ننصحها بما يلي:<br />\r\n<br />\r\nأولا: يجب أن تعرف ما يلزمها من السعرات الحرارية التي يحتاجها جسمها، وتحسبها كالتالي: تأخذ حاصل ضرب وزنها بالكج في الرقم 30 فيكون الناتج هو ما يحتاجه جسمها من السعرات.<br />\r\n<br />\r\nأي إن كان وزنها 60 كلغ مثلاً: فيكون 60x30 = 1800 وحدة حرارية، وبما أنها مرضع نضيف عليها 300-400 وحدة فتكون حاجتها الحالية هي بحدود 2200-2100 وحدة يومياً، فإن أرادت أن تخفض وزنها، فيجب أن تتناول أقل من 2200 وحدة باليوم وهي مرضع، وأقل من 1800 وحدة بعد أن تفطم الطفل (إن كان وزنها 60 كج مثلاً).<br />\r\n<br />\r\nوعليها أن تأخذ نصف حاجتها من السعرات هذه من السكريات المركبة مثل: الخبز الكامل، والرز وماشابههما، وربع الكمية من البروتينات والحبوب والحليب ومشتقاته، والباقي من الفاكهة والخضروات، وهذا يعني تقليل الدهون إلى أقصى درجة.<br />\r\n<br />\r\nوسأعطيك أمثلةً عن محتوى بعض المواد من السعرات الحرارية، لتأخذ فكرة كيف تحسب زوجتك ما تأكل.<br />\r\n<br />\r\nمثلاً: البيضة المتوسطة الحجم تحتوي على ما يقارب 70 وحدة حرارية، وشريحة خبز التوست تحتوي على 60 وحدة، وكوب الحليب تقريباً 180 وحدة، وحبة موز أو تفاح أو برتقال 100 وحدة، وهكذا.<br />\r\n<br />\r\nوبالنسبة للشاي الأخضر: فهو مفيد جداً للصحة، ويساعد على تخفيض الوزن؛ لأنه ينشط الاستقلاب، ولا يضر المولود، ولا يؤثر على الإرضاع؛ لذلك يمكن لزوجتك تناوله يومياً بمعدل كوب في الصباح، وكوب عند العصر.<br />\r\n<br />\r\nوالأطعمة المفيدة لإدرار الحليب كثيرة، وأهمها: الحليب نفسه، والعصائر الطازجة، وحبة البركة، والتمر.<br />", "9", "7" },
                    { "9", "<p>&nbsp;</p>\r\n\r\n<p>سم الله الرحمن الرحيم<br />\r\nالسلام عليكم ورحمة الله وبركاته، وبعد:<br />\r\n<br />\r\nأنت ما زلت في سن 15 سنة، وكما ترى فإن هناك زيادة في وزنك، مع كرش وترهل، وأهم نصيحة لك هو المشي، والمشي، ثم المشي، فعلى ما يبدو أن عندك استعداداً لزيادة الوزن، والمشي يساعد على تنقيص الوزن، والتخلص من الدهون في منطقة الكرش والردفين، ويعطيك الشعور بالحيوية، وتشعر أنك تصنع شيئاً لنفسك، بالإضافة إلى فوائدها الكثيرة على القلب والعضلات والرئتين، والدورة الدموية، والعظام.<br />\r\n<br />\r\nأما الطعام فكل مما يأكل الأهل في البيت، ولكن قلل من كمية الطعام التي عودت نفسك أن تأكلها ولو بنسبة 10% وبالتدرج، أيضاً استمر بتنقيص هذه الكمية، حتى تتعود المعدة على كمية طعام قليلة لملئها.<br />\r\n<br />\r\nمن ناحية أخرى يفضل تناول عدة وجبات في اليوم، أي 4 - 5 وجبات صغيرة بدلاً من وجبتين ثقيلتين، والفكرة من هذا أن الوجبات الصغيرة تقلل عندك الشعور بالجوع، وأكثر من الفواكه والخضار كلما شعرت بالجوع، وقلل من الشوكولاتا والطعام الدسم، وكل الخبز الأسمر.<br />\r\n<br />\r\nعليك بتمارين البطن والورك والصدر، وهذه يمكن أن تجريها في الأول تحت إشراف أحد المدربين، ثم تجريها بنفسك.</p>\r\n", "9", "8" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9bda1ef-3579-4a2a-8ae8-7593c77dc255", "c8404eed-fb56-4e6c-9447-ccc009adcf63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d5fad30-9cee-4991-b6d2-1e033db639e2", "e549ebf6-6e24-4004-809b-10bab1b29e4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f1bae58c-2bd9-4e0e-b0f0-6a1cae6e38d8", "400d859a-c2ff-4084-9ffc-3d28ed3407ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ea4ae52a-8d22-4a5f-8591-8fdd0e79fcc4", "42d00b6e-7b7b-421d-9081-1d1047f1fadf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41dd7f20-df76-4a83-a40d-c892d67f79f8", "b9820cb7-3bf2-4484-8fda-475ccd4ecd7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90f0faaf-9a75-4218-9927-3bb451583a86", "8f44d51a-e81e-47cf-9f30-1a819d299cb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "30e20a4b-05e2-463b-aa0f-ff644f106f76", "23aa04e3-9f4d-4be6-9e1b-cf7319f3c128" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8963e95b-30ab-4f64-a986-5b63964e8b76", "929bd593-4a66-4cb7-829e-91a66d6dcdac" });

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "42",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "43",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "44",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "45",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "46",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "47",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "48",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "49",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "50",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "51",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "52",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "53",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "54",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "55",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "56",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "57",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "58",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "59",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "60",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 54, 50, 773, DateTimeKind.Local).AddTicks(3373));
        }
    }
}

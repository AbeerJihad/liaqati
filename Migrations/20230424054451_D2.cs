using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class D2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TblRate_ExerciseId",
                table: "TblRate");

            migrationBuilder.DropColumn(
                name: "RateId",
                table: "TblExercises");

            migrationBuilder.RenameColumn(
                name: "review",
                table: "TblRate",
                newName: "Review");

            migrationBuilder.AddColumn<string>(
                name: "HealthyRecipeId",
                table: "TblRate",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PreparationMethod",
                table: "TblHealthyRecipe",
                type: "NTEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ingredients",
                table: "TblHealthyRecipe",
                type: "NTEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RatePercentage",
                table: "TblHealthyRecipe",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RatePercentage",
                table: "TblExercises",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "27315ebc-90a8-4f22-8a2d-f7cedead673c", "8360b20a-4cd3-4f21-b0bc-f1b8e638f32a" });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "1",
                column: "RatePercentage",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "10",
                column: "RatePercentage",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "2",
                column: "RatePercentage",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "3",
                column: "RatePercentage",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "4",
                column: "RatePercentage",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "5",
                column: "RatePercentage",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "6",
                column: "RatePercentage",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "7",
                column: "RatePercentage",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "8",
                column: "RatePercentage",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "9",
                column: "RatePercentage",
                value: 50.0);

            migrationBuilder.InsertData(
                table: "TblHealthyRecipe",
                columns: new[] { "Id", "Calories", "CategoryId", "Description", "DietaryType", "Image", "Ingredients", "MealType", "PrepTime", "PreparationMethod", "Price", "Protein", "RatePercentage", "ShortDescription", "Title", "Total_Carbohydrate" },
                values: new object[,]
                {
                    { "61", 250, null, "<p> <strong> الطبق </strong> </p>\r\n<p> فاهيتا على الفطور؟ تتحدى! مستوحاة من تلك الفاهيتا الأزيز على غرار المطاعم ، قمنا بإعادة إنشاء نسخة مبسطة مثالية لصباح أيام الأسبوع المزدحمة - كاملة مع خيارات الإعداد المسبق لتوفير المزيد من الوقت. بدلاً من التورتيلا ، ابتكرنا مفهوم الأومليت المفتوح الوجه. الأومليت مليء بالديك الرومي المحمر والمتبل بالإضافة إلى الفلفل والبصل المقلي. القليل من الصلصة والزبادي قليل الدسم والبصل الأخضر يكمل جمالية الفاهيتا. إذا كنت ترغب في جعل فاهيتا الإفطار نباتيًا ، فلا تتردد في استبدال الديك الرومي ببديل اللحم المفروم المفضل لديك (أو التوفو المفتت). </p>\r\n<p> <strong> نصائح للتحضير المسبق / لتوفير الوقت </strong> </p>\r\n<p> يمكن طهي الديك الرومي والخضار (الفلفل والبصل) وتبريدهما قبل يوم أو يومين. أثناء طهي البيض ، قم بإعادة تسخين مزيج الديك الرومي والخضروات في الميكروويف (أو في مقلاة أخرى) ، ثم قم بتجميعها حسب التعليمات. </p>", "حيواني", "", "بيضات كاملة,100,غرام\n الديك الرومي المطحون الخالي من الد,60,غرام\nتوابل التاكو ,2,غرام\n الفلفل الأخضر الجرس,20,غرام\n الفلفل الأحمر,20,غرام\n البصل الأحمر,20,غرام\nصلصة,15,غرام\n زبادي يوناني قليل الدسم,15,غرام\n البصل الأخضر,10,غرام\n", "وجبة الإفطار", 12, "دهن مقلاة غير لاصقة بقليل من بخاخ تحرير المقلاة وقم بالتسخين المسبق على حرارة متوسطة إلى عالية.\r\nبمجرد أن يسخن , افرم الديك الرومي المطحون في المقلاة ورشي توابل التاكو مع التقليب حتى تمتزج. يُطهى لمدة 3-4 دقائق مع التحريك من حين لآخر أو حتى ينضج تمامًا ويصبح لونه بنيًا جيدًا. بمجرد طهيه , باستخدام ملعقة مثقوبة , أخرج الديك الرومي من المقلاة وضعه جانبًا على طبق.\r\n, دهن المقلاة برفق مرة أخرى وعاد إلى درجة حرارة متوسطة إلى عالية. يُضاف الفلفل والبصل ويُطهى لمدة 3-4 دقائق أو حتى ينضج.\r\n, بمجرد أن تصبح الخضار طرية , أعد الديك الرومي المطحون إلى المقلاة وقلّب المزيج. باستخدام ملعقة مشقوقة , تُرفع الخضار والديك الرومي المفروم من المقلاة , ويُترك جانباً على الطبق , ويُتبل قليلاً بالملح والفلفل حسب الرغبة.\r\n, أعد المقلاة إلى درجة حرارة متوسطة إلى عالية. بمجرد أن يسخن , أضف البيض ولفه لتغطي قاع المقلاة.\r\n,يُغطّى ويُطهى لمدة 2-3 دقائق أو حتى يصبح البيض متماسكًا وينضج تمامًا. أخرج البيضة من المقلاة بحذر وانقلها إلى طبق التقديم.\r\nوزعي البيض بالديك الرومي والخضار والصلصة. دولوب مع الزبادي ورش البصل الأخضر قبل التقديم.", 0.0, 24, 0.0, "", " فاهيتا أوميليت مفتوح الوجه مع تركيا المطحونة والفلفل والبصل", 6 },
                    { "62", 269, null, "<p> <strong> الطبق </strong> </p>\r\n<p> مستوحاة من شطائر الشاي الإنجليزي التقليدية ، تستخدم هذه النسخة اللطيفة الخيار الكلاسيكي والجبن بينما يتم تعزيزها بالبروتين من خلال صدور الدجاج الخالية من الدهون والمشوية والمتبل. يكمن السر في بناء وجبة ديناميكية ولذيذة في إضافة طبقة من النكهة والقوام. يتناقض الجبن الدسم قليل الدسم بشكل جيد مع شرائح الخيار الطازجة. الدجاج - المتبل بالخل البلسمي والتوابل الإيطالية - هو إضافة لذيذة لهذه الخبز المحمص ، يضفي نكهة حلوة ومالحة ومدخنة رائعة. قم بإقران هذه الوصفة مع أي نوع من أنواع الحساء أو السلطات التي تركز على الخضار للحصول على وجبة متوازنة - مثالية للغداء أو العشاء! </ p>\r\n<p> <strong> الاستعداد للأمام ونصيحة لتوفير الوقت </strong> </p>\r\n<p> لتوفير الوقت أو كخيار مسبق ، لا تتردد في نقع الدجاج طوال الليل. يمكنك أيضًا تتبيل صدور الدجاج وشويها وتبريدها وتقطيعها إلى شرائح لتوفير المزيد من الوقت. </p>", "حيواني", "", " الريحان الطازج,2,غرام\n خيارة,60,غرام\n جبن كوخ قليل الدسم ,2,غرام\n  كعكة القمح الكامل الإنجليزية ,20,غرام\n الخل البلسمي ,20,غرام\n  البارود الأسود,20,غرام\nالتوابل الإيطالية,15,غرام\n صدر دجاج,15,غرام\nزيت الزيتون,10,غرام\n", "طبق جانبي,وجبة غداء", 15, ", قم بالتسخين المسبق لشواية الغاز إلى درجة حرارة متوسطة إلى عالية أو الفحم المسبق لشواية الفحم., صدر الدجاج يجفف بالمناشف الورقية ويوضع على طبق ويتبل قليلا بالتوابل الإيطالية والفلفل الأسود والخل البلسمي ورشة ملح., ضع الدجاج جانبًا لينقع لمدة 10 دقائق بينما تسخن الشواية مسبقًا., بمجرد أن تصبح الشواية ساخنة ، أضيفي الدجاج واطهيها لمدة 2-3 دقائق لكل جانب أو حتى تفحم قليلاً وتنضج بالكامل. تُرفع عن الشواية وتترك جانباً لترتاح قبل التقطيع., ملعقة وافرد الجبن القريش على الكعك الإنجليزي المحمص. يُغطى التوست المُجهز بشرائح الدجاج وشرائح الخيار والريحان الطازج. الموسم الى الذوق مع الملح والفلفل.", 0.0, 26, 0.0, "", "خيار وجبن كوخ وخبز محمص دجاج مشوي مع الخل البلسمي والأعشاب الإيطالية", 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblRate_ExerciseId",
                table: "TblRate",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_TblRate_HealthyRecipeId",
                table: "TblRate",
                column: "HealthyRecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblRate_TblHealthyRecipe_HealthyRecipeId",
                table: "TblRate",
                column: "HealthyRecipeId",
                principalTable: "TblHealthyRecipe",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblRate_TblHealthyRecipe_HealthyRecipeId",
                table: "TblRate");

            migrationBuilder.DropIndex(
                name: "IX_TblRate_ExerciseId",
                table: "TblRate");

            migrationBuilder.DropIndex(
                name: "IX_TblRate_HealthyRecipeId",
                table: "TblRate");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62");

            migrationBuilder.DropColumn(
                name: "HealthyRecipeId",
                table: "TblRate");

            migrationBuilder.DropColumn(
                name: "RatePercentage",
                table: "TblHealthyRecipe");

            migrationBuilder.DropColumn(
                name: "RatePercentage",
                table: "TblExercises");

            migrationBuilder.RenameColumn(
                name: "Review",
                table: "TblRate",
                newName: "review");

            migrationBuilder.AlterColumn<string>(
                name: "PreparationMethod",
                table: "TblHealthyRecipe",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NTEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ingredients",
                table: "TblHealthyRecipe",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NTEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RateId",
                table: "TblExercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "75235434-1d2d-494a-befb-be35a7223ba1", "da313557-1c83-4ea5-8220-4958254375c0" });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "1",
                column: "RateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "10",
                column: "RateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "2",
                column: "RateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "3",
                column: "RateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "4",
                column: "RateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "5",
                column: "RateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "6",
                column: "RateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "7",
                column: "RateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "8",
                column: "RateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "9",
                column: "RateId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_TblRate_ExerciseId",
                table: "TblRate",
                column: "ExerciseId",
                unique: true,
                filter: "[ExerciseId] IS NOT NULL");
        }
    }
}

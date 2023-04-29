using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class kj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HealthyId",
                table: "TblFiles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e238ae1c-9ece-43f2-b7d2-21455d4c18c4", "692e09af-e07f-4de6-bc8e-90ebea85df7d" });

            migrationBuilder.InsertData(
                table: "TblFiles",
                columns: new[] { "Id", "HealthyId", "Path", "ServiceId" },
                values: new object[,]
                {
                    { "1", "61", "/Images/HealthyRecipes/1.jpg", null },
                    { "2", "61", "/Images/HealthyRecipes/img61.jpg", null },
                    { "3", "61", "/Images/HealthyRecipes/im61.jpg", null },
                    { "4", "62", "/Images/HealthyRecipes/2.jpg", null },
                    { "5", "62", "/Images/HealthyRecipes/img62.jpg", null },
                    { "6", "62", "/Images/HealthyRecipes/im62.jpg", null }
                });

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 29, 13, 50, 41, 377, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 29, 13, 50, 41, 377, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.InsertData(
                table: "TblHealthyRecipe",
                columns: new[] { "Id", "Calories", "CategoryId", "CreatedDate", "Description", "DietaryType", "Image", "Ingredients", "IsFeatured", "MealType", "PrepTime", "PreparationMethod", "Price", "Protein", "RatePercentage", "ShortDescription", "Title", "Total_Carbohydrate", "ViewsNumber" },
                values: new object[] { "63", 273, null, new DateTime(2023, 4, 29, 13, 50, 41, 377, DateTimeKind.Local).AddTicks(5086), " <p class=\"fs-6\">\r\n                            تساعد على تنظيف الجسم من السموم وتخليصه من الأمراض المختلفة، إذ يمكن عمله\r\n                            بطرق عدة باستخدام أنواع مختلفة من الخضار والفواكه، وهذه المشروبات تساعد في\r\n                            حميات إنقاص الوزن وتعزز الصحة العامة، هنا سنقدم طريقة عمل عصير ديتوكس\r\n                        </p>", null, "/user/images/pexels-toni-cuenca-616833.png", " الريحان الطازج,2,غرام\n خيارة,60,غرام\n جبن كوخ قليل الدسم ,2,غرام\n  كعكة القمح الكامل الإنجليزية ,20,غرام\n الخل البلسمي ,20,غرام\n  البارود الأسود,20,غرام\nالتوابل الإيطالية,15,غرام\n صدر دجاج,15,غرام\nزيت الزيتون,10,غرام\n", null, "مشروبات", 30, "  <ol>\r\n                    <li>اغسلي جميع الخضار والفواكه وقطعيها لقطع متوسطة يسهل وضعها في الخلاط.</li>\r\n                    <li>ضعي الخضار والفواكه في العصارة أو الخلاط الكهربائي واحداً تلو الآخر واخلطيها لمدة أربع دقائق حتى تتجانس المكونات.</li>\r\n                    <li>قدمي العصير مبرداً واحفظيه في الثلاجة إذ يمكن تناوله خلال سبع أيام.</li>\r\n                  \r\n                </ol>", 0.0, 20, 80.0, "", "مشروب الديتوكس الأخضر", 43, 0 });

            migrationBuilder.InsertData(
                table: "TblFiles",
                columns: new[] { "Id", "HealthyId", "Path", "ServiceId" },
                values: new object[] { "7", "63", "/user/images/pexels-toni-cuenca-616833.png", null });

            migrationBuilder.InsertData(
                table: "TblFiles",
                columns: new[] { "Id", "HealthyId", "Path", "ServiceId" },
                values: new object[] { "8", "63", "~/user/images/224347.png", null });

            migrationBuilder.InsertData(
                table: "TblFiles",
                columns: new[] { "Id", "HealthyId", "Path", "ServiceId" },
                values: new object[] { "9", "63", "/user/images/224664.png", null });

            migrationBuilder.CreateIndex(
                name: "IX_TblFiles_HealthyId",
                table: "TblFiles",
                column: "HealthyId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblFiles_TblHealthyRecipe_HealthyId",
                table: "TblFiles",
                column: "HealthyId",
                principalTable: "TblHealthyRecipe",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblFiles_TblHealthyRecipe_HealthyId",
                table: "TblFiles");

            migrationBuilder.DropIndex(
                name: "IX_TblFiles_HealthyId",
                table: "TblFiles");

            migrationBuilder.DeleteData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "63");

            migrationBuilder.DropColumn(
                name: "HealthyId",
                table: "TblFiles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bedaa876-c920-4bf5-b4b8-08fb0262516b", "33e02363-df67-4f30-8bf2-01eb3459b3d4" });

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 28, 14, 53, 32, 983, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 28, 14, 53, 32, 983, DateTimeKind.Local).AddTicks(2955));
        }
    }
}

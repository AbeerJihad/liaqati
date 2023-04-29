using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "41");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "42");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "43");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "44");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "45");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "46");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "47");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "48");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "49");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "50");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "51");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "52");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "53");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "54");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "55");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "56");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "57");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "58");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "59");

            migrationBuilder.DeleteData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "6-");

            migrationBuilder.AlterColumn<string>(
                name: "Target",
                table: "TblCategory",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Specialization",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bedaa876-c920-4bf5-b4b8-08fb0262516b", "33e02363-df67-4f30-8bf2-01eb3459b3d4" });

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "1",
                column: "Target",
                value: "الوجبات");

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "2",
                column: "Target",
                value: "الوجبات");

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "3",
                column: "Target",
                value: "منتجات");

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "4",
                column: "Target",
                value: "منتجات");

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "5",
                column: "Target",
                value: "الوجبات");

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "6",
                column: "Target",
                value: "الوجبات");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specialization",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "Target",
                table: "TblCategory",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eac03cca-524e-45d4-bb0a-9f11855172ef", "eb41803e-ce89-4f39-8795-4e5988593512" });

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "1",
                column: "Target",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "2",
                column: "Target",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "3",
                column: "Target",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "4",
                column: "Target",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "5",
                column: "Target",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "6",
                column: "Target",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.InsertData(
                table: "TblHealthyRecipe",
                columns: new[] { "Id", "Calories", "CategoryId", "CreatedDate", "Description", "DietaryType", "Image", "Ingredients", "IsFeatured", "MealType", "PrepTime", "PreparationMethod", "Price", "Protein", "RatePercentage", "ShortDescription", "Title", "Total_Carbohydrate", "ViewsNumber" },
                values: new object[,]
                {
                    { "41", 491, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4559), null, "Omnivore", "1.jpg", null, null, "Dinner", 50, null, null, 35, null, null, null, 43, 0 },
                    { "42", 156, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4700), null, "Vegetarian", "2.jpg", null, null, "Snack", 5, null, null, 4, null, null, null, 17, 0 },
                    { "43", 379, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4706), null, "Omnivore", "3.jpg", null, null, "Lunch", 50, null, null, 32, null, null, null, 47, 0 },
                    { "44", 19, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4709), null, "Vegetarian", "4.jpg", null, null, "Snack", 60, null, null, 5, null, null, null, 37, 0 },
                    { "45", 170, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4713), null, "Omnivore", "5.png", null, null, "Snack", 60, null, null, 5, null, null, null, 43, 0 },
                    { "46", 180, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4717), null, "Vegetarian", "6.jpg", null, null, "Lunch", 30, null, null, 4, null, null, null, 44, 0 },
                    { "47", 538, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4720), null, "Omnivore", "7.jpg", null, null, "Dinner", 35, null, null, 37, null, null, null, 79, 0 },
                    { "48", 30, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4725), null, "Vegetarian", "8.jpg", null, null, "Breakfast", 10, null, null, 5, null, null, null, 10, 0 },
                    { "49", 110, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4728), null, "Vegetarian", "9.png", null, null, "Breakfast", 15, null, null, 5, null, null, null, 10, 0 },
                    { "50", 40, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4733), null, "Vegetarian", "10.png", null, null, "SideDish", 60, null, null, 8, null, null, null, 20, 0 },
                    { "51", 125, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4736), null, "Vegetarian", "11.png", null, null, "Lunch", 50, null, null, 5, null, null, null, 30, 0 },
                    { "52", 66, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4741), null, "Omnivore", "12.png", null, null, "Snack", 30, null, null, 5, null, null, null, 36, 0 },
                    { "53", 110, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4745), null, "Vegetarian", "13.jpg", null, null, "Lunch", 30, null, null, 7, null, null, null, 45, 0 },
                    { "54", 145, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4749), null, "Omnivore", "14.jpg", null, null, "Lunch", 60, null, null, 17, null, null, null, 30, 0 },
                    { "55", 25, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4753), null, "Vegetarian", "15.png", null, null, "SideDish", 15, null, null, 8, null, null, null, 10, 0 },
                    { "56", 150, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4756), null, "Omnivore", "16.jpg", null, null, "Snack", 30, null, null, 5, null, null, null, 25, 0 },
                    { "57", 50, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4760), null, "Vegetarian", "17.jpg", null, null, "Dinner", 20, null, null, 4, null, null, null, 15, 0 },
                    { "58", 65, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4764), null, "Omnivore", "18.jpg", null, null, "Breakfast", 30, null, null, 15, null, null, null, 40, 0 },
                    { "59", 34, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4768), null, "Omnivore", "19.jpg", null, null, "Breakfast", 15, null, null, 0, null, null, null, 15, 0 },
                    { "6-", 45, null, new DateTime(2023, 4, 26, 20, 59, 55, 955, DateTimeKind.Local).AddTicks(4771), null, "Omnivore", "20.jpg", null, null, "Breakfast", 240, null, null, 7, null, null, null, 15, 0 }
                });
        }
    }
}

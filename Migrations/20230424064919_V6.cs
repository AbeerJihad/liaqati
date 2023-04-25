using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class V6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "TblHealthyRecipe",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87afa91a-72a6-4419-8ba5-d445a2cca41d", "b57c5fae-6689-41ed-b7d7-bf155633d494" });

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "42",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "43",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "44",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "45",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "46",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "47",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "48",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "49",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "50",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "51",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "52",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "53",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "54",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "55",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "56",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "57",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "58",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "59",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "6-",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 49, 17, 604, DateTimeKind.Local).AddTicks(6947));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "TblHealthyRecipe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62fafb75-63a3-4005-8cc3-375d19cc0fe9", "498e0655-08e8-4987-a492-b1f7f302f385" });

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "42",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "43",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "44",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "45",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "46",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "47",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "48",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "49",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "50",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "51",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "52",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "53",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "54",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "55",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "56",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "57",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "58",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "59",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "6-",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 8, 11, 54, 515, DateTimeKind.Local).AddTicks(5512));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class D5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TblHealthyRecipe",
                type: "datetime2",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TblHealthyRecipe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "927f2cde-335e-47e2-83e4-56c752365cf8", "a946b99f-82b1-4f73-8945-35b4b9f8f1de" });
        }
    }
}

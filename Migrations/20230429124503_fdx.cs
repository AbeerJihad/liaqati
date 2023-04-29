using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class fdx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9b87f60-a6d7-4df2-a88d-09507a098ff4", "f7c40121-f0df-4b69-a489-52c94bb72c36" });

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 29, 15, 45, 2, 34, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 29, 15, 45, 2, 34, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "63",
                columns: new[] { "CreatedDate", "DietaryType" },
                values: new object[] { new DateTime(2023, 4, 29, 15, 45, 2, 34, DateTimeKind.Local).AddTicks(4751), "نباتي" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "314d6018-55b9-427d-9a48-d2fd81e974ec", "2186f9be-9948-418a-891c-b0894088050e" });

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 29, 13, 54, 18, 447, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 4, 29, 13, 54, 18, 447, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "63",
                columns: new[] { "CreatedDate", "DietaryType" },
                values: new object[] { new DateTime(2023, 4, 29, 13, 54, 18, 447, DateTimeKind.Local).AddTicks(4935), null });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class DatabaseV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b50c83cd-9c86-4079-a735-7a55368ffbd8", "ab5310cc-acae-4ef9-9f97-09bfa69699fa" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Name", "Target" },
                values: new object[] { "المكملات الغذائية", 4 });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Name", "Target" },
                values: new object[] { "الاجهزة الرياضية", 4 });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Name", "Target" },
                values: new object[] { "حلوى", 1 });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "Name", "Target" },
                values: new object[] { "الوجبات", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "77c7be0d-50ba-4386-9500-83023a7cedaa", "84e660da-73c0-4cfd-8603-1d3766902ee0" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Name", "Target" },
                values: new object[] { "حلوى", 1 });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Name", "Target" },
                values: new object[] { "الوجبات", 0 });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Name", "Target" },
                values: new object[] { "المكملات الغذائية", 4 });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "Name", "Target" },
                values: new object[] { "الاجهزة الرياضية", 4 });
        }
    }
}

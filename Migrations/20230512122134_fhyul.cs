using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class fhyul : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bbb60356-0f05-4d98-adc6-11a85d4c425a", "37083b49-3771-430c-9ffe-e0c8ad9d3e9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3a44b478-8936-4f47-a1cd-99b1a504168b", "bb668b45-b90e-4a78-ac67-d90903b72dd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b9fa50e-2f9a-4986-b1b6-45fa4a5b3aac", "711b8206-ab8f-4dff-8fea-f96e037a8177" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df04ecc7-de74-4c61-8ec8-5656077af72d", "ba0ef4a2-8a2e-4b6d-9516-844426dd0db5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9edb2282-0b63-4724-a600-d1b59dabd138", "e469b3b0-88bd-4455-948f-61af224d3b11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "40f6fd4b-e3d5-47e0-9696-cfdd9c6202c6", "6f02e48b-4e19-472c-b18b-1f76a862cb02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "28f2e94a-d317-4949-aecd-f6f6aeac4152", "d35ccafe-b999-48cd-ba38-17414d20cc22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bcc8127f-baa5-46c4-991e-4db2a6293201", "ec98d9fc-4a63-470e-90c0-0ad5deeb06ca" });

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "PostDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "PostDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "PostDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "PostDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "PostDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "PostDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "42",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "43",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "44",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "45",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "46",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "47",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "48",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "49",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "50",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "51",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "52",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "53",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "54",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "55",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "56",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "57",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "58",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "59",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "60",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 21, 31, 741, DateTimeKind.Local).AddTicks(4951));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d8c7f30-c13c-4a0c-a73f-42014a0be516", "5baa7399-b05b-485d-88f7-2009cc4a1cb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a03f848-0b36-435f-978b-d59ca7ffae4b", "4dbacc0f-3b2d-46ce-9fda-d1fa7acc3187" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b3b5a0a1-8537-41f0-aaf8-1931312b7999", "d3f438a8-8d3f-4137-90b4-b3f35bed8ba5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "26b47da8-bf31-48e6-90b3-05e14c1e87c9", "bd88d7b1-e180-4fba-ba62-c7e72ef980db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9673a018-f67d-4dad-a2d0-6c7346ea1bce", "aac5dc9b-f205-43fe-a842-80248c482fb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "26ff4160-219f-4a7c-9229-e2851d8decce", "207ad445-cb31-4f13-bfa9-6153afb727dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c00c81fd-aa12-47d4-b323-f6dccf870aac", "b245dfae-3fb2-4bfe-9ab6-8657c802038a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6cf736e-7136-4df9-aa43-97e6020daf93", "7d761625-8f96-4d04-af07-38282b964635" });

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "PostDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "PostDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "PostDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "PostDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "PostDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "PostDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "42",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "43",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "44",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "45",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "46",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "47",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "48",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "49",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "50",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "51",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "52",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "53",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "54",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "55",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "56",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "57",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "58",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "59",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "60",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 15, 20, 14, 634, DateTimeKind.Local).AddTicks(7341));
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class nsissss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef2d5826-ce39-4f79-8c50-a5618c6e8e79", "ed965094-0c1f-40bf-b18b-2504bdbd84d6" });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { "50-250", "تدريب القوة" });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { "50-250", "تدريب متقطع عالي الكثافة ، تأثير منخفض ، بيلاتيس ، تدريب القوة ، التمدد / المرونة ، القدرة على الحركة" });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { "50-250", "القلب والأوعية الدموية ، تأثير منخفض ، تدريب القوة ، التنغيم ، اليوجا ، الحركة" });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { "50-250", "تدريب القوة" });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { "50-250", "القلب والأوعية الدموية ، تأثير منخفض ، تدريب القوة ، التنغيم ، اليوجا ، الحركة" });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { "50-250", "تدريب القوة" });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { "50-250", "القلب والأوعية الدموية ، تأثير منخفض ، تدريب القوة ، التنغيم ، اليوجا ، الحركة" });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { "50-250", "تدريب القوة" });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { "50-250", "تدريب متقطع عالي الكثافة ، تأثير منخفض ، بيلاتيس ، تدريب القوة ، التمدد / المرونة ، القدرة على الحركة" });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { "50-250", "تدريب القوة" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45959948-c298-421b-9e43-01b1d18e57b5", "f725616b-deaf-4297-82f8-c40e3fc4e0d8" });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TblExercises",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "BurnEstimate", "TraningType" },
                values: new object[] { null, null });
        }
    }
}

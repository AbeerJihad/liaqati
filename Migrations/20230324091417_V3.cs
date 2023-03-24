using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblOrder_Details_TblServices_ServiceId",
                table: "TblOrder_Details");

            migrationBuilder.DropIndex(
                name: "IX_TblOrder_Details_ServiceId",
                table: "TblOrder_Details");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "TblOrder_Details");

            migrationBuilder.DropColumn(
                name: "ServicesId",
                table: "TblOrder_Details");

            migrationBuilder.AddForeignKey(
                name: "FK_TblOrder_Details_TblServices_Id",
                table: "TblOrder_Details",
                column: "Id",
                principalTable: "TblServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblOrder_Details_TblServices_Id",
                table: "TblOrder_Details");

            migrationBuilder.AddColumn<string>(
                name: "ServiceId",
                table: "TblOrder_Details",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServicesId",
                table: "TblOrder_Details",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrder_Details_ServiceId",
                table: "TblOrder_Details",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblOrder_Details_TblServices_ServiceId",
                table: "TblOrder_Details",
                column: "ServiceId",
                principalTable: "TblServices",
                principalColumn: "Id");
        }
    }
}

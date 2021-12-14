using Microsoft.EntityFrameworkCore.Migrations;

namespace vpmc_backend.Migrations
{
    public partial class renameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_AssignMethod_AssignMethodId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssignMethod",
                table: "AssignMethod");

            migrationBuilder.RenameTable(
                name: "AssignMethod",
                newName: "ParkAssignMethod");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkAssignMethod",
                table: "ParkAssignMethod",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkAssignMethod_AssignMethodId",
                table: "ParkSurveyDataSheet",
                column: "AssignMethodId",
                principalTable: "ParkAssignMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkAssignMethod_AssignMethodId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkAssignMethod",
                table: "ParkAssignMethod");

            migrationBuilder.RenameTable(
                name: "ParkAssignMethod",
                newName: "AssignMethod");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssignMethod",
                table: "AssignMethod",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_AssignMethod_AssignMethodId",
                table: "ParkSurveyDataSheet",
                column: "AssignMethodId",
                principalTable: "AssignMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace vpmc_backend.Migrations
{
    public partial class chBS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_Building_BuildingStructure_BuildingStructureId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_BuildingStructure_ParkBuildingStructureId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropIndex(
                name: "IX_ParkSurveyDataSheet_ParkBuildingStructureId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropColumn(
                name: "ParkBuildingStructureId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_BuildingStructure_BuildingStructureId",
                table: "ParkSurveyDataSheet",
                column: "BuildingStructureId",
                principalTable: "Park_BuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_BuildingStructure_BuildingStructureId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.AddColumn<int>(
                name: "ParkBuildingStructureId",
                table: "ParkSurveyDataSheet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ParkSurveyDataSheet_ParkBuildingStructureId",
                table: "ParkSurveyDataSheet",
                column: "ParkBuildingStructureId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_Building_BuildingStructure_BuildingStructureId",
                table: "ParkSurveyDataSheet",
                column: "BuildingStructureId",
                principalTable: "Building_BuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_BuildingStructure_ParkBuildingStructureId",
                table: "ParkSurveyDataSheet",
                column: "ParkBuildingStructureId",
                principalTable: "Park_BuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

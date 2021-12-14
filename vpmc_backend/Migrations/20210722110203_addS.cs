using Microsoft.EntityFrameworkCore.Migrations;

namespace vpmc_backend.Migrations
{
    public partial class addS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingBuildingStructure_BuildingStructureId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_BuildingBuildingStructure_BuildingStructureId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildingBuildingStructure",
                table: "BuildingBuildingStructure");

            migrationBuilder.RenameTable(
                name: "BuildingBuildingStructure",
                newName: "Building_BuildingStructure");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Building_BuildingStructure",
                table: "Building_BuildingStructure",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_BuildingStructure_BuildingStructureId",
                table: "BuildingSurveyDataSheet",
                column: "BuildingStructureId",
                principalTable: "Building_BuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_Building_BuildingStructure_BuildingStructureId",
                table: "ParkSurveyDataSheet",
                column: "BuildingStructureId",
                principalTable: "Building_BuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_BuildingStructure_BuildingStructureId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_Building_BuildingStructure_BuildingStructureId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Building_BuildingStructure",
                table: "Building_BuildingStructure");

            migrationBuilder.RenameTable(
                name: "Building_BuildingStructure",
                newName: "BuildingBuildingStructure");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildingBuildingStructure",
                table: "BuildingBuildingStructure",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingBuildingStructure_BuildingStructureId",
                table: "BuildingSurveyDataSheet",
                column: "BuildingStructureId",
                principalTable: "BuildingBuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_BuildingBuildingStructure_BuildingStructureId",
                table: "ParkSurveyDataSheet",
                column: "BuildingStructureId",
                principalTable: "BuildingBuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

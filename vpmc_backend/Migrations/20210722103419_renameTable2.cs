using Microsoft.EntityFrameworkCore.Migrations;

namespace vpmc_backend.Migrations
{
    public partial class renameTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingAppraisalObject_AppraisalObjectId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingAssetType_AssetTypeId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingBuildingRightsStatus_BuildingRightsStatusId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingBuildingStructure_BuildingStructureId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingBuildingUsage_BuildingUsageId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingEvaluationRightsType_EvaluationRightsTypeId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingLandRightsStatus_LandRightsStatusId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingPriceType_PriceTypeId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_LandAppraisalObject_AppraisalObjectId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_LandAssetType_AssetTypeId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_LandEvaluationRightsType_EvaluationRightsTypeId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_LandLandRightsStatus_LandRightsStatusId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_LandPriceType_PriceTypeId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkAppraisalObject_AppraisalObjectId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkAssetType_AssetTypeId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkBuildingRightsStatus_BuildingRightsStatusId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_BuildingBuildingStructure_BuildingStructureId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkBuildingUsage_BuildingUsageId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkEvaluationRightsType_EvaluationRightsTypeId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkLandRightsStatus_LandRightsStatusId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkBuildingStructure_ParkBuildingStructureId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkPriceType_PriceTypeId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkPriceType",
                table: "ParkPriceType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkLandRightsStatus",
                table: "ParkLandRightsStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkEvaluationRightsType",
                table: "ParkEvaluationRightsType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkBuildingUsage",
                table: "ParkBuildingUsage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkBuildingStructure",
                table: "ParkBuildingStructure");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkBuildingRightsStatus",
                table: "ParkBuildingRightsStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkAssetType",
                table: "ParkAssetType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkAppraisalObject",
                table: "ParkAppraisalObject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LandPriceType",
                table: "LandPriceType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LandLandRightsStatus",
                table: "LandLandRightsStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LandEvaluationRightsType",
                table: "LandEvaluationRightsType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LandAssetType",
                table: "LandAssetType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LandAppraisalObject",
                table: "LandAppraisalObject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildingPriceType",
                table: "BuildingPriceType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildingLandRightsStatus",
                table: "BuildingLandRightsStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildingEvaluationRightsType",
                table: "BuildingEvaluationRightsType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildingBuildingUsage",
                table: "BuildingBuildingUsage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildingBuildingStructure",
                table: "BuildingBuildingStructure");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildingBuildingRightsStatus",
                table: "BuildingBuildingRightsStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildingAssetType",
                table: "BuildingAssetType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildingAppraisalObject",
                table: "BuildingAppraisalObject");

            migrationBuilder.RenameTable(
                name: "ParkPriceType",
                newName: "Park_PriceType");

            migrationBuilder.RenameTable(
                name: "ParkLandRightsStatus",
                newName: "Park_LandRightsStatus");

            migrationBuilder.RenameTable(
                name: "ParkEvaluationRightsType",
                newName: "Park_EvaluationRightsType");

            migrationBuilder.RenameTable(
                name: "ParkBuildingUsage",
                newName: "Park_BuildingUsage");

            migrationBuilder.RenameTable(
                name: "ParkBuildingStructure",
                newName: "Park_BuildingStructure");

            migrationBuilder.RenameTable(
                name: "ParkBuildingRightsStatus",
                newName: "Park_BuildingRightsStatus");

            migrationBuilder.RenameTable(
                name: "ParkAssetType",
                newName: "Park_AssetType");

            migrationBuilder.RenameTable(
                name: "ParkAppraisalObject",
                newName: "Park_AppraisalObject");

            migrationBuilder.RenameTable(
                name: "LandPriceType",
                newName: "Land_PriceType");

            migrationBuilder.RenameTable(
                name: "LandLandRightsStatus",
                newName: "Land_LandRightsStatus");

            migrationBuilder.RenameTable(
                name: "LandEvaluationRightsType",
                newName: "Land_EvaluationRightsType");

            migrationBuilder.RenameTable(
                name: "LandAssetType",
                newName: "Land_AssetType");

            migrationBuilder.RenameTable(
                name: "LandAppraisalObject",
                newName: "Land_AppraisalObject");

            migrationBuilder.RenameTable(
                name: "BuildingPriceType",
                newName: "Building_PriceType");

            migrationBuilder.RenameTable(
                name: "BuildingLandRightsStatus",
                newName: "Building_LandRightsStatus");

            migrationBuilder.RenameTable(
                name: "BuildingEvaluationRightsType",
                newName: "Building_EvaluationRightsType");

            migrationBuilder.RenameTable(
                name: "BuildingBuildingUsage",
                newName: "Building_BuildingUsage");

            migrationBuilder.RenameTable(
                name: "BuildingBuildingStructure",
                newName: "Building_BuildingStructure");

            migrationBuilder.RenameTable(
                name: "BuildingBuildingRightsStatus",
                newName: "Building_BuildingRightsStatus");

            migrationBuilder.RenameTable(
                name: "BuildingAssetType",
                newName: "Building_AssetType");

            migrationBuilder.RenameTable(
                name: "BuildingAppraisalObject",
                newName: "Building_AppraisalObject");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Park_PriceType",
                table: "Park_PriceType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Park_LandRightsStatus",
                table: "Park_LandRightsStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Park_EvaluationRightsType",
                table: "Park_EvaluationRightsType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Park_BuildingUsage",
                table: "Park_BuildingUsage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Park_BuildingStructure",
                table: "Park_BuildingStructure",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Park_BuildingRightsStatus",
                table: "Park_BuildingRightsStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Park_AssetType",
                table: "Park_AssetType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Park_AppraisalObject",
                table: "Park_AppraisalObject",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Land_PriceType",
                table: "Land_PriceType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Land_LandRightsStatus",
                table: "Land_LandRightsStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Land_EvaluationRightsType",
                table: "Land_EvaluationRightsType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Land_AssetType",
                table: "Land_AssetType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Land_AppraisalObject",
                table: "Land_AppraisalObject",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Building_PriceType",
                table: "Building_PriceType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Building_LandRightsStatus",
                table: "Building_LandRightsStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Building_EvaluationRightsType",
                table: "Building_EvaluationRightsType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Building_BuildingUsage",
                table: "Building_BuildingUsage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Building_BuildingStructure",
                table: "Building_BuildingStructure",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Building_BuildingRightsStatus",
                table: "Building_BuildingRightsStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Building_AssetType",
                table: "Building_AssetType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Building_AppraisalObject",
                table: "Building_AppraisalObject",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_AppraisalObject_AppraisalObjectId",
                table: "BuildingSurveyDataSheet",
                column: "AppraisalObjectId",
                principalTable: "Building_AppraisalObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_AssetType_AssetTypeId",
                table: "BuildingSurveyDataSheet",
                column: "AssetTypeId",
                principalTable: "Building_AssetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_BuildingRightsStatus_BuildingRightsStatusId",
                table: "BuildingSurveyDataSheet",
                column: "BuildingRightsStatusId",
                principalTable: "Building_BuildingRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_BuildingStructure_BuildingStructureId",
                table: "BuildingSurveyDataSheet",
                column: "BuildingStructureId",
                principalTable: "Building_BuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_BuildingUsage_BuildingUsageId",
                table: "BuildingSurveyDataSheet",
                column: "BuildingUsageId",
                principalTable: "Building_BuildingUsage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_EvaluationRightsType_EvaluationRightsTypeId",
                table: "BuildingSurveyDataSheet",
                column: "EvaluationRightsTypeId",
                principalTable: "Building_EvaluationRightsType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_LandRightsStatus_LandRightsStatusId",
                table: "BuildingSurveyDataSheet",
                column: "LandRightsStatusId",
                principalTable: "Building_LandRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_PriceType_PriceTypeId",
                table: "BuildingSurveyDataSheet",
                column: "PriceTypeId",
                principalTable: "Building_PriceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_Land_AppraisalObject_AppraisalObjectId",
                table: "LandSurveyDataSheet",
                column: "AppraisalObjectId",
                principalTable: "Land_AppraisalObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_Land_AssetType_AssetTypeId",
                table: "LandSurveyDataSheet",
                column: "AssetTypeId",
                principalTable: "Land_AssetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_Land_EvaluationRightsType_EvaluationRightsTypeId",
                table: "LandSurveyDataSheet",
                column: "EvaluationRightsTypeId",
                principalTable: "Land_EvaluationRightsType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_Land_LandRightsStatus_LandRightsStatusId",
                table: "LandSurveyDataSheet",
                column: "LandRightsStatusId",
                principalTable: "Land_LandRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_Land_PriceType_PriceTypeId",
                table: "LandSurveyDataSheet",
                column: "PriceTypeId",
                principalTable: "Land_PriceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_AppraisalObject_AppraisalObjectId",
                table: "ParkSurveyDataSheet",
                column: "AppraisalObjectId",
                principalTable: "Park_AppraisalObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_AssetType_AssetTypeId",
                table: "ParkSurveyDataSheet",
                column: "AssetTypeId",
                principalTable: "Park_AssetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_BuildingRightsStatus_BuildingRightsStatusId",
                table: "ParkSurveyDataSheet",
                column: "BuildingRightsStatusId",
                principalTable: "Park_BuildingRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_Building_BuildingStructure_BuildingStructureId",
                table: "ParkSurveyDataSheet",
                column: "BuildingStructureId",
                principalTable: "Building_BuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_BuildingUsage_BuildingUsageId",
                table: "ParkSurveyDataSheet",
                column: "BuildingUsageId",
                principalTable: "Park_BuildingUsage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_EvaluationRightsType_EvaluationRightsTypeId",
                table: "ParkSurveyDataSheet",
                column: "EvaluationRightsTypeId",
                principalTable: "Park_EvaluationRightsType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_LandRightsStatus_LandRightsStatusId",
                table: "ParkSurveyDataSheet",
                column: "LandRightsStatusId",
                principalTable: "Park_LandRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_BuildingStructure_ParkBuildingStructureId",
                table: "ParkSurveyDataSheet",
                column: "ParkBuildingStructureId",
                principalTable: "Park_BuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_PriceType_PriceTypeId",
                table: "ParkSurveyDataSheet",
                column: "PriceTypeId",
                principalTable: "Park_PriceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_AppraisalObject_AppraisalObjectId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_AssetType_AssetTypeId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_BuildingRightsStatus_BuildingRightsStatusId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_BuildingStructure_BuildingStructureId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_BuildingUsage_BuildingUsageId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_EvaluationRightsType_EvaluationRightsTypeId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_LandRightsStatus_LandRightsStatusId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_Building_PriceType_PriceTypeId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_Land_AppraisalObject_AppraisalObjectId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_Land_AssetType_AssetTypeId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_Land_EvaluationRightsType_EvaluationRightsTypeId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_Land_LandRightsStatus_LandRightsStatusId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_Land_PriceType_PriceTypeId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_AppraisalObject_AppraisalObjectId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_AssetType_AssetTypeId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_BuildingRightsStatus_BuildingRightsStatusId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_Building_BuildingStructure_BuildingStructureId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_BuildingUsage_BuildingUsageId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_EvaluationRightsType_EvaluationRightsTypeId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_LandRightsStatus_LandRightsStatusId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_BuildingStructure_ParkBuildingStructureId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_Park_PriceType_PriceTypeId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Park_PriceType",
                table: "Park_PriceType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Park_LandRightsStatus",
                table: "Park_LandRightsStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Park_EvaluationRightsType",
                table: "Park_EvaluationRightsType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Park_BuildingUsage",
                table: "Park_BuildingUsage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Park_BuildingStructure",
                table: "Park_BuildingStructure");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Park_BuildingRightsStatus",
                table: "Park_BuildingRightsStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Park_AssetType",
                table: "Park_AssetType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Park_AppraisalObject",
                table: "Park_AppraisalObject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Land_PriceType",
                table: "Land_PriceType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Land_LandRightsStatus",
                table: "Land_LandRightsStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Land_EvaluationRightsType",
                table: "Land_EvaluationRightsType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Land_AssetType",
                table: "Land_AssetType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Land_AppraisalObject",
                table: "Land_AppraisalObject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Building_PriceType",
                table: "Building_PriceType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Building_LandRightsStatus",
                table: "Building_LandRightsStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Building_EvaluationRightsType",
                table: "Building_EvaluationRightsType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Building_BuildingUsage",
                table: "Building_BuildingUsage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Building_BuildingStructure",
                table: "Building_BuildingStructure");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Building_BuildingRightsStatus",
                table: "Building_BuildingRightsStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Building_AssetType",
                table: "Building_AssetType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Building_AppraisalObject",
                table: "Building_AppraisalObject");

            migrationBuilder.RenameTable(
                name: "Park_PriceType",
                newName: "ParkPriceType");

            migrationBuilder.RenameTable(
                name: "Park_LandRightsStatus",
                newName: "ParkLandRightsStatus");

            migrationBuilder.RenameTable(
                name: "Park_EvaluationRightsType",
                newName: "ParkEvaluationRightsType");

            migrationBuilder.RenameTable(
                name: "Park_BuildingUsage",
                newName: "ParkBuildingUsage");

            migrationBuilder.RenameTable(
                name: "Park_BuildingStructure",
                newName: "ParkBuildingStructure");

            migrationBuilder.RenameTable(
                name: "Park_BuildingRightsStatus",
                newName: "ParkBuildingRightsStatus");

            migrationBuilder.RenameTable(
                name: "Park_AssetType",
                newName: "ParkAssetType");

            migrationBuilder.RenameTable(
                name: "Park_AppraisalObject",
                newName: "ParkAppraisalObject");

            migrationBuilder.RenameTable(
                name: "Land_PriceType",
                newName: "LandPriceType");

            migrationBuilder.RenameTable(
                name: "Land_LandRightsStatus",
                newName: "LandLandRightsStatus");

            migrationBuilder.RenameTable(
                name: "Land_EvaluationRightsType",
                newName: "LandEvaluationRightsType");

            migrationBuilder.RenameTable(
                name: "Land_AssetType",
                newName: "LandAssetType");

            migrationBuilder.RenameTable(
                name: "Land_AppraisalObject",
                newName: "LandAppraisalObject");

            migrationBuilder.RenameTable(
                name: "Building_PriceType",
                newName: "BuildingPriceType");

            migrationBuilder.RenameTable(
                name: "Building_LandRightsStatus",
                newName: "BuildingLandRightsStatus");

            migrationBuilder.RenameTable(
                name: "Building_EvaluationRightsType",
                newName: "BuildingEvaluationRightsType");

            migrationBuilder.RenameTable(
                name: "Building_BuildingUsage",
                newName: "BuildingBuildingUsage");

            migrationBuilder.RenameTable(
                name: "Building_BuildingStructure",
                newName: "BuildingBuildingStructure");

            migrationBuilder.RenameTable(
                name: "Building_BuildingRightsStatus",
                newName: "BuildingBuildingRightsStatus");

            migrationBuilder.RenameTable(
                name: "Building_AssetType",
                newName: "BuildingAssetType");

            migrationBuilder.RenameTable(
                name: "Building_AppraisalObject",
                newName: "BuildingAppraisalObject");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkPriceType",
                table: "ParkPriceType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkLandRightsStatus",
                table: "ParkLandRightsStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkEvaluationRightsType",
                table: "ParkEvaluationRightsType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkBuildingUsage",
                table: "ParkBuildingUsage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkBuildingStructure",
                table: "ParkBuildingStructure",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkBuildingRightsStatus",
                table: "ParkBuildingRightsStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkAssetType",
                table: "ParkAssetType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkAppraisalObject",
                table: "ParkAppraisalObject",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LandPriceType",
                table: "LandPriceType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LandLandRightsStatus",
                table: "LandLandRightsStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LandEvaluationRightsType",
                table: "LandEvaluationRightsType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LandAssetType",
                table: "LandAssetType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LandAppraisalObject",
                table: "LandAppraisalObject",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildingPriceType",
                table: "BuildingPriceType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildingLandRightsStatus",
                table: "BuildingLandRightsStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildingEvaluationRightsType",
                table: "BuildingEvaluationRightsType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildingBuildingUsage",
                table: "BuildingBuildingUsage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildingBuildingStructure",
                table: "BuildingBuildingStructure",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildingBuildingRightsStatus",
                table: "BuildingBuildingRightsStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildingAssetType",
                table: "BuildingAssetType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildingAppraisalObject",
                table: "BuildingAppraisalObject",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingAppraisalObject_AppraisalObjectId",
                table: "BuildingSurveyDataSheet",
                column: "AppraisalObjectId",
                principalTable: "BuildingAppraisalObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingAssetType_AssetTypeId",
                table: "BuildingSurveyDataSheet",
                column: "AssetTypeId",
                principalTable: "BuildingAssetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingBuildingRightsStatus_BuildingRightsStatusId",
                table: "BuildingSurveyDataSheet",
                column: "BuildingRightsStatusId",
                principalTable: "BuildingBuildingRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingBuildingStructure_BuildingStructureId",
                table: "BuildingSurveyDataSheet",
                column: "BuildingStructureId",
                principalTable: "BuildingBuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingBuildingUsage_BuildingUsageId",
                table: "BuildingSurveyDataSheet",
                column: "BuildingUsageId",
                principalTable: "BuildingBuildingUsage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingEvaluationRightsType_EvaluationRightsTypeId",
                table: "BuildingSurveyDataSheet",
                column: "EvaluationRightsTypeId",
                principalTable: "BuildingEvaluationRightsType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingLandRightsStatus_LandRightsStatusId",
                table: "BuildingSurveyDataSheet",
                column: "LandRightsStatusId",
                principalTable: "BuildingLandRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingPriceType_PriceTypeId",
                table: "BuildingSurveyDataSheet",
                column: "PriceTypeId",
                principalTable: "BuildingPriceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_LandAppraisalObject_AppraisalObjectId",
                table: "LandSurveyDataSheet",
                column: "AppraisalObjectId",
                principalTable: "LandAppraisalObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_LandAssetType_AssetTypeId",
                table: "LandSurveyDataSheet",
                column: "AssetTypeId",
                principalTable: "LandAssetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_LandEvaluationRightsType_EvaluationRightsTypeId",
                table: "LandSurveyDataSheet",
                column: "EvaluationRightsTypeId",
                principalTable: "LandEvaluationRightsType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_LandLandRightsStatus_LandRightsStatusId",
                table: "LandSurveyDataSheet",
                column: "LandRightsStatusId",
                principalTable: "LandLandRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_LandPriceType_PriceTypeId",
                table: "LandSurveyDataSheet",
                column: "PriceTypeId",
                principalTable: "LandPriceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkAppraisalObject_AppraisalObjectId",
                table: "ParkSurveyDataSheet",
                column: "AppraisalObjectId",
                principalTable: "ParkAppraisalObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkAssetType_AssetTypeId",
                table: "ParkSurveyDataSheet",
                column: "AssetTypeId",
                principalTable: "ParkAssetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkBuildingRightsStatus_BuildingRightsStatusId",
                table: "ParkSurveyDataSheet",
                column: "BuildingRightsStatusId",
                principalTable: "ParkBuildingRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_BuildingBuildingStructure_BuildingStructureId",
                table: "ParkSurveyDataSheet",
                column: "BuildingStructureId",
                principalTable: "BuildingBuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkBuildingUsage_BuildingUsageId",
                table: "ParkSurveyDataSheet",
                column: "BuildingUsageId",
                principalTable: "ParkBuildingUsage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkEvaluationRightsType_EvaluationRightsTypeId",
                table: "ParkSurveyDataSheet",
                column: "EvaluationRightsTypeId",
                principalTable: "ParkEvaluationRightsType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkLandRightsStatus_LandRightsStatusId",
                table: "ParkSurveyDataSheet",
                column: "LandRightsStatusId",
                principalTable: "ParkLandRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkBuildingStructure_ParkBuildingStructureId",
                table: "ParkSurveyDataSheet",
                column: "ParkBuildingStructureId",
                principalTable: "ParkBuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkPriceType_PriceTypeId",
                table: "ParkSurveyDataSheet",
                column: "PriceTypeId",
                principalTable: "ParkPriceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

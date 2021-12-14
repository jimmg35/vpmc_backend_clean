using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vpmc_backend.Migrations
{
    public partial class deleteSDS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildingSurveyDataSheet");

            migrationBuilder.DropTable(
                name: "LandSurveyDataSheet");

            migrationBuilder.DropTable(
                name: "ParkSurveyDataSheet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuildingSurveyDataSheet",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AppraisalCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppraisalDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppraisalObjectId = table.Column<int>(type: "int", nullable: true),
                    AssetTypeId = table.Column<int>(type: "int", nullable: true),
                    BuildAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildAddressCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildAddressVillage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildMarkCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildMarkCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildMarkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildMarkVillage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingArea = table.Column<double>(type: "float", nullable: false),
                    BuildingCoverageRatio = table.Column<double>(type: "float", nullable: false),
                    BuildingDownFloor = table.Column<int>(type: "int", nullable: false),
                    BuildingFinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BuildingRightsHolding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingRightsOwner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingRightsStatusId = table.Column<int>(type: "int", nullable: true),
                    BuildingStructureId = table.Column<int>(type: "int", nullable: true),
                    BuildingUpFloor = table.Column<int>(type: "int", nullable: false),
                    BuildingUsageId = table.Column<int>(type: "int", nullable: true),
                    EvaluationRightsTypeId = table.Column<int>(type: "int", nullable: true),
                    FloorAreaRatio = table.Column<double>(type: "float", nullable: false),
                    InspectionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LandArea = table.Column<double>(type: "float", nullable: false),
                    LandMarkCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandMarkCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandMarkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandMarkVillage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandRightsHolding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandRightsOwner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandRightsStatusId = table.Column<int>(type: "int", nullable: true),
                    LandUses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherRights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceTypeId = table.Column<int>(type: "int", nullable: true),
                    SurveyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurveyFloor = table.Column<int>(type: "int", nullable: false),
                    SurveyorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranscriptPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueOpinionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingSurveyDataSheet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingSurveyDataSheet_AppraisalObject_AppraisalObjectId",
                        column: x => x.AppraisalObjectId,
                        principalTable: "AppraisalObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuildingSurveyDataSheet_AssetType_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuildingSurveyDataSheet_BuildingRightsStatus_BuildingRightsStatusId",
                        column: x => x.BuildingRightsStatusId,
                        principalTable: "BuildingRightsStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuildingSurveyDataSheet_BuildingStructure_BuildingStructureId",
                        column: x => x.BuildingStructureId,
                        principalTable: "BuildingStructure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuildingSurveyDataSheet_BuildingUsage_BuildingUsageId",
                        column: x => x.BuildingUsageId,
                        principalTable: "BuildingUsage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuildingSurveyDataSheet_EvaluationRightsType_EvaluationRightsTypeId",
                        column: x => x.EvaluationRightsTypeId,
                        principalTable: "EvaluationRightsType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuildingSurveyDataSheet_LandRightsStatus_LandRightsStatusId",
                        column: x => x.LandRightsStatusId,
                        principalTable: "LandRightsStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuildingSurveyDataSheet_PriceType_PriceTypeId",
                        column: x => x.PriceTypeId,
                        principalTable: "PriceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LandSurveyDataSheet",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AppraisalCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppraisalDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppraisalObjectId = table.Column<int>(type: "int", nullable: true),
                    AssetTypeId = table.Column<int>(type: "int", nullable: true),
                    BuildAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildAddressCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildAddressVillage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildMarkCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildMarkCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildMarkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildMarkVillage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingCoverageRatio = table.Column<double>(type: "float", nullable: false),
                    EvaluationRightsTypeId = table.Column<int>(type: "int", nullable: true),
                    FloorAreaRatio = table.Column<double>(type: "float", nullable: false),
                    InspectionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LandArea = table.Column<double>(type: "float", nullable: false),
                    LandMarkCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandMarkCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandMarkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandMarkVillage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandRightsHolding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandRightsOwner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandRightsStatusId = table.Column<int>(type: "int", nullable: true),
                    LandUses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherRights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceTypeId = table.Column<int>(type: "int", nullable: true),
                    SurveyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurveyorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranscriptPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueOpinionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandSurveyDataSheet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LandSurveyDataSheet_AppraisalObject_AppraisalObjectId",
                        column: x => x.AppraisalObjectId,
                        principalTable: "AppraisalObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LandSurveyDataSheet_AssetType_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LandSurveyDataSheet_EvaluationRightsType_EvaluationRightsTypeId",
                        column: x => x.EvaluationRightsTypeId,
                        principalTable: "EvaluationRightsType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LandSurveyDataSheet_LandRightsStatus_LandRightsStatusId",
                        column: x => x.LandRightsStatusId,
                        principalTable: "LandRightsStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LandSurveyDataSheet_PriceType_PriceTypeId",
                        column: x => x.PriceTypeId,
                        principalTable: "PriceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParkSurveyDataSheet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowSuv = table.Column<bool>(type: "bit", nullable: false),
                    AppraisalCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppraisalDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppraisalObjectId = table.Column<int>(type: "int", nullable: true),
                    AssetTypeId = table.Column<int>(type: "int", nullable: true),
                    AssignMethodId = table.Column<int>(type: "int", nullable: true),
                    BuildAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildAddressCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildAddressVillage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildMarkCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildMarkCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildMarkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildMarkVillage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingCoverageRatio = table.Column<double>(type: "float", nullable: false),
                    BuildingDownFloor = table.Column<int>(type: "int", nullable: false),
                    BuildingFinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BuildingRightsHolding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingRightsOwner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingRightsStatusId = table.Column<int>(type: "int", nullable: true),
                    BuildingStructureId = table.Column<int>(type: "int", nullable: true),
                    BuildingUpFloor = table.Column<int>(type: "int", nullable: false),
                    BuildingUsageId = table.Column<int>(type: "int", nullable: true),
                    EvaluationRightsTypeId = table.Column<int>(type: "int", nullable: true),
                    FloorAreaRatio = table.Column<double>(type: "float", nullable: false),
                    InspectionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LandMarkCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandMarkCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandMarkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandMarkVillage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandRightsHolding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandRightsOwner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandRightsStatusId = table.Column<int>(type: "int", nullable: true),
                    LandUses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherRights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkArea = table.Column<double>(type: "float", nullable: false),
                    ParkHeight = table.Column<double>(type: "float", nullable: false),
                    ParkMethodId = table.Column<int>(type: "int", nullable: true),
                    ParkTypeId = table.Column<int>(type: "int", nullable: true),
                    ParkWidth = table.Column<double>(type: "float", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceTypeId = table.Column<int>(type: "int", nullable: true),
                    SurveyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurveyFloor = table.Column<int>(type: "int", nullable: false),
                    SurveyorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranscriptPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueOpinionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkSurveyDataSheet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParkSurveyDataSheet_AppraisalObject_AppraisalObjectId",
                        column: x => x.AppraisalObjectId,
                        principalTable: "AppraisalObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParkSurveyDataSheet_AssetType_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParkSurveyDataSheet_AssignMethod_AssignMethodId",
                        column: x => x.AssignMethodId,
                        principalTable: "AssignMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParkSurveyDataSheet_BuildingRightsStatus_BuildingRightsStatusId",
                        column: x => x.BuildingRightsStatusId,
                        principalTable: "BuildingRightsStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParkSurveyDataSheet_BuildingStructure_BuildingStructureId",
                        column: x => x.BuildingStructureId,
                        principalTable: "BuildingStructure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParkSurveyDataSheet_BuildingUsage_BuildingUsageId",
                        column: x => x.BuildingUsageId,
                        principalTable: "BuildingUsage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParkSurveyDataSheet_EvaluationRightsType_EvaluationRightsTypeId",
                        column: x => x.EvaluationRightsTypeId,
                        principalTable: "EvaluationRightsType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParkSurveyDataSheet_LandRightsStatus_LandRightsStatusId",
                        column: x => x.LandRightsStatusId,
                        principalTable: "LandRightsStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParkSurveyDataSheet_ParkMethod_ParkMethodId",
                        column: x => x.ParkMethodId,
                        principalTable: "ParkMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParkSurveyDataSheet_ParkType_ParkTypeId",
                        column: x => x.ParkTypeId,
                        principalTable: "ParkType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParkSurveyDataSheet_PriceType_PriceTypeId",
                        column: x => x.PriceTypeId,
                        principalTable: "PriceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildingSurveyDataSheet_AppraisalObjectId",
                table: "BuildingSurveyDataSheet",
                column: "AppraisalObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingSurveyDataSheet_AssetTypeId",
                table: "BuildingSurveyDataSheet",
                column: "AssetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingSurveyDataSheet_BuildingRightsStatusId",
                table: "BuildingSurveyDataSheet",
                column: "BuildingRightsStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingSurveyDataSheet_BuildingStructureId",
                table: "BuildingSurveyDataSheet",
                column: "BuildingStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingSurveyDataSheet_BuildingUsageId",
                table: "BuildingSurveyDataSheet",
                column: "BuildingUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingSurveyDataSheet_EvaluationRightsTypeId",
                table: "BuildingSurveyDataSheet",
                column: "EvaluationRightsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingSurveyDataSheet_LandRightsStatusId",
                table: "BuildingSurveyDataSheet",
                column: "LandRightsStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingSurveyDataSheet_PriceTypeId",
                table: "BuildingSurveyDataSheet",
                column: "PriceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LandSurveyDataSheet_AppraisalObjectId",
                table: "LandSurveyDataSheet",
                column: "AppraisalObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_LandSurveyDataSheet_AssetTypeId",
                table: "LandSurveyDataSheet",
                column: "AssetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LandSurveyDataSheet_EvaluationRightsTypeId",
                table: "LandSurveyDataSheet",
                column: "EvaluationRightsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LandSurveyDataSheet_LandRightsStatusId",
                table: "LandSurveyDataSheet",
                column: "LandRightsStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_LandSurveyDataSheet_PriceTypeId",
                table: "LandSurveyDataSheet",
                column: "PriceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkSurveyDataSheet_AppraisalObjectId",
                table: "ParkSurveyDataSheet",
                column: "AppraisalObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkSurveyDataSheet_AssetTypeId",
                table: "ParkSurveyDataSheet",
                column: "AssetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkSurveyDataSheet_AssignMethodId",
                table: "ParkSurveyDataSheet",
                column: "AssignMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkSurveyDataSheet_BuildingRightsStatusId",
                table: "ParkSurveyDataSheet",
                column: "BuildingRightsStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkSurveyDataSheet_BuildingStructureId",
                table: "ParkSurveyDataSheet",
                column: "BuildingStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkSurveyDataSheet_BuildingUsageId",
                table: "ParkSurveyDataSheet",
                column: "BuildingUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkSurveyDataSheet_EvaluationRightsTypeId",
                table: "ParkSurveyDataSheet",
                column: "EvaluationRightsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkSurveyDataSheet_LandRightsStatusId",
                table: "ParkSurveyDataSheet",
                column: "LandRightsStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkSurveyDataSheet_ParkMethodId",
                table: "ParkSurveyDataSheet",
                column: "ParkMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkSurveyDataSheet_ParkTypeId",
                table: "ParkSurveyDataSheet",
                column: "ParkTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkSurveyDataSheet_PriceTypeId",
                table: "ParkSurveyDataSheet",
                column: "PriceTypeId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace vpmc_backend.Migrations
{
    public partial class ReconstructSDSmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_AppraisalObject_AppraisalObjectId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_AssetType_AssetTypeId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingRightsStatus_BuildingRightsStatusId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingStructure_BuildingStructureId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingUsage_BuildingUsageId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_EvaluationRightsType_EvaluationRightsTypeId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_LandRightsStatus_LandRightsStatusId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingSurveyDataSheet_PriceType_PriceTypeId",
                table: "BuildingSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_AppraisalObject_AppraisalObjectId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_AssetType_AssetTypeId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_EvaluationRightsType_EvaluationRightsTypeId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_LandRightsStatus_LandRightsStatusId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_LandSurveyDataSheet_PriceType_PriceTypeId",
                table: "LandSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_AppraisalObject_AppraisalObjectId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_AssetType_AssetTypeId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_AssignMethod_AssignMethodId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_BuildingRightsStatus_BuildingRightsStatusId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_BuildingStructure_BuildingStructureId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_BuildingUsage_BuildingUsageId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_EvaluationRightsType_EvaluationRightsTypeId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_LandRightsStatus_LandRightsStatusId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkMethod_ParkMethodId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkType_ParkTypeId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_PriceType_PriceTypeId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropTable(
                name: "AppraisalObject");

            migrationBuilder.DropTable(
                name: "AssetType");

            migrationBuilder.DropTable(
                name: "BuildingRightsStatus");

            migrationBuilder.DropTable(
                name: "BuildingStructure");

            migrationBuilder.DropTable(
                name: "BuildingUsage");

            migrationBuilder.DropTable(
                name: "EvaluationRightsType");

            migrationBuilder.DropTable(
                name: "LandRightsStatus");

            migrationBuilder.DropTable(
                name: "PriceType");

            migrationBuilder.AlterColumn<int>(
                name: "PriceTypeId",
                table: "ParkSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParkTypeId",
                table: "ParkSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParkMethodId",
                table: "ParkSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LandRightsStatusId",
                table: "ParkSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EvaluationRightsTypeId",
                table: "ParkSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BuildingUsageId",
                table: "ParkSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BuildingStructureId",
                table: "ParkSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BuildingRightsStatusId",
                table: "ParkSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssignMethodId",
                table: "ParkSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssetTypeId",
                table: "ParkSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AppraisalObjectId",
                table: "ParkSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParkBuildingStructureId",
                table: "ParkSurveyDataSheet",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PriceTypeId",
                table: "LandSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LandRightsStatusId",
                table: "LandSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EvaluationRightsTypeId",
                table: "LandSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssetTypeId",
                table: "LandSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AppraisalObjectId",
                table: "LandSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PriceTypeId",
                table: "BuildingSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LandRightsStatusId",
                table: "BuildingSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EvaluationRightsTypeId",
                table: "BuildingSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BuildingUsageId",
                table: "BuildingSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BuildingStructureId",
                table: "BuildingSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BuildingRightsStatusId",
                table: "BuildingSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssetTypeId",
                table: "BuildingSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AppraisalObjectId",
                table: "BuildingSurveyDataSheet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "BuildingAppraisalObject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Object = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingAppraisalObject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingAssetType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingAssetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingBuildingRightsStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingBuildingRightsStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingBuildingStructure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Structure = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingBuildingStructure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingBuildingUsage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingBuildingUsage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingEvaluationRightsType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingEvaluationRightsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingLandRightsStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingLandRightsStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingPriceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingPriceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LandAppraisalObject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Object = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandAppraisalObject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LandAssetType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandAssetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LandEvaluationRightsType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandEvaluationRightsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LandLandRightsStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandLandRightsStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LandPriceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandPriceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParkAppraisalObject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Object = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkAppraisalObject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParkAssetType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkAssetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParkBuildingRightsStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkBuildingRightsStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParkBuildingStructure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Structure = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkBuildingStructure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParkBuildingUsage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkBuildingUsage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParkEvaluationRightsType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkEvaluationRightsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParkLandRightsStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkLandRightsStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParkPriceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkPriceType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParkSurveyDataSheet_ParkBuildingStructureId",
                table: "ParkSurveyDataSheet",
                column: "ParkBuildingStructureId");

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
                name: "FK_ParkSurveyDataSheet_AssignMethod_AssignMethodId",
                table: "ParkSurveyDataSheet",
                column: "AssignMethodId",
                principalTable: "AssignMethod",
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
                name: "FK_ParkSurveyDataSheet_ParkMethod_ParkMethodId",
                table: "ParkSurveyDataSheet",
                column: "ParkMethodId",
                principalTable: "ParkMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkType_ParkTypeId",
                table: "ParkSurveyDataSheet",
                column: "ParkTypeId",
                principalTable: "ParkType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkPriceType_PriceTypeId",
                table: "ParkSurveyDataSheet",
                column: "PriceTypeId",
                principalTable: "ParkPriceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_ParkSurveyDataSheet_AssignMethod_AssignMethodId",
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
                name: "FK_ParkSurveyDataSheet_ParkMethod_ParkMethodId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkType_ParkTypeId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkPriceType_PriceTypeId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropTable(
                name: "BuildingAppraisalObject");

            migrationBuilder.DropTable(
                name: "BuildingAssetType");

            migrationBuilder.DropTable(
                name: "BuildingBuildingRightsStatus");

            migrationBuilder.DropTable(
                name: "BuildingBuildingStructure");

            migrationBuilder.DropTable(
                name: "BuildingBuildingUsage");

            migrationBuilder.DropTable(
                name: "BuildingEvaluationRightsType");

            migrationBuilder.DropTable(
                name: "BuildingLandRightsStatus");

            migrationBuilder.DropTable(
                name: "BuildingPriceType");

            migrationBuilder.DropTable(
                name: "LandAppraisalObject");

            migrationBuilder.DropTable(
                name: "LandAssetType");

            migrationBuilder.DropTable(
                name: "LandEvaluationRightsType");

            migrationBuilder.DropTable(
                name: "LandLandRightsStatus");

            migrationBuilder.DropTable(
                name: "LandPriceType");

            migrationBuilder.DropTable(
                name: "ParkAppraisalObject");

            migrationBuilder.DropTable(
                name: "ParkAssetType");

            migrationBuilder.DropTable(
                name: "ParkBuildingRightsStatus");

            migrationBuilder.DropTable(
                name: "ParkBuildingStructure");

            migrationBuilder.DropTable(
                name: "ParkBuildingUsage");

            migrationBuilder.DropTable(
                name: "ParkEvaluationRightsType");

            migrationBuilder.DropTable(
                name: "ParkLandRightsStatus");

            migrationBuilder.DropTable(
                name: "ParkPriceType");

            migrationBuilder.DropIndex(
                name: "IX_ParkSurveyDataSheet_ParkBuildingStructureId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.DropColumn(
                name: "ParkBuildingStructureId",
                table: "ParkSurveyDataSheet");

            migrationBuilder.AlterColumn<int>(
                name: "PriceTypeId",
                table: "ParkSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ParkTypeId",
                table: "ParkSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ParkMethodId",
                table: "ParkSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LandRightsStatusId",
                table: "ParkSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EvaluationRightsTypeId",
                table: "ParkSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BuildingUsageId",
                table: "ParkSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BuildingStructureId",
                table: "ParkSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BuildingRightsStatusId",
                table: "ParkSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AssignMethodId",
                table: "ParkSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AssetTypeId",
                table: "ParkSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AppraisalObjectId",
                table: "ParkSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PriceTypeId",
                table: "LandSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LandRightsStatusId",
                table: "LandSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EvaluationRightsTypeId",
                table: "LandSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AssetTypeId",
                table: "LandSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AppraisalObjectId",
                table: "LandSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PriceTypeId",
                table: "BuildingSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LandRightsStatusId",
                table: "BuildingSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EvaluationRightsTypeId",
                table: "BuildingSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BuildingUsageId",
                table: "BuildingSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BuildingStructureId",
                table: "BuildingSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BuildingRightsStatusId",
                table: "BuildingSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AssetTypeId",
                table: "BuildingSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AppraisalObjectId",
                table: "BuildingSurveyDataSheet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "AppraisalObject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Object = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppraisalObject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssetType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingRightsStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingRightsStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingStructure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Structure = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingStructure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingUsage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingUsage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationRightsType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationRightsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LandRightsStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandRightsStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceType", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_AppraisalObject_AppraisalObjectId",
                table: "BuildingSurveyDataSheet",
                column: "AppraisalObjectId",
                principalTable: "AppraisalObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_AssetType_AssetTypeId",
                table: "BuildingSurveyDataSheet",
                column: "AssetTypeId",
                principalTable: "AssetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingRightsStatus_BuildingRightsStatusId",
                table: "BuildingSurveyDataSheet",
                column: "BuildingRightsStatusId",
                principalTable: "BuildingRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingStructure_BuildingStructureId",
                table: "BuildingSurveyDataSheet",
                column: "BuildingStructureId",
                principalTable: "BuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_BuildingUsage_BuildingUsageId",
                table: "BuildingSurveyDataSheet",
                column: "BuildingUsageId",
                principalTable: "BuildingUsage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_EvaluationRightsType_EvaluationRightsTypeId",
                table: "BuildingSurveyDataSheet",
                column: "EvaluationRightsTypeId",
                principalTable: "EvaluationRightsType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_LandRightsStatus_LandRightsStatusId",
                table: "BuildingSurveyDataSheet",
                column: "LandRightsStatusId",
                principalTable: "LandRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingSurveyDataSheet_PriceType_PriceTypeId",
                table: "BuildingSurveyDataSheet",
                column: "PriceTypeId",
                principalTable: "PriceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_AppraisalObject_AppraisalObjectId",
                table: "LandSurveyDataSheet",
                column: "AppraisalObjectId",
                principalTable: "AppraisalObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_AssetType_AssetTypeId",
                table: "LandSurveyDataSheet",
                column: "AssetTypeId",
                principalTable: "AssetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_EvaluationRightsType_EvaluationRightsTypeId",
                table: "LandSurveyDataSheet",
                column: "EvaluationRightsTypeId",
                principalTable: "EvaluationRightsType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_LandRightsStatus_LandRightsStatusId",
                table: "LandSurveyDataSheet",
                column: "LandRightsStatusId",
                principalTable: "LandRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LandSurveyDataSheet_PriceType_PriceTypeId",
                table: "LandSurveyDataSheet",
                column: "PriceTypeId",
                principalTable: "PriceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_AppraisalObject_AppraisalObjectId",
                table: "ParkSurveyDataSheet",
                column: "AppraisalObjectId",
                principalTable: "AppraisalObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_AssetType_AssetTypeId",
                table: "ParkSurveyDataSheet",
                column: "AssetTypeId",
                principalTable: "AssetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_AssignMethod_AssignMethodId",
                table: "ParkSurveyDataSheet",
                column: "AssignMethodId",
                principalTable: "AssignMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_BuildingRightsStatus_BuildingRightsStatusId",
                table: "ParkSurveyDataSheet",
                column: "BuildingRightsStatusId",
                principalTable: "BuildingRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_BuildingStructure_BuildingStructureId",
                table: "ParkSurveyDataSheet",
                column: "BuildingStructureId",
                principalTable: "BuildingStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_BuildingUsage_BuildingUsageId",
                table: "ParkSurveyDataSheet",
                column: "BuildingUsageId",
                principalTable: "BuildingUsage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_EvaluationRightsType_EvaluationRightsTypeId",
                table: "ParkSurveyDataSheet",
                column: "EvaluationRightsTypeId",
                principalTable: "EvaluationRightsType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_LandRightsStatus_LandRightsStatusId",
                table: "ParkSurveyDataSheet",
                column: "LandRightsStatusId",
                principalTable: "LandRightsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkMethod_ParkMethodId",
                table: "ParkSurveyDataSheet",
                column: "ParkMethodId",
                principalTable: "ParkMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_ParkType_ParkTypeId",
                table: "ParkSurveyDataSheet",
                column: "ParkTypeId",
                principalTable: "ParkType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSurveyDataSheet_PriceType_PriceTypeId",
                table: "ParkSurveyDataSheet",
                column: "PriceTypeId",
                principalTable: "PriceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

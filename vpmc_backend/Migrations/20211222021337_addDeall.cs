using Microsoft.EntityFrameworkCore.Migrations;

namespace vpmc_backend.Migrations
{
    public partial class addDeall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deal",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    NonMetroLandUseDistrict = table.Column<string>(nullable: true),
                    LandTransactionAmount = table.Column<short>(nullable: true),
                    BuildingTransactionAmount = table.Column<short>(nullable: true),
                    ParkTransactionAmount = table.Column<short>(nullable: true),
                    TotalFloorNumber = table.Column<short>(nullable: true),
                    BuildingMaterial = table.Column<string>(nullable: true),
                    TransactionSign = table.Column<string>(nullable: true),
                    NonMetroLandUse = table.Column<string>(nullable: true),
                    TransactionDate = table.Column<string>(nullable: true),
                    CompletionDate = table.Column<string>(nullable: true),
                    ShiftingLevel = table.Column<string>(nullable: true),
                    ParsedShiftingLevel = table.Column<int>(nullable: true),
                    BuildingState = table.Column<string>(nullable: true),
                    ParkCategory = table.Column<string>(nullable: true),
                    MainUse = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    LandUse = table.Column<string>(nullable: true),
                    Town = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    BuildingShiftingArea = table.Column<float>(nullable: true),
                    LandShiftingArea = table.Column<float>(nullable: true),
                    MainBuildingArea = table.Column<float>(nullable: true),
                    ParkShiftingArea = table.Column<float>(nullable: true),
                    SubBuildingArea = table.Column<float>(nullable: true),
                    ParkTotalPrice = table.Column<int>(nullable: true),
                    BelconyArea = table.Column<float>(nullable: true),
                    TotalPrice = table.Column<int>(nullable: true),
                    UnitPrice = table.Column<float>(nullable: true),
                    BathNumber = table.Column<short>(nullable: true),
                    BedNumber = table.Column<short>(nullable: true),
                    HallNumber = table.Column<short>(nullable: true),
                    HasManageOrganization = table.Column<string>(nullable: true),
                    HasCompartmented = table.Column<string>(nullable: true),
                    HasElevator = table.Column<string>(nullable: true),
                    CoordinateX = table.Column<int>(nullable: true),
                    CoordinateY = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deal_Manage",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    NonMetroLandUseDistrict = table.Column<string>(nullable: true),
                    LandTransactionAmount = table.Column<short>(nullable: true),
                    BuildingTransactionAmount = table.Column<short>(nullable: true),
                    ParkTransactionAmount = table.Column<short>(nullable: true),
                    TotalFloorNumber = table.Column<short>(nullable: true),
                    BuildingMaterial = table.Column<string>(nullable: true),
                    TransactionSign = table.Column<string>(nullable: true),
                    NonMetroLandUse = table.Column<string>(nullable: true),
                    TransactionDate = table.Column<string>(nullable: true),
                    CompletionDate = table.Column<string>(nullable: true),
                    ShiftingLevel = table.Column<string>(nullable: true),
                    ParsedShiftingLevel = table.Column<int>(nullable: true),
                    BuildingState = table.Column<string>(nullable: true),
                    ParkCategory = table.Column<string>(nullable: true),
                    MainUse = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    LandUse = table.Column<string>(nullable: true),
                    Town = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    BuildingShiftingArea = table.Column<float>(nullable: true),
                    LandShiftingArea = table.Column<float>(nullable: true),
                    MainBuildingArea = table.Column<float>(nullable: true),
                    ParkShiftingArea = table.Column<float>(nullable: true),
                    SubBuildingArea = table.Column<float>(nullable: true),
                    ParkTotalPrice = table.Column<int>(nullable: true),
                    BelconyArea = table.Column<float>(nullable: true),
                    TotalPrice = table.Column<int>(nullable: true),
                    UnitPrice = table.Column<float>(nullable: true),
                    BathNumber = table.Column<short>(nullable: true),
                    BedNumber = table.Column<short>(nullable: true),
                    HallNumber = table.Column<short>(nullable: true),
                    HasManageOrganization = table.Column<string>(nullable: true),
                    HasCompartmented = table.Column<string>(nullable: true),
                    HasElevator = table.Column<string>(nullable: true),
                    CoordinateX = table.Column<int>(nullable: true),
                    CoordinateY = table.Column<int>(nullable: true),
                    ManageName = table.Column<string>(nullable: true),
                    ManageAddress = table.Column<string>(nullable: true),
                    LicenseNum = table.Column<string>(nullable: true),
                    LicensedDate = table.Column<string>(nullable: true),
                    LicensedRecord = table.Column<string>(nullable: true),
                    LicenseRecordNum = table.Column<string>(nullable: true),
                    LicenseType = table.Column<string>(nullable: true),
                    LicenseGiven = table.Column<string>(nullable: true),
                    OirgLicenseGiven = table.Column<string>(nullable: true),
                    DesignChanged = table.Column<short>(nullable: true),
                    SiteArea = table.Column<string>(nullable: true),
                    BuildingArea = table.Column<string>(nullable: true),
                    TotalFloorArea = table.Column<string>(nullable: true),
                    BuildingHeight = table.Column<string>(nullable: true),
                    UndergroundArea = table.Column<string>(nullable: true),
                    OpenArea = table.Column<string>(nullable: true),
                    BuildingType = table.Column<string>(nullable: true),
                    StructureType = table.Column<string>(nullable: true),
                    FloorAbove = table.Column<short>(nullable: true),
                    FloorBelow = table.Column<string>(nullable: true),
                    BuildingNum = table.Column<string>(nullable: true),
                    UnitNumber = table.Column<string>(nullable: true),
                    Representative = table.Column<string>(nullable: true),
                    Designer = table.Column<string>(nullable: true),
                    Supervision = table.Column<string>(nullable: true),
                    Contractor = table.Column<string>(nullable: true),
                    Misc = table.Column<string>(nullable: true),
                    ParkingSpace = table.Column<string>(nullable: true),
                    IssuedDate = table.Column<string>(nullable: true),
                    ConstructionStart = table.Column<string>(nullable: true),
                    ConstructionEnd = table.Column<string>(nullable: true),
                    FloorSummary = table.Column<string>(nullable: true),
                    ConstructionParcel = table.Column<string>(nullable: true),
                    ConstructionAddress = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Longitude = table.Column<float>(nullable: true),
                    Latitude = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deal_Manage", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deal");

            migrationBuilder.DropTable(
                name: "Deal_Manage");
        }
    }
}

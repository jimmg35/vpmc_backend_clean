using Microsoft.EntityFrameworkCore.Migrations;

namespace vpmc_backend.Migrations
{
    public partial class addAd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Administrative_Area",
            //    columns: table => new
            //    {
            //        OID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CountyName = table.Column<string>(nullable: true),
            //        TownName = table.Column<string>(nullable: true),
            //        VillName = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Administrative_Area", x => x.OID);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Administrative_Area");
        }
    }
}

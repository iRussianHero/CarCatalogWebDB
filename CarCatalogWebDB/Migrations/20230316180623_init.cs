using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCatalogWebDB.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarTable",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    CarName = table.Column<string>(type: "text", nullable: false),
                    BrandName = table.Column<string>(type: "text", nullable: false),
                    EngineVolume = table.Column<int>(type: "integer", nullable: false),
                    ManufacturingYear = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTable", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarTable");
        }
    }
}

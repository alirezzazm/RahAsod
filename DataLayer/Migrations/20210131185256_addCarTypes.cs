using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class addCarTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleType = table.Column<string>(maxLength: 50, nullable: false),
                    CarName = table.Column<string>(maxLength: 100, nullable: false),
                    CylinderNmber = table.Column<int>(nullable: false),
                    PermittedCapacity = table.Column<int>(nullable: false),
                    Capacity = table.Column<string>(maxLength: 100, nullable: false),
                    Subgroup = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarTypes");
        }
    }
}

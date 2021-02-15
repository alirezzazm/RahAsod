using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class addModelsForAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinancialDamage",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "PersonalDamage",
                table: "ThirdPartyInsurance");

            migrationBuilder.AddColumn<string>(
                name: "DamageType",
                table: "ThirdPartyInsurance",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(maxLength: 50, nullable: false),
                    position = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficeInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adress = table.Column<string>(nullable: false),
                    phoneNumber = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    instagram = table.Column<string>(maxLength: 30, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SliderPics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    picPath = table.Column<string>(nullable: false),
                    show = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderPics", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "OfficeInfos");

            migrationBuilder.DropTable(
                name: "SliderPics");

            migrationBuilder.DropColumn(
                name: "DamageType",
                table: "ThirdPartyInsurance");

            migrationBuilder.AddColumn<bool>(
                name: "FinancialDamage",
                table: "ThirdPartyInsurance",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PersonalDamage",
                table: "ThirdPartyInsurance",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

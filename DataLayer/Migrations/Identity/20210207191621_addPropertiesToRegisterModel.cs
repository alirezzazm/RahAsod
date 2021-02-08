using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations.Identity
{
    public partial class addPropertiesToRegisterModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerBirthday",
                table: "AspNetUsers",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerEconomicCode",
                table: "AspNetUsers",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerType",
                table: "AspNetUsers",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerBirthday",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CustomerEconomicCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CustomerType",
                table: "AspNetUsers");
        }
    }
}

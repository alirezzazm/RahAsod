using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class AddDamagesToThirdparty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerInsurances",
                table: "CustomerInsurances");

            migrationBuilder.RenameTable(
                name: "CustomerInsurances",
                newName: "DescriptionCustomerInsurances");

            migrationBuilder.AddColumn<bool>(
                name: "FinancialDamage",
                table: "ThirdPartyInsurance",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PersonalDamage",
                table: "ThirdPartyInsurance",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PreviousInsurancePolicyEndDate",
                table: "ThirdPartyInsurance",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreviousInsurancePolicyStartDate",
                table: "ThirdPartyInsurance",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "ThirdPartyInsurance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DescriptionCustomerInsurances",
                table: "DescriptionCustomerInsurances",
                column: "DescriptionInsurancesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DescriptionCustomerInsurances",
                table: "DescriptionCustomerInsurances");

            migrationBuilder.DropColumn(
                name: "FinancialDamage",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "PersonalDamage",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "PreviousInsurancePolicyEndDate",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "PreviousInsurancePolicyStartDate",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "ThirdPartyInsurance");

            migrationBuilder.RenameTable(
                name: "DescriptionCustomerInsurances",
                newName: "CustomerInsurances");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerInsurances",
                table: "CustomerInsurances",
                column: "DescriptionInsurancesID");
        }
    }
}

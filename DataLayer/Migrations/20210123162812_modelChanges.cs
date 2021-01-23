using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class modelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerInsurance");

            migrationBuilder.DropTable(
                name: "CustomerLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InsurancesOfCustomer",
                table: "InsurancesOfCustomer");

            migrationBuilder.DropColumn(
                name: "FinancialCoverageOfCarThirdPartyInsurancesID",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "PercentageOfInsuranceDiscount",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "StyleCar",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "TypeOfCar",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "UsedCar",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "VinCar",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "InsurancesForCustomer",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "RepeatPassword",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "ConditionOfCarBodyInsurancesID",
                table: "BodyInsurance");

            migrationBuilder.DropColumn(
                name: "TowTruckCar",
                table: "BodyInsurance");

            migrationBuilder.RenameTable(
                name: "InsurancesOfCustomer",
                newName: "CustomerInsureances");

            migrationBuilder.AddColumn<string>(
                name: "CarBrigade",
                table: "ThirdPartyInsurance",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CarThirdPartyInsuranceFinancialCoverageID",
                table: "ThirdPartyInsurance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CarType",
                table: "ThirdPartyInsurance",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarUsage",
                table: "ThirdPartyInsurance",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarVin",
                table: "ThirdPartyInsurance",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PolicyDicountPercantage",
                table: "ThirdPartyInsurance",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "CustomerRegisteration",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "CustomerRegisteration",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerNationalCode",
                table: "CustomerRegisteration",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CarBodyInsurancesConditionID",
                table: "BodyInsurance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "HaveTowTruckCar",
                table: "BodyInsurance",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerInsureances",
                table: "CustomerInsureances",
                column: "InsurancesForCustomerID");

            migrationBuilder.CreateTable(
                name: "CarBodyCondition",
                columns: table => new
                {
                    CarBodyInsurancesConditionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionBodyNewName = table.Column<string>(nullable: false),
                    BodyConditionCoefficientPercentage = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBodyCondition", x => x.CarBodyInsurancesConditionID);
                });

            migrationBuilder.CreateTable(
                name: "CarFinancialCoverages",
                columns: table => new
                {
                    CarThirdPartyInsuranceFinancialCoverageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasePrice = table.Column<float>(nullable: false),
                    FinancialCoefficient = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarFinancialCoverages", x => x.CarThirdPartyInsuranceFinancialCoverageID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerInsurances",
                columns: table => new
                {
                    DescriptionInsurancesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameInsurances = table.Column<string>(nullable: true),
                    PreviousNumberInsurance = table.Column<string>(nullable: false),
                    NumberInsurances = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(nullable: false),
                    PreviousCompanyName = table.Column<string>(nullable: false),
                    StartInsurances = table.Column<string>(nullable: false),
                    EndInsurances = table.Column<string>(nullable: false),
                    DescriptionInsurances = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInsurances", x => x.DescriptionInsurancesID);
                });

            migrationBuilder.CreateTable(
                name: "FireCondition",
                columns: table => new
                {
                    CarFireInsuranceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionNewName = table.Column<string>(nullable: false),
                    FireConditionCoefficientPercentage = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireCondition", x => x.CarFireInsuranceID);
                });

            migrationBuilder.CreateTable(
                name: "FireInsurances",
                columns: table => new
                {
                    FireID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Province = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(nullable: false),
                    TypeOfBuildingStructure = table.Column<string>(nullable: false),
                    BuildingInfrastructure = table.Column<string>(nullable: false),
                    InsuredUnitsNumber = table.Column<string>(nullable: false),
                    InsuredCapital = table.Column<string>(nullable: false),
                    HomeFurnitureCapital = table.Column<float>(nullable: false),
                    CarFireInsuranceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireInsurances", x => x.FireID);
                });

            migrationBuilder.CreateTable(
                name: "LifeInsurances",
                columns: table => new
                {
                    LifeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerBirthday = table.Column<string>(nullable: false),
                    CustomerJob = table.Column<string>(nullable: false),
                    PaymentMethod = table.Column<string>(nullable: false),
                    CustomerTermOfInsurance = table.Column<int>(nullable: false),
                    MinimumDepositMoney = table.Column<float>(nullable: false),
                    HavePreviousLifeInsurance = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifeInsurances", x => x.LifeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarBodyCondition");

            migrationBuilder.DropTable(
                name: "CarFinancialCoverages");

            migrationBuilder.DropTable(
                name: "CustomerInsurances");

            migrationBuilder.DropTable(
                name: "FireCondition");

            migrationBuilder.DropTable(
                name: "FireInsurances");

            migrationBuilder.DropTable(
                name: "LifeInsurances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerInsureances",
                table: "CustomerInsureances");

            migrationBuilder.DropColumn(
                name: "CarBrigade",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "CarThirdPartyInsuranceFinancialCoverageID",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "CarType",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "CarUsage",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "CarVin",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "PolicyDicountPercantage",
                table: "ThirdPartyInsurance");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "CustomerNationalCode",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "CarBodyInsurancesConditionID",
                table: "BodyInsurance");

            migrationBuilder.DropColumn(
                name: "HaveTowTruckCar",
                table: "BodyInsurance");

            migrationBuilder.RenameTable(
                name: "CustomerInsureances",
                newName: "InsurancesOfCustomer");

            migrationBuilder.AddColumn<int>(
                name: "FinancialCoverageOfCarThirdPartyInsurancesID",
                table: "ThirdPartyInsurance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PercentageOfInsuranceDiscount",
                table: "ThirdPartyInsurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StyleCar",
                table: "ThirdPartyInsurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TypeOfCar",
                table: "ThirdPartyInsurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsedCar",
                table: "ThirdPartyInsurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VinCar",
                table: "ThirdPartyInsurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "CustomerRegisteration",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "InsurancesForCustomer",
                table: "CustomerRegisteration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                table: "CustomerRegisteration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RepeatPassword",
                table: "CustomerRegisteration",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConditionOfCarBodyInsurancesID",
                table: "BodyInsurance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "TowTruckCar",
                table: "BodyInsurance",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InsurancesOfCustomer",
                table: "InsurancesOfCustomer",
                column: "InsurancesForCustomerID");

            migrationBuilder.CreateTable(
                name: "CustomerInsurance",
                columns: table => new
                {
                    DescriptionInsurancesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionInsurances = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndInsurances = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameInsurances = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberInsurances = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviousCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviousNumberInsurance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartInsurances = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInsurance", x => x.DescriptionInsurancesID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerLogin",
                columns: table => new
                {
                    NationalCodeCustomer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasswordCustomer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLogin", x => x.NationalCodeCustomer);
                });
        }
    }
}

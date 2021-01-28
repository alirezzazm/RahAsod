using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class initializeDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyInsurance",
                columns: table => new
                {
                    BodyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarPrice = table.Column<float>(nullable: false),
                    CarTag = table.Column<string>(nullable: false),
                    CarModel = table.Column<int>(nullable: false),
                    CarType = table.Column<string>(maxLength: 50, nullable: false),
                    CarStyle = table.Column<string>(maxLength: 20, nullable: false),
                    CarChassisNumber = table.Column<string>(maxLength: 50, nullable: false),
                    CarEngineNumber = table.Column<string>(maxLength: 50, nullable: false),
                    CarColor = table.Column<string>(maxLength: 20, nullable: false),
                    CarVin = table.Column<string>(maxLength: 50, nullable: false),
                    PolicyDicountPercantage = table.Column<string>(maxLength: 50, nullable: false),
                    CarUsage = table.Column<string>(maxLength: 20, nullable: false),
                    CarCapacity = table.Column<string>(maxLength: 10, nullable: false),
                    HaveTowTruckCar = table.Column<bool>(nullable: false),
                    CarBodyInsurancesConditionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyInsurance", x => x.BodyID);
                });

            migrationBuilder.CreateTable(
                name: "CarBodyCondition",
                columns: table => new
                {
                    CarBodyInsurancesConditionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionBodyNewName = table.Column<string>(maxLength: 50, nullable: false),
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
                name: "CustomerInsureances",
                columns: table => new
                {
                    InsurancesForCustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameInsurances = table.Column<string>(nullable: true),
                    DescriptionInsurances = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInsureances", x => x.InsurancesForCustomerID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerRegisteration",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    CustomerNationalCode = table.Column<string>(nullable: false),
                    HomeNumber = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    ConfirmPassword = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRegisteration", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "FireCondition",
                columns: table => new
                {
                    CarFireInsuranceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionNewName = table.Column<string>(maxLength: 50, nullable: false),
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
                    Province = table.Column<string>(maxLength: 30, nullable: false),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    Address = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(maxLength: 50, nullable: false),
                    TypeOfBuildingStructure = table.Column<string>(maxLength: 20, nullable: false),
                    BuildingInfrastructure = table.Column<string>(maxLength: 50, nullable: false),
                    InsuredUnitsNumber = table.Column<string>(maxLength: 10, nullable: false),
                    InsuredCapital = table.Column<string>(maxLength: 50, nullable: false),
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
                    CustomerBirthday = table.Column<string>(maxLength: 20, nullable: false),
                    CustomerJob = table.Column<string>(maxLength: 50, nullable: false),
                    PaymentMethod = table.Column<string>(maxLength: 10, nullable: false),
                    CustomerTermOfInsurance = table.Column<int>(nullable: false),
                    MinimumDepositMoney = table.Column<float>(nullable: false),
                    HavePreviousLifeInsurance = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifeInsurances", x => x.LifeID);
                });

            migrationBuilder.CreateTable(
                name: "ThirdPartyInsurance",
                columns: table => new
                {
                    ThirdPartyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarTag = table.Column<string>(nullable: false),
                    CarModel = table.Column<int>(nullable: false),
                    CarType = table.Column<string>(maxLength: 50, nullable: false),
                    CarBrigade = table.Column<string>(maxLength: 50, nullable: false),
                    CarChassisNumber = table.Column<string>(maxLength: 50, nullable: false),
                    CarEngineNumber = table.Column<string>(maxLength: 50, nullable: false),
                    CarColor = table.Column<string>(maxLength: 20, nullable: false),
                    CarVin = table.Column<string>(maxLength: 50, nullable: false),
                    DriverDiscountPercentage = table.Column<string>(maxLength: 50, nullable: false),
                    PolicyDicountPercantage = table.Column<string>(maxLength: 50, nullable: false),
                    CarUsage = table.Column<string>(maxLength: 20, nullable: false),
                    CarCapacity = table.Column<string>(maxLength: 10, nullable: false),
                    TowTruckCar = table.Column<bool>(nullable: false),
                    CarThirdPartyInsuranceFinancialCoverageID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdPartyInsurance", x => x.ThirdPartyID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyInsurance");

            migrationBuilder.DropTable(
                name: "CarBodyCondition");

            migrationBuilder.DropTable(
                name: "CarFinancialCoverages");

            migrationBuilder.DropTable(
                name: "CustomerInsurances");

            migrationBuilder.DropTable(
                name: "CustomerInsureances");

            migrationBuilder.DropTable(
                name: "CustomerRegisteration");

            migrationBuilder.DropTable(
                name: "FireCondition");

            migrationBuilder.DropTable(
                name: "FireInsurances");

            migrationBuilder.DropTable(
                name: "LifeInsurances");

            migrationBuilder.DropTable(
                name: "ThirdPartyInsurance");
        }
    }
}

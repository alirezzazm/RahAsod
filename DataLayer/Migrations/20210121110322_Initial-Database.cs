using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class InitialDatabase : Migration
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
                    TypeOfCar = table.Column<string>(nullable: false),
                    StyleCar = table.Column<string>(nullable: false),
                    CarChassisNumber = table.Column<string>(nullable: false),
                    CarEngineNumber = table.Column<string>(nullable: false),
                    CarColor = table.Column<string>(nullable: false),
                    VinCar = table.Column<string>(nullable: false),
                    PercentageOfInsuranceDiscount = table.Column<string>(nullable: false),
                    UsedCar = table.Column<string>(nullable: false),
                    CarCapacity = table.Column<string>(nullable: false),
                    TowTruckCar = table.Column<bool>(nullable: false),
                    ConditionOfCarBodyInsurancesID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyInsurance", x => x.BodyID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerInsurance",
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
                    table.PrimaryKey("PK_CustomerInsurance", x => x.DescriptionInsurancesID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerLogin",
                columns: table => new
                {
                    NationalCodeCustomer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasswordCustomer = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLogin", x => x.NationalCodeCustomer);
                });

            migrationBuilder.CreateTable(
                name: "CustomerRegisteration",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    NationalCode = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    HomeNumber = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Adrress = table.Column<string>(nullable: false),
                    Password = table.Column<int>(nullable: false),
                    RepeatPassword = table.Column<int>(nullable: false),
                    InsurancesForCustomer = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRegisteration", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "InsurancesOfCustomer",
                columns: table => new
                {
                    InsurancesForCustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameInsurances = table.Column<string>(nullable: true),
                    DescriptionInsurances = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsurancesOfCustomer", x => x.InsurancesForCustomerID);
                });

            migrationBuilder.CreateTable(
                name: "ThirdPartyInsurance",
                columns: table => new
                {
                    ThirdPartyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarTag = table.Column<string>(nullable: false),
                    CarModel = table.Column<int>(nullable: false),
                    TypeOfCar = table.Column<string>(nullable: false),
                    StyleCar = table.Column<string>(nullable: false),
                    CarChassisNumber = table.Column<string>(nullable: false),
                    CarEngineNumber = table.Column<string>(nullable: false),
                    CarColor = table.Column<string>(nullable: false),
                    VinCar = table.Column<string>(nullable: false),
                    DriverDiscountPercentage = table.Column<string>(nullable: false),
                    PercentageOfInsuranceDiscount = table.Column<string>(nullable: false),
                    UsedCar = table.Column<string>(nullable: false),
                    CarCapacity = table.Column<string>(nullable: false),
                    TowTruckCar = table.Column<bool>(nullable: false),
                    FinancialCoverageOfCarThirdPartyInsurancesID = table.Column<int>(nullable: false)
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
                name: "CustomerInsurance");

            migrationBuilder.DropTable(
                name: "CustomerLogin");

            migrationBuilder.DropTable(
                name: "CustomerRegisteration");

            migrationBuilder.DropTable(
                name: "InsurancesOfCustomer");

            migrationBuilder.DropTable(
                name: "ThirdPartyInsurance");
        }
    }
}

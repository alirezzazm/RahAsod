﻿// <auto-generated />
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(InsuranceContext))]
    partial class InsuranceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Capacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("CylinderNmber")
                        .HasColumnType("int");

                    b.Property<int>("PermittedCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Subgroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("VehicleType")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("CarTypes");
                });

            modelBuilder.Entity("DataLayer.Models.CarFinancialCoverage", b =>
                {
                    b.Property<int>("CarThirdPartyInsuranceFinancialCoverageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("BasePrice")
                        .HasColumnType("real");

                    b.Property<float>("FinancialCoefficient")
                        .HasColumnType("real");

                    b.HasKey("CarThirdPartyInsuranceFinancialCoverageID");

                    b.ToTable("CarFinancialCoverages");
                });

            modelBuilder.Entity("DataLayer.Models.Conditions.ConditionOfCarBody", b =>
                {
                    b.Property<int>("CarBodyInsurancesConditionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("BodyConditionCoefficientPercentage")
                        .HasColumnType("real");

                    b.Property<string>("ConditionBodyNewName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CarBodyInsurancesConditionID");

                    b.ToTable("CarBodyCondition");
                });

            modelBuilder.Entity("DataLayer.Models.Conditions.ConditionOfFire", b =>
                {
                    b.Property<int>("CarFireInsuranceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConditionNewName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<float>("FireConditionCoefficientPercentage")
                        .HasColumnType("real");

                    b.HasKey("CarFireInsuranceID");

                    b.ToTable("FireCondition");
                });

            modelBuilder.Entity("DataLayer.Models.Descriptions.DescriptionOfBodyInsurance", b =>
                {
                    b.Property<int>("BodyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarBodyInsurancesConditionID")
                        .HasColumnType("int");

                    b.Property<string>("CarCapacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("CarChassisNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("CarColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("CarEngineNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("CarModel")
                        .HasColumnType("int");

                    b.Property<float>("CarPrice")
                        .HasColumnType("real");

                    b.Property<string>("CarStyle")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("CarTag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarType")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("CarUsage")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("CarVin")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("HaveTowTruckCar")
                        .HasColumnType("bit");

                    b.Property<string>("PolicyDicountPercantage")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("BodyID");

                    b.ToTable("BodyInsurance");
                });

            modelBuilder.Entity("DataLayer.Models.Descriptions.DescriptionOfCustomerInsurance", b =>
                {
                    b.Property<int>("DescriptionInsurancesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionInsurances")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndInsurances")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameInsurances")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberInsurances")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreviousCompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreviousNumberInsurance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartInsurances")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DescriptionInsurancesID");

                    b.ToTable("CustomerInsurances");
                });

            modelBuilder.Entity("DataLayer.Models.Descriptions.DescriptionOfFireInsurance", b =>
                {
                    b.Property<int>("FireID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingInfrastructure")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("CarFireInsuranceID")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<float>("HomeFurnitureCapital")
                        .HasColumnType("real");

                    b.Property<string>("InsuredCapital")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("InsuredUnitsNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("TypeOfBuildingStructure")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("FireID");

                    b.ToTable("FireInsurances");
                });

            modelBuilder.Entity("DataLayer.Models.Descriptions.DescriptionOfLifeInsurance", b =>
                {
                    b.Property<int>("LifeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerBirthday")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("CustomerJob")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("CustomerTermOfInsurance")
                        .HasColumnType("int");

                    b.Property<bool>("HavePreviousLifeInsurance")
                        .HasColumnType("bit");

                    b.Property<float>("MinimumDepositMoney")
                        .HasColumnType("real");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("LifeID");

                    b.ToTable("LifeInsurances");
                });

            modelBuilder.Entity("DataLayer.Models.Descriptions.DescriptionOfThirdPartyInsurance", b =>
                {
                    b.Property<int>("ThirdPartyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarBrigade")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("CarCapacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("CarChassisNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("CarColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("CarEngineNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("CarModel")
                        .HasColumnType("int");

                    b.Property<string>("CarTag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarThirdPartyInsuranceFinancialCoverageID")
                        .HasColumnType("int");

                    b.Property<string>("CarType")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("CarUsage")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("CarVin")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("DriverDiscountPercentage")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PolicyDicountPercantage")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("TowTruckCar")
                        .HasColumnType("bit");

                    b.HasKey("ThirdPartyID");

                    b.ToTable("ThirdPartyInsurance");
                });

            modelBuilder.Entity("DataLayer.Models.InsurancesOfCustomer", b =>
                {
                    b.Property<int>("InsurancesForCustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionInsurances")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameInsurances")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InsurancesForCustomerID");

                    b.ToTable("CustomerInsureances");
                });
#pragma warning restore 612, 618
        }
    }
}

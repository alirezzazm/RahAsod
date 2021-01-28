using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class addIdentityToRegister : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "CustomerRegisteration",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "CustomerRegisteration",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "CustomerRegisteration",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "CustomerRegisteration",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "CustomerRegisteration",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "CustomerRegisteration",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "CustomerRegisteration",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "CustomerRegisteration",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "CustomerRegisteration",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "CustomerRegisteration",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "CustomerRegisteration",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "CustomerRegisteration",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "CustomerRegisteration",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "CustomerRegisteration",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "CustomerRegisteration",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "CustomerRegisteration");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "CustomerRegisteration");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pay1193.Persistence.Migrations
{
    public partial class ComlumnFullNametoPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatePay",
                table: "PaymentRecords");

            migrationBuilder.RenameColumn(
                name: "NiC",
                table: "PaymentRecords",
                newName: "NIC");

            migrationBuilder.RenameColumn(
                name: "MonthPay",
                table: "PaymentRecords",
                newName: "PayDate");

            migrationBuilder.RenameColumn(
                name: "HourWorked",
                table: "PaymentRecords",
                newName: "HoursWorked");

            migrationBuilder.RenameColumn(
                name: "EarningDeduction",
                table: "PaymentRecords",
                newName: "TotalDeduction");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnionFee",
                table: "PaymentRecords",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "HourlyRate",
                table: "PaymentRecords",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "PaymentRecords",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NiNo",
                table: "PaymentRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PayMonth",
                table: "PaymentRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "PaymentRecords");

            migrationBuilder.DropColumn(
                name: "NiNo",
                table: "PaymentRecords");

            migrationBuilder.DropColumn(
                name: "PayMonth",
                table: "PaymentRecords");

            migrationBuilder.RenameColumn(
                name: "NIC",
                table: "PaymentRecords",
                newName: "NiC");

            migrationBuilder.RenameColumn(
                name: "TotalDeduction",
                table: "PaymentRecords",
                newName: "EarningDeduction");

            migrationBuilder.RenameColumn(
                name: "PayDate",
                table: "PaymentRecords",
                newName: "MonthPay");

            migrationBuilder.RenameColumn(
                name: "HoursWorked",
                table: "PaymentRecords",
                newName: "HourWorked");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnionFee",
                table: "PaymentRecords",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "HourlyRate",
                table: "PaymentRecords",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePay",
                table: "PaymentRecords",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}

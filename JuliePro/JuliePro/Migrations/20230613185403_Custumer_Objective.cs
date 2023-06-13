using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    public partial class Custumer_Objective : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Objectives",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "StartWeight", "TrainerId" },
                values: new object[] { 1, new DateTime(1998, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bianka.Smith@juliepro.ca", "Bianka", "Smith", 180.0, 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "StartWeight", "TrainerId" },
                values: new object[] { 2, new DateTime(1990, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joe.Espejo@juliepro.ca", "Joe", "Espejo", 160.0, 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "StartWeight", "TrainerId" },
                values: new object[] { 3, new DateTime(2002, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Betty.Thomas@juliepro.ca", "Betty", "Thomas", 190.0, 1 });

            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "Id", "AchievedDate", "CustomerId", "DistanceKm", "LostWeightKg", "Name" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10.0, 10.0, "Fat" });

            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "Id", "AchievedDate", "CustomerId", "DistanceKm", "LostWeightKg", "Name" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 8.0, 9.0, "Back Fat" });

            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "Id", "AchievedDate", "CustomerId", "DistanceKm", "LostWeightKg", "Name" },
                values: new object[] { 6, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2.0, 8.0, "Abs" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Objectives",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Objective_ObjectiveName",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_ObjectiveName",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ObjectiveName",
                table: "Customer");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Objective",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Customer",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Objective",
                columns: new[] { "Name", "AchievedDate", "CustomerId", "DistanceKm", "LostWeightKg" },
                values: new object[] { "Abs", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2.0, 8.0 });

            migrationBuilder.InsertData(
                table: "Objective",
                columns: new[] { "Name", "AchievedDate", "CustomerId", "DistanceKm", "LostWeightKg" },
                values: new object[] { "Back Fat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 8.0, 9.0 });

            migrationBuilder.InsertData(
                table: "Objective",
                columns: new[] { "Name", "AchievedDate", "CustomerId", "DistanceKm", "LostWeightKg" },
                values: new object[] { "Fat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10.0, 10.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Objective_CustomerId",
                table: "Objective",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Objective_Customer_CustomerId",
                table: "Objective",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Objective_Customer_CustomerId",
                table: "Objective");

            migrationBuilder.DropIndex(
                name: "IX_Objective_CustomerId",
                table: "Objective");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Name",
                keyValue: "Abs");

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Name",
                keyValue: "Back Fat");

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Name",
                keyValue: "Belly");

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Name",
                keyValue: "Fat");

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Name",
                keyValue: "Lower Body");

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Name",
                keyValue: "Muscle");

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Objective");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Customer",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ObjectiveName",
                table: "Customer",
                type: "nvarchar(15)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "FirstName");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ObjectiveName",
                table: "Customer",
                column: "ObjectiveName");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Objective_ObjectiveName",
                table: "Customer",
                column: "ObjectiveName",
                principalTable: "Objective",
                principalColumn: "Name");
        }
    }
}

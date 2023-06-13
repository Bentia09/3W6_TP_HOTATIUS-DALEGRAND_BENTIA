using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    public partial class Creation_Seed_Customer_Class_Customer_Class_Objective : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Trainers_SpecialityId",
                table: "Trainers");

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

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Trainers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.CreateTable(
                name: "Objective",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LostWeightKg = table.Column<double>(type: "float", nullable: false),
                    DistanceKm = table.Column<double>(type: "float", nullable: false),
                    AchievedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objective", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartWeight = table.Column<double>(type: "float", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    ObjectiveName = table.Column<string>(type: "nvarchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Objective_ObjectiveName",
                        column: x => x.ObjectiveName,
                        principalTable: "Objective",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_Customer_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "ObjectiveName", "StartWeight", "TrainerId" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bianka.Smith@juliepro.ca", "Bianka", "Smith", null, 180.0, 1 },
                    { 2, new DateTime(1990, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joe.Espejo@juliepro.ca", "Joe", "Espejo", null, 160.0, 1 },
                    { 3, new DateTime(2002, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Betty.Thomas@juliepro.ca", "Betty", "Thomas", null, 190.0, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Photo",
                value: "Francois.png");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Photo",
                value: "JeanClaude.png");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Photo",
                value: "Karine.png");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Photo",
                value: "Ramone.png");

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_SpecialityId",
                table: "Trainers",
                column: "SpecialityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ObjectiveName",
                table: "Customer",
                column: "ObjectiveName");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_TrainerId",
                table: "Customer",
                column: "TrainerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Objective");

            migrationBuilder.DropIndex(
                name: "IX_Trainers_SpecialityId",
                table: "Trainers");

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Trainers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Photo",
                value: "images/Trainers/Francois.png");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Photo",
                value: "images/Trainers/JeanClaude.png");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Photo",
                value: "images/Trainers/Karine.png");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Photo",
                value: "images/Trainers/Ramone.png");

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Photo", "SpecialityId" },
                values: new object[,]
                {
                    { 1, "Chrystal.lapierre@juliepro.ca", "Chrystal", "Lapierre", "images/Trainers/Chrystal.png", 1 },
                    { 2, "Felix.trudeau@juliePro.ca", "Félix", "Trudeau", "images/Trainers/Felix.png", 2 },
                    { 5, "JinLee.godette@juliepro.ca", "Jin Lee", "Godette", "images/Trainers/Jin Lee.png", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_SpecialityId",
                table: "Trainers",
                column: "SpecialityId");
        }
    }
}

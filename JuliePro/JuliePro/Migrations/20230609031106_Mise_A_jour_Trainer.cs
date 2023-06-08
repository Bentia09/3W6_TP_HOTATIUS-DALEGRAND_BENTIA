using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    public partial class Mise_A_jour_Trainer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Photo",
                value: "images/Trainers/Chrystal.png");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Photo",
                value: "images/Trainers/Felix.png");

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
                keyValue: 5,
                column: "Photo",
                value: "images/Trainers/Jin Lee.png");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Photo",
                value: "Chrystal.png");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Photo",
                value: "Felix.png");

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
                keyValue: 5,
                column: "Photo",
                value: "Jin Lee.png");

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
        }
    }
}

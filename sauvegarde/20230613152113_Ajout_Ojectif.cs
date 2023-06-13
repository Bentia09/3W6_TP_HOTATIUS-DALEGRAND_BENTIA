using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    public partial class Ajout_Ojectif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Name",
                keyValue: "Belly");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Name",
                keyValue: "Belly");

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
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    public partial class Ajout_Ex_Proxies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainer_Specialities_SpecialityId",
                table: "Trainer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainer",
                table: "Trainer");

            migrationBuilder.RenameTable(
                name: "Trainer",
                newName: "Trainers");

            migrationBuilder.RenameIndex(
                name: "IX_Trainer_SpecialityId",
                table: "Trainers",
                newName: "IX_Trainers_SpecialityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainers",
                table: "Trainers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Perte de poids" },
                    { 2, "Course" },
                    { 3, "Halthérophilie" },
                    { 4, "Réhabilitation" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Photo", "SpecialityId" },
                values: new object[,]
                {
                    { 1, "Chrystal.lapierre@juliepro.ca", "Chrystal", "Lapierre", "Chrystal.png", 1 },
                    { 2, "Felix.trudeau@juliePro.ca", "Félix", "Trudeau", "Felix.png", 2 },
                    { 3, "Frank.StJohn@juliepro.ca", "François", "Saint-John", "Francois.png", 1 },
                    { 4, "JC.Bastien@juliepro.ca", "Jean-Claude", "Bastien", "JeanClaude.png", 4 },
                    { 5, "JinLee.godette@juliepro.ca", "Jin Lee", "Godette", "Jin Lee.png", 3 },
                    { 6, "Karine.Lachance@juliepro.ca", "Karine", "Lachance", "Karine.png", 2 },
                    { 7, "Ramone.Esteban@juliepro.ca", "Ramone", "Esteban", "Ramone.png", 3 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_Specialities_SpecialityId",
                table: "Trainers",
                column: "SpecialityId",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_Specialities_SpecialityId",
                table: "Trainers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainers",
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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Trainers",
                newName: "Trainer");

            migrationBuilder.RenameIndex(
                name: "IX_Trainers_SpecialityId",
                table: "Trainer",
                newName: "IX_Trainer_SpecialityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainer",
                table: "Trainer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainer_Specialities_SpecialityId",
                table: "Trainer",
                column: "SpecialityId",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

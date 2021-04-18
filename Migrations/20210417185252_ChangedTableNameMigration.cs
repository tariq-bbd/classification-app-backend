using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassificationAppBackend.Migrations
{
    public partial class ChangedTableNameMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PatientDbSet",
                table: "PatientDbSet");

            migrationBuilder.RenameTable(
                name: "PatientDbSet",
                newName: "Patients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "PatientDbSet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PatientDbSet",
                table: "PatientDbSet",
                column: "Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassificationAppBackend.Migrations
{
    public partial class RenameStrokeTableMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DiseaseStroke",
                table: "DiseaseStroke");

            migrationBuilder.RenameTable(
                name: "DiseaseStroke",
                newName: "PredictionsStroke");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PredictionsStroke",
                table: "PredictionsStroke",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PredictionsStroke",
                table: "PredictionsStroke");

            migrationBuilder.RenameTable(
                name: "PredictionsStroke",
                newName: "DiseaseStroke");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiseaseStroke",
                table: "DiseaseStroke",
                column: "Id");
        }
    }
}

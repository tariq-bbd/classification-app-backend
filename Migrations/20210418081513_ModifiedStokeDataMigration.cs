using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassificationAppBackend.Migrations
{
    public partial class ModifiedStokeDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HadStroke",
                table: "DiseaseStroke");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HadStroke",
                table: "DiseaseStroke",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

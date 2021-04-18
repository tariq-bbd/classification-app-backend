using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassificationAppBackend.Migrations
{
    public partial class StokeDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiseaseStroke",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    HasHypertension = table.Column<int>(type: "int", nullable: false),
                    HasHeartDisease = table.Column<int>(type: "int", nullable: false),
                    EverMarried = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    WorkType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ResidenceType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AverageGlucoseLevel = table.Column<double>(type: "float", maxLength: 250, nullable: false),
                    BMI = table.Column<double>(type: "float", nullable: false),
                    SmokingStatus = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    HadStroke = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseStroke", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiseaseStroke");
        }
    }
}

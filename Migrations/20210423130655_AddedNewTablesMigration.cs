using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassificationAppBackend.Migrations
{
    public partial class AddedNewTablesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HadStroke",
                table: "PredictionsStroke",
                newName: "StrokePredictionResult");

            migrationBuilder.CreateTable(
                name: "HeartFailure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<float>(type: "real", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Chest_pain_type = table.Column<float>(type: "real", nullable: false),
                    Resting_bp_s = table.Column<float>(type: "real", nullable: false),
                    Cholesterol = table.Column<float>(type: "real", nullable: false),
                    Fasting_blood_sugar = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Resting_ecg = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Max_heart_rate = table.Column<float>(type: "real", nullable: false),
                    Exercise_angina = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Oldpeak = table.Column<float>(type: "real", nullable: false),
                    ST_slope = table.Column<float>(type: "real", nullable: false),
                    HeartFailurePredictionResult = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeartFailure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeartFailureData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<float>(type: "real", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Chest_pain_type = table.Column<float>(type: "real", nullable: false),
                    Resting_bp_s = table.Column<float>(type: "real", nullable: false),
                    Cholesterol = table.Column<float>(type: "real", nullable: false),
                    Fasting_blood_sugar = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Resting_ecg = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Max_heart_rate = table.Column<float>(type: "real", nullable: false),
                    Exercise_angina = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Oldpeak = table.Column<float>(type: "real", nullable: false),
                    ST_slope = table.Column<float>(type: "real", nullable: false),
                    Target = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeartFailureData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeartFailure");

            migrationBuilder.DropTable(
                name: "HeartFailureData");

            migrationBuilder.RenameColumn(
                name: "StrokePredictionResult",
                table: "PredictionsStroke",
                newName: "HadStroke");
        }
    }
}

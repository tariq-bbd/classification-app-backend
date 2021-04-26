using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassificationAppBackend.Migrations
{
    public partial class AddedTablesMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HeartFailure",
                table: "HeartFailure");

            migrationBuilder.DropColumn(
                name: "Chest_pain_type",
                table: "HeartFailureData");

            migrationBuilder.DropColumn(
                name: "Exercise_angina",
                table: "HeartFailureData");

            migrationBuilder.DropColumn(
                name: "Fasting_blood_sugar",
                table: "HeartFailureData");

            migrationBuilder.DropColumn(
                name: "Max_heart_rate",
                table: "HeartFailureData");

            migrationBuilder.DropColumn(
                name: "Resting_bp_s",
                table: "HeartFailureData");

            migrationBuilder.DropColumn(
                name: "Resting_ecg",
                table: "HeartFailureData");

            migrationBuilder.DropColumn(
                name: "ST_slope",
                table: "HeartFailureData");

            migrationBuilder.RenameTable(
                name: "HeartFailure",
                newName: "PredictHeartFailure");

            migrationBuilder.RenameColumn(
                name: "Oldpeak",
                table: "HeartFailureData",
                newName: "OldPeak");

            migrationBuilder.AlterColumn<bool>(
                name: "Target",
                table: "HeartFailureData",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Cholesterol",
                table: "HeartFailureData",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "HeartFailureData",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "ChestPainType",
                table: "HeartFailureData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ExerciseAngina",
                table: "HeartFailureData",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FastingBloodSugar",
                table: "HeartFailureData",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MaxHeartRate",
                table: "HeartFailureData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RestingBpS",
                table: "HeartFailureData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "RestingEcg",
                table: "HeartFailureData",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "StSlope",
                table: "HeartFailureData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PredictHeartFailure",
                table: "PredictHeartFailure",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "StrokeData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    HasHypertension = table.Column<bool>(type: "bit", nullable: false),
                    HasHeartDisease = table.Column<bool>(type: "bit", nullable: false),
                    EverMarried = table.Column<bool>(type: "bit", nullable: false),
                    WorkType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ResidenceType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AverageGlucoseLevel = table.Column<double>(type: "float", nullable: false),
                    BMI = table.Column<double>(type: "float", nullable: false),
                    SmokingStatus = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Target = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrokeData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StrokeData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PredictHeartFailure",
                table: "PredictHeartFailure");

            migrationBuilder.DropColumn(
                name: "ChestPainType",
                table: "HeartFailureData");

            migrationBuilder.DropColumn(
                name: "ExerciseAngina",
                table: "HeartFailureData");

            migrationBuilder.DropColumn(
                name: "FastingBloodSugar",
                table: "HeartFailureData");

            migrationBuilder.DropColumn(
                name: "MaxHeartRate",
                table: "HeartFailureData");

            migrationBuilder.DropColumn(
                name: "RestingBpS",
                table: "HeartFailureData");

            migrationBuilder.DropColumn(
                name: "RestingEcg",
                table: "HeartFailureData");

            migrationBuilder.DropColumn(
                name: "StSlope",
                table: "HeartFailureData");

            migrationBuilder.RenameTable(
                name: "PredictHeartFailure",
                newName: "HeartFailure");

            migrationBuilder.RenameColumn(
                name: "OldPeak",
                table: "HeartFailureData",
                newName: "Oldpeak");

            migrationBuilder.AlterColumn<int>(
                name: "Target",
                table: "HeartFailureData",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<float>(
                name: "Cholesterol",
                table: "HeartFailureData",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Age",
                table: "HeartFailureData",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<float>(
                name: "Chest_pain_type",
                table: "HeartFailureData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Exercise_angina",
                table: "HeartFailureData",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Fasting_blood_sugar",
                table: "HeartFailureData",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "Max_heart_rate",
                table: "HeartFailureData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Resting_bp_s",
                table: "HeartFailureData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Resting_ecg",
                table: "HeartFailureData",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "ST_slope",
                table: "HeartFailureData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeartFailure",
                table: "HeartFailure",
                column: "Id");
        }
    }
}

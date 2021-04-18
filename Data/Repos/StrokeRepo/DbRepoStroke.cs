
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.Stroke;
using SampleClassification.Model;

namespace ClassificationAppBackend.Data.Repos.StrokeRepo
{
    public class DbRepoStroke : IRepoStroke
    {
        public DbRepoStroke()
        {

        }
        public PredictionModel Predict(StrokePredictionModel strokePredictionModel)
        {
            ModelInput sampleData = new ModelInput()
            {
                Gender = @"Male",
                Age = 67F,
                HasHypertension = 0F,
                HasHeartDisease = 1F,
                EverMarried = true,
                WorkType = @"Private",
                ResidenceType = @"Urban",
                AverageGlucoseLevel = 228.69F,
                BMI = 36.6F,
                SmokingStatus = @"formerly smoked",
            };

            var prediction = ConsumeModel.Predict(sampleData);
            return new PredictionModel{PredictionResult = prediction.Score[^1]};
        }
    }
}
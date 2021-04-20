
using AutoMapper;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.Stroke;
using ClassificationModel;

namespace ClassificationAppBackend.Data.Repos.StrokeRepo
{
    public class DbRepoStroke : IRepoStroke
    {
        private readonly IMapper _mapper;

        public DbRepoStroke(IMapper mapper)
        {
            _mapper = mapper;
        }
        public PredictionModel Predict(StrokePredictionModel strokePredictionModel)
        {
            ClassificationModelInput modelInput = new ClassificationModelInput
            {
                Age = strokePredictionModel.Age,
                AverageGlucoseLevel = (float)strokePredictionModel.AverageGlucoseLevel,
                BMI = (float)strokePredictionModel.BMI,
                EverMarried = strokePredictionModel.EverMarried == "Yes" ? true : false,
                Gender = strokePredictionModel.Gender,
                HasHeartDisease = strokePredictionModel.HasHeartDisease,
                HasHypertension = strokePredictionModel.HasHeartDisease,
                ResidenceType = strokePredictionModel.ResidenceType,
                SmokingStatus = strokePredictionModel.SmokingStatus,
                WorkType = strokePredictionModel.WorkType

            };

            var prediction = ConsumeModel.Predict(modelInput);
            return new PredictionModel{PredictionResult = prediction.Score[^1]};
        }
    }
}
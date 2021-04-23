
using AutoMapper;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.HeartFailure;
using ClassificationModel.HeartFailure;

namespace ClassificationAppBackend.Data.Repos.HeartFailureRepo
{
    public class DbRepoHeartFailure : IRepoHeartFailure
    {
        private readonly IMapper _mapper;

        public DbRepoHeartFailure(IMapper mapper)
        {
            _mapper = mapper;
        }
        public PredictionModel Predict(HeartFailurePredictionModel heartFailurePredictionModel)
        {
            ClassificationModelInput modelInput = new ClassificationModelInput
            {
                Age = heartFailurePredictionModel.Age,
                Sex = heartFailurePredictionModel.Sex,
                Chest_pain_type = heartFailurePredictionModel.Chest_pain_type,
                Resting_bp_s = heartFailurePredictionModel.Resting_bp_s,
                Cholesterol = heartFailurePredictionModel.Cholesterol,
                Fasting_blood_sugar = heartFailurePredictionModel.Fasting_blood_sugar,
                Resting_ecg = heartFailurePredictionModel.Resting_ecg,
                Max_heart_rate = heartFailurePredictionModel.Max_heart_rate,
                Exercise_angina = heartFailurePredictionModel.Exercise_angina,
                Oldpeak = heartFailurePredictionModel.Oldpeak,
                ST_slope = heartFailurePredictionModel.ST_slope,
            };

            var prediction = ConsumeModel.Predict(modelInput);
            return new PredictionModel{PredictionResult = prediction.Score[^1]};
        }
    }
}
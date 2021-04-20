
using AutoMapper;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.HeartFailure;
using ClassificationModel;

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
                Anaemia = heartFailurePredictionModel.Anaemia,
                CreatininePhosphokinase = heartFailurePredictionModel.CreatininePhosphokinase,
                Diabetes = heartFailurePredictionModel.Diabetes,
                EjectionFraction = heartFailurePredictionModel.EjectionFraction,
                HighBloodPressure = heartFailurePredictionModel.HighBloodPressure,
                Platelets = heartFailurePredictionModel.Platelets,
                SerumCreatinine = heartFailurePredictionModel.SerumCreatinine,
                SerumSodium = heartFailurePredictionModel.SerumSodium,
                Sex = heartFailurePredictionModel.Sex,
                Smoking = heartFailurePredictionModel.Smoking,
                Time = heartFailurePredictionModel.Time,
            };

            var prediction = ConsumeModel.Predict(modelInput);
            return new PredictionModel{PredictionResult = prediction.Score[^1]};
        }
    }
}
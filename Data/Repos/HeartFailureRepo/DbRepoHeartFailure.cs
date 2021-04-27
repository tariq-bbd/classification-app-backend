
using AutoMapper;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.HeartFailure;
using ClassificationModel.HeartFailure;
using System.Collections.Generic;
using System.Linq;

namespace ClassificationAppBackend.Data.Repos.HeartFailureRepo
{
    public class DbRepoHeartFailure : IRepoHeartFailure
    {
        private readonly IMapper _mapper;
        private readonly ClassifcatiionAppDbContext _context;

        public DbRepoHeartFailure(IMapper mapper, ClassifcatiionAppDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public IEnumerable<HeartFailurePredictionModel> GetXRecords(int x)
        {
            return _context.PredictHeartFailure.OrderByDescending(o => o.Id).Take(x).ToList();
            
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
            heartFailurePredictionModel.HeartFailurePredictionResult = (int)(prediction.Score[^1] * 100);
            _context.PredictHeartFailure.Add(heartFailurePredictionModel);
            _context.SaveChanges();
            return new PredictionModel{PredictionResult = (int)(prediction.Score[^1] * 100)};
        }
    }
}
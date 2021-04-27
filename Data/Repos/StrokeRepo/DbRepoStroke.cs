
using AutoMapper;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.Stroke;
using ClassificationModel.Stroke;
using System.Collections.Generic;
using System.Linq;

namespace ClassificationAppBackend.Data.Repos.StrokeRepo
{
    public class DbRepoStroke : IRepoStroke
    {
        private readonly IMapper _mapper;
        private readonly ClassifcatiionAppDbContext _context;

        public DbRepoStroke(IMapper mapper, ClassifcatiionAppDbContext context)
        {
            _mapper = mapper;
            _context = context;
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
            strokePredictionModel.StrokePredictionResult = (int)(prediction.Score[^1] * 100);
            _context.PredictionsStroke.Add(strokePredictionModel);
            _context.SaveChanges();
            return new PredictionModel{PredictionResult = prediction.Score[^1]};
        }

        public IEnumerable<StrokePredictionModel> GetXRecords(int x)
        {
            return _context.PredictionsStroke.OrderByDescending(o => o.Id).Take(x).ToList();
            
        }
    }
}
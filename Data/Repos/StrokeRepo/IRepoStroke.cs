using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.Stroke;
using System.Collections.Generic;
using System.Linq;

namespace ClassificationAppBackend.Data.Repos.StrokeRepo
{
    public interface IRepoStroke
    {
        PredictionModel Predict(StrokePredictionModel strokePredictionModel);
        IEnumerable<StrokePredictionModel> GetXRecords(int x);
    }
}
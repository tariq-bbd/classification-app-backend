using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.Stroke;

namespace ClassificationAppBackend.Data.Repos.StrokeRepo
{
    public interface IRepoStroke
    {
        PredictionModel Predict(StrokePredictionModel strokePredictionModel);
    }
}
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.HeartFailure;

namespace ClassificationAppBackend.Data.Repos.HeartFailureRepo
{
    public interface IRepoHeartFailure
    {
        PredictionModel Predict(HeartFailurePredictionModel heartFailurePredictionModel);
    }
}
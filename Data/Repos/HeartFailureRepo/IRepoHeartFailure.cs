using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.HeartFailure;
using System.Collections.Generic;

namespace ClassificationAppBackend.Data.Repos.HeartFailureRepo
{
    public interface IRepoHeartFailure
    {
        PredictionModel Predict(HeartFailurePredictionModel heartFailurePredictionModel);
        IEnumerable<HeartFailurePredictionModel> GetXRecords(int x);
    }
}
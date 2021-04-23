using ClassificationAppBackend.Models.Diseases.HeartFailure;
using System.Collections.Generic;

namespace ClassificationAppBackend.Data.Repos.HeartFailureDataRepo
{
    public interface IRepoHeartFailureData
    {
        //Saves the prediction to the Data Source
        IEnumerable<HeartFailureDataModel> GetAll();
        bool AddHeartFailureData(HeartFailureDataModel patient);
        HeartFailureDataModel GetHeartFailureData(int id);

    }
}
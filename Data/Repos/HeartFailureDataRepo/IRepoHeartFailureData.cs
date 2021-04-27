using ClassificationAppBackend.Models.Diseases.HeartFailure;
using System.Collections.Generic;
using System.Linq;

namespace ClassificationAppBackend.Data.Repos.HeartFailureDataRepo
{
    public interface IRepoHeartFailureData
    {
        //Saves the prediction to the Data Source
        IEnumerable<HeartFailureDataModel> GetAll();
        bool AddHeartFailureData(HeartFailureDataModel patient);
        HeartFailureDataModel GetHeartFailureData(int id);
        IEnumerable<HeartFailureDataModel> GetXRecords(int x);
        IEnumerable<HeartFailureDataModel> GetXRecordsByGender(int x, string sex);
        IEnumerable<HeartFailureDataModel> GetRecordsByGender(string sex);

    }
}
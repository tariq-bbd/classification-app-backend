using ClassificationAppBackend.Models.Diseases.HeartFailure;

namespace ClassificationAppBackend.Data.Repos.HeartFailureDataRepo
{
    public interface IRepoHeartFailureData
    {
        //Saves the prediction to the Data Source
         HeartFailureDataModel[] GetAll();
         bool AddHeartFailureData(HeartFailureDataModel patient);

    }
}
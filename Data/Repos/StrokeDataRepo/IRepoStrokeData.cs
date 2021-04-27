using ClassificationAppBackend.Models.Diseases.Stroke;
using System.Collections.Generic;

namespace ClassificationAppBackend.Data.Repos.StrokeDataRepo
{
    public interface IRepoStrokeData
    {
        //Saves the prediction to the Data Source
        IEnumerable<StrokeDataModel> GetAll();
        bool AddStokeData(StrokeDataModel stokeData);
        StrokeDataModel GetStrokeData(int id);
        IEnumerable<StrokeDataModel> GetXRecords(int x);
        IEnumerable<StrokeDataModel> GetXRecordsByGender(int x, string sex);
        IEnumerable<StrokeDataModel> GetRecordsByGender(string sex);

    }
}
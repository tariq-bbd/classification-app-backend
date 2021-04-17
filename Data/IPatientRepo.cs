using ClassificationAppBackend.Models;

namespace ClassificationAppBackend.Data
{
    public interface IPatientRepo
    {
        //Saves the prediction to the Data Source
         bool SavePrediction();
         PatientModel GetPatient(int id);
    }
}
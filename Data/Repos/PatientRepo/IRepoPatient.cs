using ClassificationAppBackend.Models;

namespace ClassificationAppBackend.Data.Repos.PatientRepo
{
    public interface IRepoPatient
    {
        //Saves the prediction to the Data Source
         PatientModel GetPatient(int id);
         bool AddPatient(PatientModel patient);

    }
}
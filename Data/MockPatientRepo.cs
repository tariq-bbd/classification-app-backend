using System.Collections.Generic;
using System.Linq;
using ClassificationAppBackend.Models;

namespace ClassificationAppBackend.Data
{
    public class MockPatientRepo : IPatientRepo
    {

        
        public PatientModel GetPatient(int id)
        {
           List<PatientModel> patients = new List<PatientModel>();
           patients.Add(new PatientModel
           {
               Id = 0,
               FirstName = "Tariq",
               LastName = "Kirsten",
               Age = 22,
               Gender = "Male",
               MiddleName = null
           
           });

           return patients.FirstOrDefault(patient => patient.Id == id);
        }

        public bool SavePrediction()
        {
            throw new System.NotImplementedException();
        }
    }
}
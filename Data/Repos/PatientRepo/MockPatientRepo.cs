using System.Collections.Generic;
using System.Linq;
using ClassificationAppBackend.Models;

namespace ClassificationAppBackend.Data.Repos.PatientRepo
{
    public class MockPatientRepo : IRepoPatient
    {
        private List<PatientModel> _patients = new List<PatientModel>();

        public MockPatientRepo()
        {
            _patients.Add(new PatientModel
            {
                Id = 0,
                FirstName = "Tariq",
                LastName = "Kirsten",
                Age = 22,
                Gender = "Male",
                MiddleName = null

            });

        }
        public bool AddPatient(PatientModel patient)
        {
            _patients.Add(patient);
            return true;
        }

        public PatientModel GetPatient(int id)
        {

            return _patients.FirstOrDefault(patient => patient.Id == id);
        }


    }
}
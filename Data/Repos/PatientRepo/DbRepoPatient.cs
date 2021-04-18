using System.Linq;
using ClassificationAppBackend.Models;

namespace ClassificationAppBackend.Data.Repos.PatientRepo
{
    public class DbRepoPatient : IRepoPatient
    {
        private readonly ClassifcatiionAppDbContext _context;

        public DbRepoPatient(ClassifcatiionAppDbContext context)
        {
            _context = context;
        }
        public bool AddPatient(PatientModel patient)
        {
            _context.Patients.Add(patient);
            
            return _context.SaveChanges() >=0;
        }

        public PatientModel GetPatient(int id)
        {
            return _context.Patients.FirstOrDefault(patient => patient.Id == id);
            
        }
    }
}
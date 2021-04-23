using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.Stroke;
using ClassificationAppBackend.Models.Diseases.HeartFailure;
using Microsoft.EntityFrameworkCore;

namespace ClassificationAppBackend.Data
{
    public class ClassifcatiionAppDbContext : DbContext
    {

        public ClassifcatiionAppDbContext(DbContextOptions<ClassifcatiionAppDbContext> options) : base(options)
        {
            
        }

        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<StrokePredictionModel> PredictionsStroke { get; set; }
        public DbSet<HeartFailurePredictionModel> HeartFailure { get;  set;}
        public DbSet<HeartFailureDataModel> HeartFailureData { get;  set;}
    }
}

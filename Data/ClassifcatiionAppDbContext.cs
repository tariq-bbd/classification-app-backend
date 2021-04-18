using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.Stroke;
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
    }
}

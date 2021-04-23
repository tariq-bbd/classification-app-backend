using ClassificationAppBackend.Models.Diseases.HeartFailure;
using AutoMapper;
using ClassificationModel.HeartFailure;
using System.Collections.Generic;
using System.Linq;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Data;

namespace ClassificationAppBackend.Data.Repos.HeartFailureDataRepo
{
    public class DbHeartFailureData: IRepoHeartFailureData {
        private readonly ClassifcatiionAppDbContext _context;

        public DbHeartFailureData(ClassifcatiionAppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<HeartFailureDataModel>  GetAll() {
            return _context.HeartFailureData.ToList();
        }

        public bool AddHeartFailureData(HeartFailureDataModel heartFailureData) {
            _context.HeartFailureData.Add(heartFailureData);

            return _context.SaveChanges() >= 0;
        }

        public HeartFailureDataModel GetHeartFailureData(int id)
        {
            return _context.HeartFailureData.FirstOrDefault(patient => patient.Id == id);
            
        }

    }
}
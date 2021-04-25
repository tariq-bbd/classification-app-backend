using ClassificationAppBackend.Models.Diseases.HeartFailure;
using AutoMapper;
using ClassificationModel.HeartFailure;
using System.Collections.Generic;
using System.Linq;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Data;

namespace ClassificationAppBackend.Data.Repos.HeartFailureDataRepo
{
    public class DbRepoHeartFailureData: IRepoHeartFailureData {
        private readonly ClassifcatiionAppDbContext _context;

        public DbRepoHeartFailureData(ClassifcatiionAppDbContext context)
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
            return _context.HeartFailureData.FirstOrDefault(heartFailureRec => heartFailureRec.Id == id);
            
        }

    }
}
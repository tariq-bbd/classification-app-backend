using ClassificationAppBackend.Models.Diseases.Stroke;
using AutoMapper;
using ClassificationModel.Stroke;
using System.Collections.Generic;
using System.Linq;

namespace ClassificationAppBackend.Data.Repos.StrokeDataRepo
{
    public class DbRepoStrokeData: IRepoStrokeData {
        private readonly ClassifcatiionAppDbContext _context;

        public DbRepoStrokeData(ClassifcatiionAppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<StrokeDataModel>  GetAll() {
            return _context.StrokeData.ToList();
        }

        public IEnumerable<StrokeDataModel> GetXRecords(int x)
        {
            return _context.StrokeData.OrderByDescending(o => o.Id).Take(x).ToList();
            
        }

        public bool AddStokeData(StrokeDataModel stokeData) {
            _context.StrokeData.Add(stokeData);

            return _context.SaveChanges() >= 0;
        }

        public StrokeDataModel GetStrokeData(int id)
        {
            return _context.StrokeData.Find(id);
            
        }

        public IEnumerable<StrokeDataModel> GetXRecordsByGender(int x, string sex)
        {
            return _context.StrokeData.Where(o => o.Gender == sex).OrderByDescending(o => o.Id).Take(x).ToList();
        }

        public IEnumerable<StrokeDataModel> GetRecordsByGender(string sex)
        {
            return _context.StrokeData.Where(o => o.Gender == sex).ToList();
        }
    }
}
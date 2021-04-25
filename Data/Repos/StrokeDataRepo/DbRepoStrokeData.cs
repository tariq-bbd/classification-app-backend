using ClassificationAppBackend.Models.Diseases.Stroke;
using AutoMapper;
using ClassificationModel.Stroke;
using System.Collections.Generic;
using System.Linq;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Data;

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

        public bool AddStokeData(StrokeDataModel stokeData) {
            _context.StrokeData.Add(stokeData);

            return _context.SaveChanges() >= 0;
        }

        public StrokeDataModel GetStrokeData(int id)
        {
            return _context.StrokeData.FirstOrDefault(strokeRec => strokeRec.Id == id);
            
        }

    }
}
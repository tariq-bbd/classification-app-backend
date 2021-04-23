using ClassificationAppBackend.Models.Diseases.HeartFailure;

namespace ClassificationAppBackend.Data.Repos.HeartFailureDataRepo {
    public class DbHeartFailureData: IRepoHeartFailureData {
        private readonly ClassificationAppDbContext _context;

        public DbHeartFailureData(ClassificationAppDbContext context)
        {
            _context = context;
        }

        public IEnumerator<HeartFailureDataModel> GetAll() {
            return _context.HeartFailureData.GetAll();
        }

        public bool AddHeartFailureData(HeartFailureDataModel heartFailureData) {
            _context.HeartFailureData.Add(heartFailureData);

            return _context.SaveChanges() >= 0;
        }

    }
}
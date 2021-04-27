using System.Linq;
using ClassificationAppBackend.Models;

namespace ClassificationAppBackend.Data.Repos.UserRepo
{
    public class DbRepoUser : IRepoUser
    {
        private readonly ClassifcatiionAppDbContext _context;

        public DbRepoUser(ClassifcatiionAppDbContext context)
        {
            _context = context;
        }
        public bool AddUser(UserModel user)
        {
            _context.User.Add(user);
            
            return _context.SaveChanges() >=0;
        }

        public UserModel GetUser(int id)
        {
            return _context.User.FirstOrDefault(user => user.Id == id);
            
        }
    }
}
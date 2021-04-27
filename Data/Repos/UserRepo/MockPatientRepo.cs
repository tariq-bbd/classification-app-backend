using System.Collections.Generic;
using System.Linq;
using ClassificationAppBackend.Models;

namespace ClassificationAppBackend.Data.Repos.UserRepo
{
    public class MockUserRepo : IRepoUser
    {
        private List<UserModel> _users = new List<UserModel>();

        public MockUserRepo()
        {
            _users.Add(new UserModel
            {
                Id = 0,
                FirstName = "Tariq",
                LastName = "Kirsten",
                Age = 22,
                Gender = "Male",
                MiddleName = null

            });

        }
        public bool AddUser(UserModel user)
        {
            _users.Add(user);
            return true;
        }

        public UserModel GetUser(int id)
        {

            return _users.FirstOrDefault(user => user.Id == id);
        }


    }
}
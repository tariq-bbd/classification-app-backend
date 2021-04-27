using ClassificationAppBackend.Models;

namespace ClassificationAppBackend.Data.Repos.UserRepo
{
    public interface IRepoUser
    {
        //Saves the prediction to the Data Source
         UserModel GetUser(int id);
         bool AddUser(UserModel user);

    }
}
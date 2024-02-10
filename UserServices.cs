using WS.DataServices.Model;
using WS.Unit06.Example2.Data;

namespace WS.DataServices
{
    public class UserServices : IUserServices
    {
        public void CreateUser(Users user)
        {
            throw new NotImplementedException();
        }

        public long GetUser(string email, string? username)
        {
            throw new NotImplementedException();
        }

        public Users[] GetUsers()
        {
            using (DAOFactory factory = new DAOFactory())
            {
                return factory.usersDAO.All().ToArray();
            }

        }

        public void UpdateUser(Users user)
        {
            throw new NotImplementedException();
        }
    }
}

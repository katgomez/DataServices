using WS.DataServices.Model;
using WS.Unit06.Example2.Data.DAO;

namespace WS.DataServices.DAO.Impl
{
    public class UserDao : GenericDAO<User>, IUserDAO
    {
        public UserDao(DataContext context) : base(context)
        {
        }
    }
}

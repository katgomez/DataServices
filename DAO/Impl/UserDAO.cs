using WS.DataServices.Model;
using WS.Unit06.Example2.Data.DAO;

namespace WS.DataServices.DAO.Impl
{
    public class UserDAO : GenericDAO<User>, IUserDAO
    {
        public UserDAO(DataContext context) : base(context)
        {
        }
    }
}

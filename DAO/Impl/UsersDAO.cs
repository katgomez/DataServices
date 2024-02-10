using WS.DataServices.Model;
using WS.Unit06.Example2.Data.DAO;

namespace WS.DataServices.DAO.Impl
{
    public class UsersDAO : GenericDAO<Users>, IUsersDAO
    {
        public UsersDAO(DataContext context) : base(context)
        {
        }
    }
}

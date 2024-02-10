using System.ServiceModel;
using WS.DataServices.Model;

namespace WS.DataServices
{
    [ServiceContract(Namespace = "http://ws.agencytravel/user/")]

    public interface IUserServices
    {
        [OperationContract]
        public Users[] GetUsers();
        [OperationContract]
        public Users GetUser(String email, String? username);
        [OperationContract]
        public void CreateUser(Users user);
        [OperationContract]
        public void UpdateUser(Users user);

    }
}

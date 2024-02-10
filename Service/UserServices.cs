﻿using System.ServiceModel;
using System.Xml.Linq;
using WS.DataServices.Model;
using WS.Unit06.Example2.Data;

namespace WS.DataServices.Service
{
    public class UserServices : IUserServices
    {
        public void CreateUser(User user)
        {
            using (DAOFactory factory = new DAOFactory())
            {
                User checkedUser = factory.usersDAO.All().FirstOrDefault(p => p.Email == user.Email);
                if (checkedUser != null)
                    throw new FaultException(new FaultReason(
                    "User already exists!!!"), new FaultCode("400"), "");
                factory.usersDAO.Add(user);
            }

        }

        public User GetUser(string? email, string? username)
        {
            using (DAOFactory factory = new DAOFactory())
            {
                User[] users = factory.usersDAO.All().ToArray();
                return users.First(p => p.Email == email || p.UserName == username);
            }
        }

        public User[] GetUsers()
        {
            using (DAOFactory factory = new DAOFactory())
            {
                return factory.usersDAO.All().ToArray();
            }

        }

        public void UpdateUser(User user)
        {
            using (DAOFactory factory = new DAOFactory())
            {
                User checkedUser = factory.usersDAO.All().FirstOrDefault(p => p.Email == user.Email);
                if (checkedUser == null)
                    throw new FaultException(new FaultReason(
                    "Product not found!!!"), new FaultCode("404"), "");
                factory.usersDAO.Update(user);
            }
        }
    }
}
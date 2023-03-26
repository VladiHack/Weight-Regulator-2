using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using WeightRegulator.Data.Model;

namespace Business
{
    public class UserBusiness
    {
        private UserRepository managerUsers = new UserRepository();
        public List<User> GetAll()
        {
            return managerUsers.GetAll();
        }
        public void Add(User user)
        {
            managerUsers.AddUser(user);
        }
        public string UniqueUsername(string username)
        {
            return managerUsers.UniqueUsername(username);
        }
        public string UniqueEmail(string email)
        {
            return managerUsers.UniqueEmail(email);
        }
        public bool LoginCheck(string emailOrUsername,string password)
        {
            return managerUsers.LoginCheck(emailOrUsername, password);
        }
        public int FindIndexByUsername(string username)
        {
            return managerUsers.FindIndexByUsername(username);
        }
        public void DeleteAllUsers()
        {
            managerUsers.DeleteAllUsers();
        }
        public User FindUserByUsername(string username)
        {
            return managerUsers.FindUserByUsername(username);
        }
        public void DeleteUser(string username,string password)
        {
            managerUsers.DeleteUser(username,password);
        }
    }
}

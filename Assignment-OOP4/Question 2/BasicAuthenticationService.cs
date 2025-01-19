using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP4.Question_2
{
    struct UserData
    {
        public string password { get; set; }
        public string role { get; set; }
    }
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private readonly Dictionary<string, UserData> users;

        public BasicAuthenticationService()
        {
            users = new Dictionary<string, UserData>(10);
        }

        public void AddUser(string username, string password, string role)
        {
            users.Add(username, new UserData { password = password, role = role });

        }

        public bool AuthenticateUser(string username, string password)
        {

            if (users.ContainsKey(username))
            {
                return users[username].password == password;
            }

            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (users.ContainsKey(username))
            {
                return users[username].role == role;
            }

            return false;
        }

    }
}

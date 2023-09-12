using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class UserAuthenticator
    {
      private List<User> users = new List<User>();
        public void UserRegistration(string username, string password)
        {
            users.Add(new User { UserName = username, Password = password });
        }

        public bool UserLogin(string username, string password)
        {
            return users.Exists(u => u.UserName == username && u.Password == password);
        }

        public void PasswordReset(string username, string newpassword)
        {
            var user = users.Find(u => u.UserName == username);
            if(user != null)
            {
                user.Password =  newpassword;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static public class UserData
    {
        static private List<User> _testUsers;
        static public List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }
        static private void ResetTestUserData()
        {

            if (_testUsers == null)
            {
                _testUsers = new List<User>(3);

                _testUsers.Add(new User());
                _testUsers[0].UserName = "ADMIN";
                _testUsers[0].Password = "054321";
                _testUsers[0].FacNum = "123654789";
                _testUsers[0].Role = 1;
                _testUsers[0].dateCreated = DateTime.Now;
                _testUsers[0].validity = DateTime.MaxValue;

                _testUsers.Add(new User());
                _testUsers[1].UserName = "Asiana Alyolova";
                _testUsers[1].Password = "wordpass2";
                _testUsers[1].FacNum = "121219026";
                _testUsers[1].Role = 2;
                _testUsers[1].dateCreated = DateTime.Now;
                _testUsers[1].validity = DateTime.MaxValue;

                _testUsers.Add(new User());
                _testUsers[2].UserName = "Mirela Basheva";
                _testUsers[2].Password = "wordpass1";
                _testUsers[2].FacNum = "121219048";
                _testUsers[2].Role = 2;
                _testUsers[2].dateCreated = DateTime.Now;
                _testUsers[2].validity = DateTime.MaxValue;
            }
        }

        static public User IsUserPassCorrect(string user, string pass)
        {
            UserContext context = new UserContext();

            User login = (from u in context.Users where u.UserName == user && u.Password == pass select u).First();

            if (login != null)
                return login;
            return null;
        }

        static public void SetUserActiveTo(string username, DateTime newDate)
        {
            UserContext context = new UserContext();
            foreach (User u in context.Users)
            {
                if (u.UserName == username)
                {
                    u.validity = newDate;
                    Logger.LogActivity("Activity date changed of user: " + username);
                }
            }
        }

        static public void AssignUserRole(string username, int newRole)
        {
            UserContext context = new UserContext();
            foreach (User u in context.Users)
            {
                
                    u.Role = newRole; //changed
                    Logger.LogActivity("Role changed of user: " + username);
                
            }
        }
    }
}

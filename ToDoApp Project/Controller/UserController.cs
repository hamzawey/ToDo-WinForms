using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp_Project.Model;

namespace ToDoApp_Project.Controller
{
    public class UserController
    {
        public void RegisterUser(User user)
        {
            using (UsersDbEntities userEntities = new UsersDbEntities())
            {
                user.Id = userEntities.Users.ToList().LastOrDefault().Id + 1;
                userEntities.Users.Add(user);
                userEntities.SaveChanges();
            }
        }

        public bool doesExist(User user)
        {
            using (UsersDbEntities userEntities = new UsersDbEntities())
            {
                var users = userEntities.Users.ToList();
                foreach (var userExist in users)
                {
                    if (userExist.Username == user.Username)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public string findRole(User user)
        {
            string foundRole = "";
            using (UsersDbEntities userEntities = new UsersDbEntities())
            {
                var users = userEntities.Users.ToList();
                foreach (var userExist in users)
                {
                    if (userExist.Username == user.Username)
                    {
                        foundRole = userExist.Role;
                        break;
                    }
                }
                return foundRole;
            }
        }

        // temp code
        int currentLoggedUserId = 0;
        string currentLoggedUserUserName = "";
        string currentLoggedUserRole = "";
        string currentLoggedUserPassword = "";
        public void currentLoggedUserSet(User user)
        {
            using (UsersDbEntities userEntities = new UsersDbEntities())
            {
                var users = userEntities.Users.ToList();
                foreach (var userExist in users)
                {
                    if (userExist.Username == user.Username)
                    {
                        currentLoggedUserId = userExist.Id;
                        currentLoggedUserUserName = userExist.Username;
                        currentLoggedUserRole = userExist.Role;
                        currentLoggedUserPassword = userExist.Password;
                    }
                }
            }
        }
    }
}
